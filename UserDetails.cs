using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Client.Net
{
    [Serializable()]
    // This is cut down version of the userDetails, containing only the important information
    public class transferrableUserDetails
    {
        private string mUsername;
        private string mPassword;
        private string mDeviceOS;
        private string mUserRole;

        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public string DeviceOS
        {
            get { return mDeviceOS; }
            set { mDeviceOS = value; }
        }
        public string UserRole
        {
            get { return mUserRole; }
            set { mUserRole = value; }
        }
        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {

            info.AddValue("UserName", mUsername);
            info.AddValue("DeviceOS", mDeviceOS);
            info.AddValue("UserRole", mUserRole);
        }
    }
}
