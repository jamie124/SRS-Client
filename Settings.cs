using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Net
{
    public class Settings
    {
        private string mUserName;
        private string mPassword;
        private string mServerIP;
        private string mServerPort;
        private bool mAutoLogin;

        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }
        
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public string ServerIP
        {
            get { return mServerIP; }
            set { mServerIP = value; }
        }
        public string ServerPort
        {
            get { return mServerPort; }
            set { mServerPort = value; }
        }
        public bool AutoLogin
        {
            get { return mAutoLogin; }
            set { mAutoLogin = value; }
        }
    }
}
