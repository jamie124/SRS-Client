using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Client.Net
{
    // Custom Dictionary Serializer
    public class DictionarySerializer<K, V>
    {
        public struct SerializableKeyValuePair<TKey, TValue>
        {
            public TKey Key;
            public TValue Value;
            public SerializableKeyValuePair(KeyValuePair<TKey, TValue> kvp)
            {
                this.Key = kvp.Key;
                this.Value = kvp.Value;
            }
        }

        private XmlSerializer Serializer = new XmlSerializer(typeof(List<SerializableKeyValuePair<K, V>>));

        public void Serialize(Dictionary<K, V> dictionary, XmlWriter serializationStream)
        {
            Serializer.Serialize(serializationStream, BuildItemList(dictionary));
        }
        public void Serialize(Dictionary<K, V> dictionary, TextWriter serializationStream)
        {
            Serializer.Serialize(serializationStream, BuildItemList(dictionary));
        }
        public void Serialize(Dictionary<K, V> dictionary, Stream serializationStream)
        {
            Serializer.Serialize(serializationStream, BuildItemList(dictionary));
        }

        private List<SerializableKeyValuePair<K, V>> BuildItemList(Dictionary<K, V> dictionary)
        {
            List<SerializableKeyValuePair<K, V>> list = new List<SerializableKeyValuePair<K, V>>();
            foreach (KeyValuePair<K, V> nonSerializableKVP in dictionary)
            {
                list.Add(new SerializableKeyValuePair<K, V>(nonSerializableKVP));
            }

            return list;

        }


        public Dictionary<K, V> Deserialize(XmlReader serializationStream)
        {
            List<SerializableKeyValuePair<K, V>> dictionaryItems = Serializer.Deserialize(serializationStream) as List<SerializableKeyValuePair<K, V>>;
            return BuildDictionary(dictionaryItems);
        }
        public Dictionary<K, V> Deserialize(TextReader serializationStream)
        {
            List<SerializableKeyValuePair<K, V>> dictionaryItems = Serializer.Deserialize(serializationStream) as List<SerializableKeyValuePair<K, V>>;
            return BuildDictionary(dictionaryItems);
        }
        public Dictionary<K, V> Deserialize(Stream serializationStream)
        {
            List<SerializableKeyValuePair<K, V>> dictionaryItems = Serializer.Deserialize(serializationStream) as List<SerializableKeyValuePair<K, V>>;
            return BuildDictionary(dictionaryItems);
        }

        private Dictionary<K, V> BuildDictionary(List<SerializableKeyValuePair<K, V>> dictionaryItems)
        {
            Dictionary<K, V> dictionary = new Dictionary<K, V>(dictionaryItems.Count);
            foreach (SerializableKeyValuePair<K, V> item in dictionaryItems)
            {
                dictionary.Add(item.Key, item.Value);
            }

            return dictionary;
        }
    }

    public class DictionarySerialiserMethods
    {
        // Convert the question to a byte array
        public byte[] ConvertQuestionToByteArray(question prQuestion)
        {
            MemoryStream iMemoryStream = new MemoryStream();
            XmlTextWriter iXmlWriter = new XmlTextWriter(iMemoryStream, Encoding.UTF8);

            XmlSerializer iSerializer = new XmlSerializer(typeof(question));
            try
            {
                iSerializer.Serialize(iMemoryStream, prQuestion);
                return iMemoryStream.ToArray();
            }
            catch (System.Exception ex)
            {
                return null;
            }
            finally
            {
                iMemoryStream.Close();
            }
        }

        // Convert the transferrableUserDetails to a byte array
        public byte[] ConvertUserDetailsToByteArray(transferrableUserDetails prUserDetails)
        {
            MemoryStream iMemoryStream = new MemoryStream();
            XmlTextWriter iXmlWriter = new XmlTextWriter(iMemoryStream, Encoding.UTF8);

            XmlSerializer iSerializer = new XmlSerializer(typeof(transferrableUserDetails));
            try
            {
                iSerializer.Serialize(iMemoryStream, prUserDetails);
                return iMemoryStream.ToArray();
            }
            catch (System.Exception ex)
            {
                return null;
            }
            finally
            {
                iMemoryStream.Close();
            }
        }

        // Convert the ChatMessage to a byte array
        public byte[] ConvertChatMessageToByteArray(ChatMessage prChatMessage)
        {
            MemoryStream iMemoryStream = new MemoryStream();
            XmlTextWriter iXmlWriter = new XmlTextWriter(iMemoryStream, Encoding.UTF8);

            XmlSerializer iSerializer = new XmlSerializer(typeof(ChatMessage));
            try
            {
                iSerializer.Serialize(iMemoryStream, prChatMessage);
                return iMemoryStream.ToArray();
            }
            catch (System.Exception ex)
            {
                return null;
            }
            finally
            {
                iMemoryStream.Close();
            }
        }

        // Deserialize the question
        public question ConvertStringToQuestion(string prData)
        {
            MemoryStream iMemoryStream = new MemoryStream(StringToUTF8ByteArray(prData));
            XmlSerializer iSerializer = new XmlSerializer(typeof(question));
            XmlTextWriter iXmlWriter = new XmlTextWriter(iMemoryStream, Encoding.UTF8);
            return (question)iSerializer.Deserialize(iMemoryStream);
        }

        // Deserialize the chat message
        public ChatMessage ConvertStringToChatMessage(string prData)
        {
            MemoryStream iMemoryStream = new MemoryStream(StringToUTF8ByteArray(prData));
            XmlSerializer iSerializer = new XmlSerializer(typeof(ChatMessage));
            XmlTextWriter iXmlWriter = new XmlTextWriter(iMemoryStream, Encoding.UTF8);
            return (ChatMessage)iSerializer.Deserialize(iMemoryStream);
        }

        private Byte[] StringToUTF8ByteArray(String pXmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(pXmlString);
            return byteArray;
        } 

    }
}
