using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Net;

// Note random comments in English:German are me getting bored and practicing.
namespace Client.Net
{
    public partial class frmMain : Form
    {
        const int mPort = 8000;
        //const string mIPAddress = "192.168.1.64";
        //const string mIPAddress = "192.168.1.76";
        //const string mIPAddress = "172.19.20.98";
        //const string mIPAddress = "127.0.0.1";

        // Connection handling
        string mConnectionResponse = "";        // Holds the response from the clients connection request
        bool mConnected = false;                // Is the client connected. Ist die Kunde verbunden.
        
        // Used for keeping track of login process
        private bool mIsConnected;          
        private bool mLoggedIn;

        TcpClient mClient;
        NetworkStream mStream;
        User mUser;
        question mQuestion;
        Settings mSettings;

        DictionarySerialiserMethods mDictionarySerialiser;

        Thread mListenThread;               // For listening for incoming data
        Thread mConnectionResponseThread;   // Thread for connecting to the server

        // Answers.
        Answer mAnswer;
        private string mSelectedAnswerMC = "";
        private string mSelectedAnswerTF = "";

        // Chat handling
        ChatMessage mChatMessage;

        #region Delegates
        delegate void SetTFQuestionCallback(string prText);
        delegate void SetSAQuestionCallback(string prText);
        delegate void SetMAQuestionCallback(string prText);

        // Callbacks for multi threading
        delegate void SetMCQuestionCallback(string prText);
        //delegate void SetTrueFalseCallback(string prText, int prSwitch);
        delegate void SetAnswerLblCallback(string prText);
        delegate void SetShortAnswerTextCallback(string prText);
        delegate void SetPossibleAnswerCallback(string prText, int prAnswer);
        delegate void SetChatCallback(string prText);

        // Question callbacks
        delegate void SetMultiChoiceCallback();
        delegate void SetTrueFalseCallback();
        delegate void SetShortAnswerCallback();
        delegate void SetMatchingCallback();

        delegate void SetWindowCallback(string prText);

        delegate void SetMainDisplayCallback(bool prVisible, bool prSubmittedAnswer);
        delegate void SetLoginCallback(bool prVisible);

        delegate void SetConnectionStatusCallback(string prText);
        delegate void ToggleAwaitingQuestionCallback(bool prToggle);
        delegate void ToggleSendChatCallback(bool prToggle);

        // Chat messages
        delegate void AddChatMessageCallback(ChatMessage prText);

        #endregion
        // Functions for talking to controls across threads
        #region Callbacks

        // Set multi-choice question text thread safely
        private void SetMCQuestionText(string prText)
        {
            if (this.txtMCQuestion.InvokeRequired)
            {
                SetMCQuestionCallback q = new SetMCQuestionCallback(SetMCQuestionText);
                this.Invoke(q, new object[] { prText });
            }
            else
            {
                this.txtMCQuestion.Text = prText;
            }
        }

        // Set true/false question text thread safely
        private void SetTFQuestionText(string prText)
        {
            if (this.txtTFQuestion.InvokeRequired)
            {
                SetTFQuestionCallback q = new SetTFQuestionCallback(SetTFQuestionText);
                this.Invoke(q, new object[] { prText });
            }
            else
            {
                this.txtTFQuestion.Text = prText;
            }
        }

        // Set short answer question text thread safely
        private void SetSAQuestionText(string prText)
        {
            if (this.txtSAQuestion.InvokeRequired)
            {
                SetSAQuestionCallback q = new SetSAQuestionCallback(SetSAQuestionText);
                this.Invoke(q, new object[] { prText });
            }
            else
            {
                this.txtSAQuestion.Text = prText;
            }
        }

        // Set matching question text thread safely
        private void SetMAQuestionText(string prText)
        {
            if (this.txtMCQuestion.InvokeRequired)
            {
                SetMAQuestionCallback q = new SetMAQuestionCallback(SetMAQuestionText);
                this.Invoke(q, new object[] { prText });
            }
            else
            {
                this.txtMCQuestion.Text = prText;
            }
        }

        // Toggle the visibility of the awaiting question label
        private void WaitingLabelVisible(bool prToggle)
        {
            if (this.lblWaiting.InvokeRequired)
            {
                ToggleAwaitingQuestionCallback a = new ToggleAwaitingQuestionCallback(WaitingLabelVisible);
                this.Invoke(a, new object[] { prToggle });
            }
            else
            {
                this.lblWaiting.Visible = prToggle;
            }
        }

        // Enable multi-choice answer.
        private void EnableMultiChoice()
        {
            if (this.gbMulti.InvokeRequired)
            {
                SetMultiChoiceCallback m = new SetMultiChoiceCallback(EnableMultiChoice);
                this.Invoke(m, new object[] { });
            }
            else
            {
                this.gbMulti.Location = new Point(12, 27);

                lblSubmittedMC.Text = "";
                lblMCAnswer.Text = "";
            }
        }

        // Enable short answer.
        private void EnableShortAnswer()
        {
            if (this.gbShortAnswer.InvokeRequired)
            {
                SetShortAnswerCallback s = new SetShortAnswerCallback(EnableShortAnswer);
                this.Invoke(s, new object[] { });
            }
            else
            {
                this.gbShortAnswer.Location = new Point(12, 27);
                lblSubmittedSA.Text = "";
            }
        }



        // Enable true/false answer. 
        private void EnableTrueFalseAnswer()
        {
            if (this.gbTrueFalse.InvokeRequired)
            {
                SetTrueFalseCallback tf = new SetTrueFalseCallback(EnableTrueFalseAnswer);
                this.Invoke(tf, new object[] { });
            }
            else
            {
                this.gbTrueFalse.Location = new Point(12, 27);
                lblSubmittedTF.Text = "";
                lblTFAnswer.Text = "";
            }
        }

        // Set the window title
        private void SetWindowTitle(string prText)
        {
            if (this.InvokeRequired)
            {
                SetWindowCallback w = new SetWindowCallback(SetWindowTitle);
                this.Invoke(w, new object[] { prText });
            }
            else
            {
                this.Text = prText;
            }
        }

        // Toggle the login groupbox.
        private void ToggleLoginGroupbox(bool prVisible)
        {
            if (this.gbLogin.InvokeRequired)
            {
                SetLoginCallback l = new SetLoginCallback(ToggleLoginGroupbox);
                this.Invoke(l, new object[] { prVisible });
            }
            else
            {
                if (prVisible == true)
                {
                    this.gbLogin.Location = new Point(12, 27);
                }
                else
                {
                    this.gbLogin.Location = new Point(601, 32);
                }
            }
        }

        // Toggle the main display groupbox
        private void ToggleMainDisplayGroupbox(bool prVisible, bool prSubmittedAnswer)
        {
            if (this.gbMainDisplay.InvokeRequired)
            {
                SetMainDisplayCallback md = new SetMainDisplayCallback(ToggleMainDisplayGroupbox);
                this.Invoke(md, new object[] { prVisible, prSubmittedAnswer });
            }
            else
            {
                if (prVisible == true)
                {
                    this.gbMainDisplay.Location = new Point(12, 27);

                    // If an answer has been submitted, display the submitted answer text
                    if (prSubmittedAnswer == true)
                    {
                        this.lblAnswerSubmitted.Text = "Answer Submitted";
                    }
                    else
                    {
                        this.lblAnswerSubmitted.Text = "";
                    }
                }
                else
                {
                    this.gbMainDisplay.Location = new Point(605, 27);
                }
            }
        }

        private void SetPossibleAnswer(string prText, int prAnswer)
        {
            if (GetAnswerButton(prAnswer).InvokeRequired)
            {
                SetPossibleAnswerCallback q = new SetPossibleAnswerCallback(SetPossibleAnswer);
                this.Invoke(q, new object[] { prText, prAnswer });
            }
            else
            {
                GetAnswerButton(prAnswer).Text = prText;
                // If no possible answer is available, hide the button
                if (prText == "")
                    GetAnswerButton(prAnswer).Visible = false;
                else
                    GetAnswerButton(prAnswer).Visible = true;
            }
        }

        private void SetChatText(string prText)
        {
            if (txtMessage.InvokeRequired)
            {
                SetChatCallback c = new SetChatCallback(SetChatText);
                this.Invoke(c, new object[] { prText });
            }
            else
            {
                txtMessage.Text = prText;
            }
        }

        // Set the short answer text box text
        private void SetShortAnswerText(string prText)
        {
            if (this.rtxtShortAnswer.InvokeRequired)
            {
                SetShortAnswerTextCallback sa = new SetShortAnswerTextCallback(SetShortAnswerText);
                this.Invoke(sa, new object[] { prText });
            }
            else
            {
                this.rtxtShortAnswer.Text = prText;
            }
        }

        // Set the answer the user selected
        private void SetAnswerLblText(string prText)
        {
            if (this.lblMCAnswer.InvokeRequired)
            {
                SetAnswerLblCallback al = new SetAnswerLblCallback(SetAnswerLblText);
                this.Invoke(al, new object[] { prText });
            }
            else
            {
                this.lblMCAnswer.Text = prText;
            }
        }

        private void SetConnectionStatus(string prText)
        {
            if (this.lblConnectionStatus.InvokeRequired)
            {
                try
                {
                    SetConnectionStatusCallback cs = new SetConnectionStatusCallback(SetConnectionStatus);
                    this.Invoke(cs, new object[] { prText });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                this.lblConnectionStatus.Text = "Connection Status: " + prText;
            }
        }

        // Toggle the send message button
        private void ToggleSendMessage(bool prToggle)
        {
            if (this.btnSend.InvokeRequired)
            {
                try
                {
                    ToggleSendChatCallback sc = new ToggleSendChatCallback(ToggleSendMessage);
                    this.Invoke(sc, new object[] { prToggle });
                }
                catch (System.Exception ex)
                {
                }
            }
            else
            {
                this.btnSend.Enabled = prToggle;
            }
        }

        // Add text to the chat log
        private void AddMessageToChatLog(ChatMessage prMessage)
        {
            if (this.rtbChatLog.InvokeRequired)
            {
                try
                {
                    AddChatMessageCallback cs = new AddChatMessageCallback(AddMessageToChatLog);
                    this.Invoke(cs, new object[] { prMessage });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                this.rtbChatLog.Text += prMessage.From + ":" + prMessage.Message + "\n";
            }
        }

        #endregion

        public frmMain()
        {
            InitializeComponent();

            this.Width = 613;       // Set client width
            this.Height = 302;      // Set client height

            mSettings = new Settings();
            mUser = new User();

            mQuestion = new question();
            mAnswer = new Answer();
            mDictionarySerialiser = new DictionarySerialiserMethods();

            if (LoadUserSettings("usersettings.xml") == false)
            {
                mSettings.UserName = "James";
                mSettings.ServerIP = txtServerAddress.Text;
                mSettings.ServerPort = txtServerPort.ToString();
                mSettings.AutoLogin = false;

                SaveUserSettings(mSettings);
            }
            else
            {
                if (mSettings.AutoLogin == true)
                    StartConnectionThread();
                else
                {
                    txtUsername.Text = mSettings.UserName;
                    txtServerAddress.Text = mSettings.ServerIP;
                    txtServerPort.Text = mSettings.ServerPort;
                    chkStayLoggedIn.Checked = mSettings.AutoLogin;
                }
            }

        }

        // Save user setting to file
        private void SaveUserSettings(Settings prSettings)
        {
            // Create a new file
            XmlTextWriter iTextWriter = new XmlTextWriter("usersettings.xml", null);
            // Opens the document
            iTextWriter.WriteStartDocument();

            // Comments
            iTextWriter.WriteComment("Users Settings for SRS Client");

            // Write first element
            iTextWriter.WriteStartElement("Student");
            iTextWriter.WriteStartElement("r", "RECORD", "urn:record");

            // Username
            iTextWriter.WriteStartElement("UserName", "");
            iTextWriter.WriteString(prSettings.UserName);
            iTextWriter.WriteEndElement();

            // Server Address
            iTextWriter.WriteStartElement("ServerAddress", "");
            iTextWriter.WriteString(prSettings.ServerIP);
            iTextWriter.WriteEndElement();

            // Server Port
            iTextWriter.WriteStartElement("ServerPort", "");
            iTextWriter.WriteString(prSettings.ServerPort);
            iTextWriter.WriteEndElement();

            // AutoLogin
            iTextWriter.WriteStartElement("AutoLogin", "");
            iTextWriter.WriteString(prSettings.AutoLogin.ToString());
            iTextWriter.WriteEndElement();

            // Ends the document.
            iTextWriter.WriteEndDocument();

            // Close the writer
            iTextWriter.Close();
        }

        // Attempt to load the users settings
        private bool LoadUserSettings(string prFilename)
        {
            if (File.Exists(prFilename))
            {
                XmlDocument iXmlDocument = new XmlDocument();

                iXmlDocument.Load(prFilename);

                //Make sure document has been loaded
                if (iXmlDocument != null)
                {
                    XmlNodeList iStudents = iXmlDocument.ChildNodes;
                    XmlNodeList iCityDetails;
                    foreach (XmlNode iNode in iStudents)
                    {
                        if (iNode.InnerText != "version=\"1.0\"")
                        {
                            iCityDetails = iNode.ChildNodes;
                            foreach (XmlNode iStudent in iCityDetails)
                            {
                                mSettings.UserName = iStudent.ChildNodes[0].InnerText;
                                mSettings.ServerIP = iStudent.ChildNodes[1].InnerText;
                                mSettings.ServerPort = iStudent.ChildNodes[2].InnerText;
                                if (iStudent.ChildNodes[3].InnerText == "True")
                                {
                                    mSettings.AutoLogin = true;
                                }
                                else
                                    mSettings.AutoLogin = false;
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }

        private void ListenForData()
        {
            Byte[] iData = new Byte[4000];
            string iQuestionString;
            int iBytesRecv = 0;
            while (true)
            {
                try
                {
                    iBytesRecv = mStream.Read(iData, 0, iData.Length);
                }
                catch (System.Exception ex)
                {
                    break;
                }
                
                if (iBytesRecv > 0)
                {
                    iQuestionString = "";
                    iQuestionString = new string(Encoding.ASCII.GetChars(iData)).Replace("\0", "");

                    Array.Clear(iData, 0, iData.Length);

                    // Check the contents of the string
                    // TODO: Add support of chat messages

                    // Response from connect request
                    if (iQuestionString == "STUDENTCONNECTED" || iQuestionString == "USERNAMETAKEN")
                    {
                        mConnectionResponse = iQuestionString;
                    }
                    else    // Question
                    {
                        if (Regex.IsMatch(iQuestionString, "question"))
                        {
                            mQuestion.ProcessQuestion(iQuestionString);

                            Array.Clear(iData, 0, iData.Length);

                            // Question Types
                            if (mQuestion.QuestionType == "MC")         // Multi-choice
                            {
                                ResetGroupboxPositions();
                                ToggleMainDisplayGroupbox(false, false);

                                this.SetAnswerLblText("");              // Clear previous answer

                                EnableMultiChoice();
                                this.SetMCQuestionText(mQuestion.Question);

                                // Change to allow for less than 4 answers)
                                for (int i = 1; i <= 4; i++)
                                {
                                    if (mQuestion.PossibleAnswers[i - 1] != null)
                                        this.SetPossibleAnswer(mQuestion.PossibleAnswers[i - 1], i);
                                    else
                                        break;
                                }
                            }
                            else if (mQuestion.QuestionType == "SA")     // Short answer
                            {
                                ResetGroupboxPositions();
                                ToggleMainDisplayGroupbox(false, false);

                                this.SetShortAnswerText("");             // Clear previous answer

                                EnableShortAnswer();
                                this.SetSAQuestionText(mQuestion.Question);

                            }
                            else if (mQuestion.QuestionType == "TF")     // True/False
                            {
                                ResetGroupboxPositions();
                                ToggleMainDisplayGroupbox(false, false);

                                EnableTrueFalseAnswer();
                                this.SetTFQuestionText(mQuestion.Question);
                            }
                            else if (mQuestion.QuestionType == "MA")     // Matching
                            {
                                // TODO
                            }
                        }
                        else
                        {
                            // Deserialise and add the message
                            mChatMessage = mDictionarySerialiser.ConvertStringToChatMessage(iQuestionString);
                            this.AddMessageToChatLog(mChatMessage);
                            mChatMessage = null;
                        }
                    }
                }
            }
        }

        // Reset each question group box back to their default position
        private void ResetGroupboxPositions()
        {
            // Hide the multi-choice group box. Verbergen das multi-choice group box.
            if (this.gbMulti.InvokeRequired)
            {
                this.gbMulti.BeginInvoke(new MethodInvoker(delegate() { ResetGroupboxPositions(); }));
            }
            else
            {
                this.gbMulti.Location = new Point(11, 273);
            }

            // Hide the short answer group box. Verbengen das kurze Antwort group box.
            if (this.gbShortAnswer.InvokeRequired)
            {
                this.gbShortAnswer.BeginInvoke(new MethodInvoker(delegate() { ResetGroupboxPositions(); }));
            }
            else
            {
                this.gbShortAnswer.Location = new Point(271, 273);
            }
            
            // Hide the true/false group box. Verbengen das wahr/falsch group box.
            if (this.gbTrueFalse.InvokeRequired)
            {
                this.gbTrueFalse.BeginInvoke(new MethodInvoker(delegate() { ResetGroupboxPositions(); }));
            }
            else
            {
                this.gbTrueFalse.Location = new Point(531, 273);
            }
        }

        // Returns the requested button
        // 5-6 are true/false
        private Button GetAnswerButton(int prAnswer)
        {
            switch (prAnswer)
            {
                case 1:
                    return btnAnswer1;
                case 2:
                    return btnAnswer2;
                case 3:
                    return btnAnswer3;
                case 4:
                    return btnAnswer4;
                case 5:
                    return btnTrue;
                case 6:
                    return btnFalse;

            default:
                    return new Button();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            Byte[] iMessageBytes;
            ChatMessage iMessageToSend = new ChatMessage();

            if (txtMessage.Text != "")
            {
                iMessageToSend.From = mSettings.UserName;
                iMessageToSend.Message = txtMessage.Text;
                iMessageToSend.SendTo = "ALL";

                mAnswer.ProcessAnswer(mQuestion.QuestionID, mSelectedAnswerMC);
                iMessageBytes = mDictionarySerialiser.ConvertChatMessageToByteArray(iMessageToSend);

                mStream.Write(iMessageBytes, 0, iMessageBytes.Length);

                // Clear message
                txtMessage.Text = "";
              
            }
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
         
            mSelectedAnswerMC = btnAnswer1.Text;
            lblMCAnswer.Text = "Selected Answer: " + mSelectedAnswerMC;
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            mSelectedAnswerMC = btnAnswer2.Text;
            lblMCAnswer.Text = "Selected Answer: " + mSelectedAnswerMC;
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            mSelectedAnswerMC = btnAnswer3.Text;
            lblMCAnswer.Text = "Selected Answer: " + mSelectedAnswerMC;
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            mSelectedAnswerMC = btnAnswer4.Text;
            lblMCAnswer.Text = "Selected Answer: " + mSelectedAnswerMC;
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            mSelectedAnswerTF = btnTrue.Text;  
            lblTFAnswer.Text = "Selected Answer: " + mSelectedAnswerTF;

        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            mSelectedAnswerTF = btnFalse.Text;
            lblTFAnswer.Text = "Selected Answer: " + mSelectedAnswerTF;
        }

        private void btnSubmitSA_Click(object sender, EventArgs e)
        {
            Byte[] iAnswerBytes;

            mSelectedAnswerMC = rtxtShortAnswer.Text;

            mAnswer.ProcessAnswer(mQuestion.QuestionID, mSelectedAnswerMC);
            iAnswerBytes = System.Text.Encoding.ASCII.GetBytes(mAnswer.AnswerToSubmit);

            mStream.Write(iAnswerBytes, 0, iAnswerBytes.Length);

            lblSubmittedSA.Text = "Submitted Answer";

            // Reset group box positions and show answer submitted message in a group box
            ResetGroupboxPositions();
            ToggleMainDisplayGroupbox(true, true);
        }

        // Submit multi-choice question
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (mSelectedAnswerMC != "")
            {
                Byte[] iAnswerBytes;

                // Get the answer ready to be submitted
                mAnswer.ProcessAnswer(mQuestion.QuestionID, mSelectedAnswerMC);
                iAnswerBytes = System.Text.Encoding.ASCII.GetBytes(mAnswer.AnswerToSubmit);

                mStream.Write(iAnswerBytes, 0, iAnswerBytes.Length);

                lblSubmittedMC.Text = "Submitted Answer";
                mSelectedAnswerMC = "";

                // Reset group box positions and show answer submitted message in a group box
                ResetGroupboxPositions();
                ToggleMainDisplayGroupbox(true, true);
            }
            else
            {
                lblMCAnswer.Text = "Please select an answer.";
            }
        }

        private void btnSubmitTF_Click(object sender, EventArgs e)
        {
            Byte[] iAnswerBytes;

            mAnswer.ProcessAnswer(mQuestion.QuestionID, mSelectedAnswerMC);
            iAnswerBytes = System.Text.Encoding.ASCII.GetBytes(mAnswer.AnswerToSubmit);

            mStream.Write(iAnswerBytes, 0, iAnswerBytes.Length);
            mSelectedAnswerMC = "";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectClient();
            // Save the users settings to XML
            SaveUserSettings(mSettings);
        }

        // Disconnect
        private void DisconnectClient()
        {
            if (mStream != null)
                mStream.Close();
            if (mClient != null)
                mClient.Close();    
        }

        // User authentication
        private void AttemptLogin(string prUsername, string prIPAddress, int mPort)
        {
            DictionarySerialiserMethods iDictionarySerialiser = new DictionarySerialiserMethods();
            transferrableUserDetails iUserDetailsToSend = new transferrableUserDetails();

            iUserDetailsToSend.Username = prUsername;
            iUserDetailsToSend.Password = "";           // Passwords currently not implemented for students
            iUserDetailsToSend.UserRole = "Student";
            iUserDetailsToSend.DeviceOS = "WIN7";

            // Tutor Login
            byte[] iData = iDictionarySerialiser.ConvertUserDetailsToByteArray(iUserDetailsToSend);

            // Possibly unreliable method of testing. For now assume that if the connection 
            // is writable that the data was sent. 
            // TODO: Implement a check of some sort.
            if (mStream.CanWrite)
            {
                mStream.Write(iData, 0, iData.Length);
                mLoggedIn = true;
            }
            else
            {
                mLoggedIn = false;
            }

            // Start Listening for data
            mListenThread = new Thread(new ThreadStart(ListenForData));
            mListenThread.Start();
        }

        public bool ConnectToServer(string prUsername, string prIPAddress, int prPort)
        {
            // Try to connect
            this.SetConnectionStatus("Waiting for response from server");
            try
            {
                mClient = new TcpClient(prIPAddress, prPort);
            }
            catch (System.Exception ex)
            {
                mClient = null;
                this.SetConnectionStatus("Server not found or unavailable");       // Server can not be connected too
            }

            if (mClient != null)
            {
                if (mClient.Connected)
                {
                    mStream = mClient.GetStream();
                    mIsConnected = true;
                }
                else
                    mIsConnected = false;


                if (mIsConnected && !mLoggedIn)
                {
                    AttemptLogin(prUsername, prIPAddress, mPort);
                    return true;
                }
            }
            else
            {
                mIsConnected = false;
            }
            return false;
        }

        private void StartConnecting()
        {
            if (ConnectToServer(mSettings.UserName, mSettings.ServerIP, Convert.ToInt32(mSettings.ServerPort)))
            {
                //AttemptLogin(mSettings.UserName, mSettings.ServerIP, Convert.ToInt32(mSettings.ServerPort));

                while (!mConnected)
                {
                    // Wait for connection confirmation
                    this.SetConnectionStatus("Attempting to authenticate");

                    if (mConnectionResponse == "STUDENTCONNECTED")
                    {
                        // Reset group box positions
                        ResetGroupboxPositions();
                        ToggleMainDisplayGroupbox(true, false);

                        this.SetConnectionStatus("Connected");
                        mConnected = true;
                        this.ToggleLoginGroupbox(false);    // Hide login box
                        this.SetWindowTitle("Student Client - Logged in as " + mSettings.UserName);
                        this.ToggleSendMessage(true);       // Enable send message button
                    }
                    else if (mConnectionResponse == "USERNAMETAKEN")
                    {
                        MessageBox.Show("The username chosen is already in use.", "Username in use");
                        mConnected = false;
                        mConnectionResponse = "";
                    }

                    Thread.Sleep(1);
                }

            }
            SaveUserSettings(mSettings);
        }

        // Determines if the string is a valid IP
        // Source: http://www.dreamincode.net/code/snippet1379.htm
        private bool IsValidIP(string prAddress)
        {
            IPAddress iIP;
            bool iValid = false;
            if (string.IsNullOrEmpty(prAddress))
            {
                iValid = false;
            }
            else
            {
                iValid = IPAddress.TryParse(prAddress, out iIP);
            }
            return iValid;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 1)
            {
                mSettings.UserName = txtUsername.Text;
                mSettings.ServerIP = txtServerAddress.Text;
                mSettings.ServerPort = txtServerPort.Text;
                mSettings.AutoLogin = chkStayLoggedIn.Checked;
     
                StartConnectionThread();        // Start connecting

                logOutToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Username must be at least two characters long", "Username Missing");
            }
        }

        private void StartConnectionThread()
        {
            if (IsValidIP(mSettings.ServerIP))
            {
                mConnectionResponseThread = new Thread(new ThreadStart(StartConnecting));
                mConnectionResponseThread.Start();
            }
            else
                MessageBox.Show("Please enter a valid IP address", "Invalid IP");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log off?", "Log off", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                this.ToggleLoginGroupbox(true);
                DisconnectClient();
                mConnected = false;
                mLoggedIn = false;
                this.SetConnectionStatus("Disconnected");
                this.SetWindowTitle("Student Client - Not Logged In");
                this.ToggleSendMessage(false);       // Disable the send message button
                this.ToggleMainDisplayGroupbox(false, false);
                logOutToolStripMenuItem.Enabled = false;
            }
        }

        private void txtServerAddress_TextChanged(object sender, EventArgs e)
        {
            mSettings.ServerIP = txtServerAddress.Text;
            mSettings.ServerPort = txtServerPort.Text;
        }

        // Keep the chat log scrolling up when text is added
        private void rtbChatLog_TextChanged(object sender, EventArgs e)
        {
            rtbChatLog.SelectionStart = rtbChatLog.Text.Length;
            rtbChatLog.ScrollToCaret();
        }

        private void btnSubmitTF_Click_1(object sender, EventArgs e)
        {
            Byte[] iAnswerBytes;

            mAnswer.ProcessAnswer(mQuestion.QuestionID, mSelectedAnswerTF);
            iAnswerBytes = System.Text.Encoding.ASCII.GetBytes(mAnswer.AnswerToSubmit);

            mStream.Write(iAnswerBytes, 0, iAnswerBytes.Length);

            lblSubmittedTF.Text = "Submitted Answer";
            mSelectedAnswerTF = "";

            // Reset group box positions and show answer submitted message in a group box
            ResetGroupboxPositions();
            ToggleMainDisplayGroupbox(true, true);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            if (txtMessage.Text == "<Type message here>")
                txtMessage.Text = "";
        }

        private void txtMessage_Leave(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
                txtMessage.Text = "<Type message here>";
        }
        
    }
}
