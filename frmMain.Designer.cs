namespace Client.Net
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.gbMulti = new System.Windows.Forms.GroupBox();
            this.lblSubmittedMC = new System.Windows.Forms.Label();
            this.lblMCAnswer = new System.Windows.Forms.Label();
            this.btnSubmitMC = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.txtMCQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbShortAnswer = new System.Windows.Forms.GroupBox();
            this.lblSubmittedSA = new System.Windows.Forms.Label();
            this.rtxtShortAnswer = new System.Windows.Forms.RichTextBox();
            this.btnSubmitSA = new System.Windows.Forms.Button();
            this.txtSAQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTrueFalse = new System.Windows.Forms.GroupBox();
            this.lblTFAnswer = new System.Windows.Forms.Label();
            this.lblSubmittedTF = new System.Windows.Forms.Label();
            this.btnSubmitTF = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.btnTrue = new System.Windows.Forms.Button();
            this.txtTFQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMatching = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.lblOption4 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMatch4 = new System.Windows.Forms.Label();
            this.lblMatch3 = new System.Windows.Forms.Label();
            this.lblMatch2 = new System.Windows.Forms.Label();
            this.lblMatch1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkStayLoggedIn = new System.Windows.Forms.CheckBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnswerSubmitted = new System.Windows.Forms.Label();
            this.gbMessages = new System.Windows.Forms.GroupBox();
            this.rbToTutor = new System.Windows.Forms.RadioButton();
            this.rbToAll = new System.Windows.Forms.RadioButton();
            this.rtbChatLog = new System.Windows.Forms.RichTextBox();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.gbMainDisplay = new System.Windows.Forms.GroupBox();
            this.gbMulti.SuspendLayout();
            this.gbShortAnswer.SuspendLayout();
            this.gbTrueFalse.SuspendLayout();
            this.gbMatching.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.gbMessages.SuspendLayout();
            this.gbMainDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(236, 183);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(6, 185);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(226, 20);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "<Type message here>";
            this.txtMessage.Enter += new System.EventHandler(this.txtMessage_Enter);
            this.txtMessage.Leave += new System.EventHandler(this.txtMessage_Leave);
            // 
            // gbMulti
            // 
            this.gbMulti.Controls.Add(this.lblSubmittedMC);
            this.gbMulti.Controls.Add(this.lblMCAnswer);
            this.gbMulti.Controls.Add(this.btnSubmitMC);
            this.gbMulti.Controls.Add(this.btnAnswer4);
            this.gbMulti.Controls.Add(this.btnAnswer3);
            this.gbMulti.Controls.Add(this.btnAnswer2);
            this.gbMulti.Controls.Add(this.btnAnswer1);
            this.gbMulti.Controls.Add(this.txtMCQuestion);
            this.gbMulti.Controls.Add(this.label1);
            this.gbMulti.Location = new System.Drawing.Point(11, 273);
            this.gbMulti.Name = "gbMulti";
            this.gbMulti.Size = new System.Drawing.Size(260, 234);
            this.gbMulti.TabIndex = 2;
            this.gbMulti.TabStop = false;
            this.gbMulti.Text = "Multi-Choice";
            // 
            // lblSubmittedMC
            // 
            this.lblSubmittedMC.AutoSize = true;
            this.lblSubmittedMC.Location = new System.Drawing.Point(73, 210);
            this.lblSubmittedMC.Name = "lblSubmittedMC";
            this.lblSubmittedMC.Size = new System.Drawing.Size(0, 13);
            this.lblSubmittedMC.TabIndex = 8;
            // 
            // lblMCAnswer
            // 
            this.lblMCAnswer.AutoSize = true;
            this.lblMCAnswer.Location = new System.Drawing.Point(7, 175);
            this.lblMCAnswer.Name = "lblMCAnswer";
            this.lblMCAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblMCAnswer.TabIndex = 7;
            // 
            // btnSubmitMC
            // 
            this.btnSubmitMC.Location = new System.Drawing.Point(180, 205);
            this.btnSubmitMC.Name = "btnSubmitMC";
            this.btnSubmitMC.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitMC.TabIndex = 6;
            this.btnSubmitMC.Text = "Submit";
            this.btnSubmitMC.UseVisualStyleBackColor = true;
            this.btnSubmitMC.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(142, 131);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(113, 38);
            this.btnAnswer4.TabIndex = 5;
            this.btnAnswer4.Text = "Answer 4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(7, 132);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(114, 38);
            this.btnAnswer3.TabIndex = 4;
            this.btnAnswer3.Text = "Answer 3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(142, 80);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(113, 36);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.Text = "Answer 2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(7, 79);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(114, 39);
            this.btnAnswer1.TabIndex = 2;
            this.btnAnswer1.Text = "Answer 1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // txtMCQuestion
            // 
            this.txtMCQuestion.Location = new System.Drawing.Point(64, 22);
            this.txtMCQuestion.Multiline = true;
            this.txtMCQuestion.Name = "txtMCQuestion";
            this.txtMCQuestion.ReadOnly = true;
            this.txtMCQuestion.Size = new System.Drawing.Size(190, 51);
            this.txtMCQuestion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // gbShortAnswer
            // 
            this.gbShortAnswer.Controls.Add(this.lblSubmittedSA);
            this.gbShortAnswer.Controls.Add(this.rtxtShortAnswer);
            this.gbShortAnswer.Controls.Add(this.btnSubmitSA);
            this.gbShortAnswer.Controls.Add(this.txtSAQuestion);
            this.gbShortAnswer.Controls.Add(this.label3);
            this.gbShortAnswer.Location = new System.Drawing.Point(271, 273);
            this.gbShortAnswer.Name = "gbShortAnswer";
            this.gbShortAnswer.Size = new System.Drawing.Size(260, 234);
            this.gbShortAnswer.TabIndex = 8;
            this.gbShortAnswer.TabStop = false;
            this.gbShortAnswer.Text = "Short Answer";
            // 
            // lblSubmittedSA
            // 
            this.lblSubmittedSA.AutoSize = true;
            this.lblSubmittedSA.Location = new System.Drawing.Point(71, 210);
            this.lblSubmittedSA.Name = "lblSubmittedSA";
            this.lblSubmittedSA.Size = new System.Drawing.Size(0, 13);
            this.lblSubmittedSA.TabIndex = 9;
            // 
            // rtxtShortAnswer
            // 
            this.rtxtShortAnswer.Location = new System.Drawing.Point(11, 79);
            this.rtxtShortAnswer.MaxLength = 150;
            this.rtxtShortAnswer.Name = "rtxtShortAnswer";
            this.rtxtShortAnswer.Size = new System.Drawing.Size(243, 120);
            this.rtxtShortAnswer.TabIndex = 7;
            this.rtxtShortAnswer.Text = "";
            // 
            // btnSubmitSA
            // 
            this.btnSubmitSA.Location = new System.Drawing.Point(179, 205);
            this.btnSubmitSA.Name = "btnSubmitSA";
            this.btnSubmitSA.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitSA.TabIndex = 6;
            this.btnSubmitSA.Text = "Submit";
            this.btnSubmitSA.UseVisualStyleBackColor = true;
            this.btnSubmitSA.Click += new System.EventHandler(this.btnSubmitSA_Click);
            // 
            // txtSAQuestion
            // 
            this.txtSAQuestion.Location = new System.Drawing.Point(64, 22);
            this.txtSAQuestion.Multiline = true;
            this.txtSAQuestion.Name = "txtSAQuestion";
            this.txtSAQuestion.ReadOnly = true;
            this.txtSAQuestion.Size = new System.Drawing.Size(190, 51);
            this.txtSAQuestion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Question:";
            // 
            // gbTrueFalse
            // 
            this.gbTrueFalse.Controls.Add(this.lblTFAnswer);
            this.gbTrueFalse.Controls.Add(this.lblSubmittedTF);
            this.gbTrueFalse.Controls.Add(this.btnSubmitTF);
            this.gbTrueFalse.Controls.Add(this.btnFalse);
            this.gbTrueFalse.Controls.Add(this.btnTrue);
            this.gbTrueFalse.Controls.Add(this.txtTFQuestion);
            this.gbTrueFalse.Controls.Add(this.label5);
            this.gbTrueFalse.Location = new System.Drawing.Point(531, 273);
            this.gbTrueFalse.Name = "gbTrueFalse";
            this.gbTrueFalse.Size = new System.Drawing.Size(260, 234);
            this.gbTrueFalse.TabIndex = 9;
            this.gbTrueFalse.TabStop = false;
            this.gbTrueFalse.Text = "True/False";
            // 
            // lblTFAnswer
            // 
            this.lblTFAnswer.AutoSize = true;
            this.lblTFAnswer.Location = new System.Drawing.Point(6, 175);
            this.lblTFAnswer.Name = "lblTFAnswer";
            this.lblTFAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblTFAnswer.TabIndex = 12;
            // 
            // lblSubmittedTF
            // 
            this.lblSubmittedTF.AutoSize = true;
            this.lblSubmittedTF.Location = new System.Drawing.Point(71, 205);
            this.lblSubmittedTF.Name = "lblSubmittedTF";
            this.lblSubmittedTF.Size = new System.Drawing.Size(0, 13);
            this.lblSubmittedTF.TabIndex = 11;
            // 
            // btnSubmitTF
            // 
            this.btnSubmitTF.Location = new System.Drawing.Point(179, 200);
            this.btnSubmitTF.Name = "btnSubmitTF";
            this.btnSubmitTF.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitTF.TabIndex = 10;
            this.btnSubmitTF.Text = "Submit";
            this.btnSubmitTF.UseVisualStyleBackColor = true;
            this.btnSubmitTF.Click += new System.EventHandler(this.btnSubmitTF_Click_1);
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(138, 82);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(113, 39);
            this.btnFalse.TabIndex = 3;
            this.btnFalse.Text = "False";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnFalse_Click);
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(6, 80);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(113, 42);
            this.btnTrue.TabIndex = 2;
            this.btnTrue.Text = "True";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnTrue_Click);
            // 
            // txtTFQuestion
            // 
            this.txtTFQuestion.Location = new System.Drawing.Point(64, 22);
            this.txtTFQuestion.Multiline = true;
            this.txtTFQuestion.Name = "txtTFQuestion";
            this.txtTFQuestion.ReadOnly = true;
            this.txtTFQuestion.Size = new System.Drawing.Size(190, 51);
            this.txtTFQuestion.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Question:";
            // 
            // gbMatching
            // 
            this.gbMatching.Controls.Add(this.panel2);
            this.gbMatching.Controls.Add(this.panel1);
            this.gbMatching.Controls.Add(this.button1);
            this.gbMatching.Controls.Add(this.textBox1);
            this.gbMatching.Controls.Add(this.label7);
            this.gbMatching.Location = new System.Drawing.Point(791, 273);
            this.gbMatching.Name = "gbMatching";
            this.gbMatching.Size = new System.Drawing.Size(260, 234);
            this.gbMatching.TabIndex = 10;
            this.gbMatching.TabStop = false;
            this.gbMatching.Text = "Matching";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOption4);
            this.panel2.Controls.Add(this.txtOption3);
            this.panel2.Controls.Add(this.txtOption2);
            this.panel2.Controls.Add(this.txtOption1);
            this.panel2.Controls.Add(this.lblOption4);
            this.panel2.Controls.Add(this.lblOption2);
            this.panel2.Controls.Add(this.lblOption3);
            this.panel2.Controls.Add(this.lblOption1);
            this.panel2.Location = new System.Drawing.Point(148, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 100);
            this.panel2.TabIndex = 16;
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(56, 73);
            this.txtOption4.MaxLength = 1;
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(26, 20);
            this.txtOption4.TabIndex = 11;
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(56, 51);
            this.txtOption3.MaxLength = 1;
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(26, 20);
            this.txtOption3.TabIndex = 10;
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(56, 29);
            this.txtOption2.MaxLength = 1;
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(26, 20);
            this.txtOption2.TabIndex = 9;
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(56, 7);
            this.txtOption1.MaxLength = 1;
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(26, 20);
            this.txtOption1.TabIndex = 8;
            // 
            // lblOption4
            // 
            this.lblOption4.AutoSize = true;
            this.lblOption4.Location = new System.Drawing.Point(3, 76);
            this.lblOption4.Name = "lblOption4";
            this.lblOption4.Size = new System.Drawing.Size(47, 13);
            this.lblOption4.TabIndex = 7;
            this.lblOption4.Text = "Option 4";
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.Location = new System.Drawing.Point(3, 32);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(47, 13);
            this.lblOption2.TabIndex = 5;
            this.lblOption2.Text = "Option 2";
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.Location = new System.Drawing.Point(3, 54);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(47, 13);
            this.lblOption3.TabIndex = 6;
            this.lblOption3.Text = "Option 3";
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.Location = new System.Drawing.Point(3, 10);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(47, 13);
            this.lblOption1.TabIndex = 4;
            this.lblOption1.Text = "Option 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMatch4);
            this.panel1.Controls.Add(this.lblMatch3);
            this.panel1.Controls.Add(this.lblMatch2);
            this.panel1.Controls.Add(this.lblMatch1);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 100);
            this.panel1.TabIndex = 15;
            // 
            // lblMatch4
            // 
            this.lblMatch4.AutoSize = true;
            this.lblMatch4.Location = new System.Drawing.Point(6, 73);
            this.lblMatch4.Name = "lblMatch4";
            this.lblMatch4.Size = new System.Drawing.Size(46, 13);
            this.lblMatch4.TabIndex = 3;
            this.lblMatch4.Text = "Match 4";
            // 
            // lblMatch3
            // 
            this.lblMatch3.AutoSize = true;
            this.lblMatch3.Location = new System.Drawing.Point(6, 53);
            this.lblMatch3.Name = "lblMatch3";
            this.lblMatch3.Size = new System.Drawing.Size(46, 13);
            this.lblMatch3.TabIndex = 2;
            this.lblMatch3.Text = "Match 3";
            // 
            // lblMatch2
            // 
            this.lblMatch2.AutoSize = true;
            this.lblMatch2.Location = new System.Drawing.Point(6, 32);
            this.lblMatch2.Name = "lblMatch2";
            this.lblMatch2.Size = new System.Drawing.Size(46, 13);
            this.lblMatch2.TabIndex = 1;
            this.lblMatch2.Text = "Match 2";
            // 
            // lblMatch1
            // 
            this.lblMatch1.AutoSize = true;
            this.lblMatch1.Location = new System.Drawing.Point(6, 10);
            this.lblMatch1.Name = "lblMatch1";
            this.lblMatch1.Size = new System.Drawing.Size(46, 13);
            this.lblMatch1.TabIndex = 0;
            this.lblMatch1.Text = "Match 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Question:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Enabled = false;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(114, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userSettingsToolStripMenuItem,
            this.connectionsSettingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.userSettingsToolStripMenuItem.Text = "User Settings";
            // 
            // connectionsSettingsToolStripMenuItem
            // 
            this.connectionsSettingsToolStripMenuItem.Name = "connectionsSettingsToolStripMenuItem";
            this.connectionsSettingsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.connectionsSettingsToolStripMenuItem.Text = "Connection Settings";
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.txtServerPort);
            this.gbLogin.Controls.Add(this.label8);
            this.gbLogin.Controls.Add(this.txtServerAddress);
            this.gbLogin.Controls.Add(this.label6);
            this.gbLogin.Controls.Add(this.chkStayLoggedIn);
            this.gbLogin.Controls.Add(this.lblConnectionStatus);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtUsername);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Location = new System.Drawing.Point(12, 27);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(260, 234);
            this.gbLogin.TabIndex = 8;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "User Details";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(75, 108);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(179, 20);
            this.txtServerPort.TabIndex = 12;
            this.txtServerPort.Tag = "";
            this.txtServerPort.Text = "8000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Server Port:";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(75, 82);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(179, 20);
            this.txtServerAddress.TabIndex = 10;
            this.txtServerAddress.TextChanged += new System.EventHandler(this.txtServerAddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Server IP:";
            // 
            // chkStayLoggedIn
            // 
            this.chkStayLoggedIn.AutoSize = true;
            this.chkStayLoggedIn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStayLoggedIn.Checked = true;
            this.chkStayLoggedIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStayLoggedIn.Location = new System.Drawing.Point(6, 57);
            this.chkStayLoggedIn.Name = "chkStayLoggedIn";
            this.chkStayLoggedIn.Size = new System.Drawing.Size(123, 17);
            this.chkStayLoggedIn.TabIndex = 8;
            this.chkStayLoggedIn.Text = "Log in Automatically:";
            this.chkStayLoggedIn.UseVisualStyleBackColor = true;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(6, 142);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(166, 13);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Connection Status: Disconnected";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(179, 177);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(75, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name:";
            // 
            // lblAnswerSubmitted
            // 
            this.lblAnswerSubmitted.AutoSize = true;
            this.lblAnswerSubmitted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerSubmitted.Location = new System.Drawing.Point(60, 57);
            this.lblAnswerSubmitted.Name = "lblAnswerSubmitted";
            this.lblAnswerSubmitted.Size = new System.Drawing.Size(139, 20);
            this.lblAnswerSubmitted.TabIndex = 13;
            this.lblAnswerSubmitted.Text = "Answer Submitted";
            // 
            // gbMessages
            // 
            this.gbMessages.Controls.Add(this.rbToTutor);
            this.gbMessages.Controls.Add(this.rbToAll);
            this.gbMessages.Controls.Add(this.rtbChatLog);
            this.gbMessages.Controls.Add(this.txtMessage);
            this.gbMessages.Controls.Add(this.btnSend);
            this.gbMessages.Location = new System.Drawing.Point(278, 27);
            this.gbMessages.Name = "gbMessages";
            this.gbMessages.Size = new System.Drawing.Size(317, 234);
            this.gbMessages.TabIndex = 12;
            this.gbMessages.TabStop = false;
            this.gbMessages.Text = "Messages";
            // 
            // rbToTutor
            // 
            this.rbToTutor.AutoSize = true;
            this.rbToTutor.Location = new System.Drawing.Point(167, 211);
            this.rbToTutor.Name = "rbToTutor";
            this.rbToTutor.Size = new System.Drawing.Size(94, 17);
            this.rbToTutor.TabIndex = 3;
            this.rbToTutor.Text = "Send To Tutor";
            this.rbToTutor.UseVisualStyleBackColor = true;
            // 
            // rbToAll
            // 
            this.rbToAll.AutoSize = true;
            this.rbToAll.Checked = true;
            this.rbToAll.Location = new System.Drawing.Point(67, 211);
            this.rbToAll.Name = "rbToAll";
            this.rbToAll.Size = new System.Drawing.Size(80, 17);
            this.rbToAll.TabIndex = 2;
            this.rbToAll.TabStop = true;
            this.rbToAll.Text = "Send To All";
            this.rbToAll.UseVisualStyleBackColor = true;
            // 
            // rtbChatLog
            // 
            this.rtbChatLog.Location = new System.Drawing.Point(6, 17);
            this.rtbChatLog.Name = "rtbChatLog";
            this.rtbChatLog.ReadOnly = true;
            this.rtbChatLog.Size = new System.Drawing.Size(305, 160);
            this.rtbChatLog.TabIndex = 0;
            this.rtbChatLog.Text = "";
            this.rtbChatLog.TextChanged += new System.EventHandler(this.rtbChatLog_TextChanged);
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.Location = new System.Drawing.Point(10, 99);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(234, 25);
            this.lblWaiting.TabIndex = 13;
            this.lblWaiting.Text = "Waiting For Question";
            // 
            // gbMainDisplay
            // 
            this.gbMainDisplay.Controls.Add(this.lblAnswerSubmitted);
            this.gbMainDisplay.Controls.Add(this.lblWaiting);
            this.gbMainDisplay.Location = new System.Drawing.Point(605, 27);
            this.gbMainDisplay.Name = "gbMainDisplay";
            this.gbMainDisplay.Size = new System.Drawing.Size(260, 234);
            this.gbMainDisplay.TabIndex = 14;
            this.gbMainDisplay.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 520);
            this.Controls.Add(this.gbMainDisplay);
            this.Controls.Add(this.gbMessages);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.gbMatching);
            this.Controls.Add(this.gbTrueFalse);
            this.Controls.Add(this.gbMulti);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbShortAnswer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Student Client - Not Logged In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbMulti.ResumeLayout(false);
            this.gbMulti.PerformLayout();
            this.gbShortAnswer.ResumeLayout(false);
            this.gbShortAnswer.PerformLayout();
            this.gbTrueFalse.ResumeLayout(false);
            this.gbTrueFalse.PerformLayout();
            this.gbMatching.ResumeLayout(false);
            this.gbMatching.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbMessages.ResumeLayout(false);
            this.gbMessages.PerformLayout();
            this.gbMainDisplay.ResumeLayout(false);
            this.gbMainDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox gbMulti;
        private System.Windows.Forms.Button btnSubmitMC;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.TextBox txtMCQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMCAnswer;
        private System.Windows.Forms.GroupBox gbShortAnswer;
        private System.Windows.Forms.Button btnSubmitSA;
        private System.Windows.Forms.TextBox txtSAQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbTrueFalse;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.TextBox txtTFQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtShortAnswer;
        private System.Windows.Forms.GroupBox gbMatching;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMatch4;
        private System.Windows.Forms.Label lblMatch3;
        private System.Windows.Forms.Label lblMatch2;
        private System.Windows.Forms.Label lblMatch1;
        private System.Windows.Forms.Label lblOption4;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsSettingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbMessages;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.CheckBox chkStayLoggedIn;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbToTutor;
        private System.Windows.Forms.RadioButton rbToAll;
        private System.Windows.Forms.RichTextBox rtbChatLog;
        private System.Windows.Forms.Label lblSubmittedMC;
        private System.Windows.Forms.Label lblSubmittedSA;
        private System.Windows.Forms.Label lblSubmittedTF;
        private System.Windows.Forms.Button btnSubmitTF;
        private System.Windows.Forms.Label lblTFAnswer;
        private System.Windows.Forms.Label lblAnswerSubmitted;
        private System.Windows.Forms.GroupBox gbMainDisplay;
    }
}

