
using System;
using System.Xml.Serialization;
using Accessibility;

namespace Gestionnaire.model
{
    public class Entry: IGestionnaire
    {
        public static string folderName = @"../../../Data";
        
        private static string _name;
        public static string Name
        {
            get => _name;
            set => _name = value;
        }

        private static string _userName;

        public static string UserName
        {
            get => _userName;
            set => _userName = value;
        }

        private static Uri _url;
        public static Uri Url
        {
            get => _url;
            set => _url = value;
        }
        
        private static string _password;
        public static string Password
        {
            get => _password;
            set => _password = value;
        }

        private int _id;
        [XmlAttribute(AttributeName = "id")]
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public Entry()
        {
            
        }

        public Entry(string name, string username, Uri url, string password, int id)
        {
            Name = name;
            UserName = username;
            Url = url;
            Password = password;
            _id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }
}