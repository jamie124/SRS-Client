using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Net
{
    class ChatMessage_Back
    {
        public const int mHeaderLength = 2;
        public const int mMaxBodyLength = 512;

        public char[] data()
        {
            return mData;
        }

        public int getHeaderLength()
        {
            return mHeaderLength;
        }

        public bool decodeHeader()
        {
            char[] iHeader = new char[mHeaderLength + 1];
            string iHeaderStr = new string(iHeader);

            return true;
        }

        public void bodyLength(int prLength)
        {
            mBodyLength = prLength;
            if (mBodyLength > mMaxBodyLength)
                mBodyLength = mMaxBodyLength;
        }

        public void encodeHeader()
        {
            string iHeader = "Q;";
            //iHeader = string.Format("{0:d4}", mBodyLength);
            char[] iHeaderArray = iHeader.ToCharArray();

            System.Array.Copy(iHeaderArray, 0,mData, 0, mHeaderLength);
        }

        public void setData(char[] prData)
        {
            mData = prData;
        }

        public int getMaxHeaderLength()
        {
            return mHeaderLength;
        }

        public int getMaxBodyLength()
        {
            return mMaxBodyLength;
        }

        private char[] mData = new char[mHeaderLength + mMaxBodyLength];
        private int mBodyLength;
    }
}

