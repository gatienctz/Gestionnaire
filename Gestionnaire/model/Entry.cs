using System;
using System.Xml.Serialization;
using Accessibility;

namespace Gestionnaire.model
{
    public class Entry
    {
        public static string folderName = @"../../../Data";
        
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private string _userName;

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }

        private string _url;
        public string Url
        {
            get => _url;
            set => _url = value;
        }
        
        private string _password;
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public Entry()
        {
            
        }

        public Entry(string name, string username, string url, string password)
        {
            Name = name;
            UserName = username;
            Url = url;
            Password = password;
        }

        public string deleteMessage()
        {
            return "Entrée : \n"
                   + "Nom : " + Name
                   + "\nURL : " + Url
                   + "\nNom d'utilisateur : " + UserName;
        }

        public override string ToString()
        {
            return Name + ";" + UserName + ";" + Url + ";" + _password;
        }
    }
}