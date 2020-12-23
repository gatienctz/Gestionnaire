using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Gestionnaire.manager;

namespace Gestionnaire.model
{
    public class Profil
    {
        private string _login;
        private string _password;
        
        public static string path = "C:\\Users\\gatin\\Documents\\Cours OPSIE\\Programmation avancée\\Projet\\Gestionnaire\\profil.pdb";
        
        public string login
        {
            get => _login;
            set
            {
                if (isLoginValide(value))
                {
                    _login = value;
                }
                else
                {
                    throw new FormatException("Login mal formé");
                }
            }
        }

        public string password
        {
            get => _password;
            set
            {
                if (PasswordManager.IsPasswordValide(value))
                {
                    _password = PasswordManager.EncryptMd5(value);
                }
                else
                {
                    throw new FormatException("Mot de passe mal formé");
                }
            }
        }

        public Profil() {}

        public Profil(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public void writeProfilToFile()
        {
            using (StreamWriter sw = new StreamWriter(path,true))
            {
                sw.WriteLine(login + ";" + password);
            }
        }

        public static bool isLoginExist(string login)
        {
            bool isLoginExist = false; 
            if (!File.Exists(path))
                return isLoginExist;
            
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] profil = sr.ReadLine()!.Split(';');
                    isLoginExist = profil[0].Equals(login);
                }
            }

            return isLoginExist;
        }

        public static bool isConnectionCorrect(string login, string password)
        {
            bool correct; 
            if (!File.Exists(path))
                return false;
            
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] profil = sr.ReadLine()!.Split(';');
                    Console.WriteLine(profil[0]+";"+profil[1]+";"+login+";"+password);
                    correct = profil[0].Equals(login) && profil[1].Equals(password);
                    if (correct)
                        return true;
                }
            }

            return false;
        }
        
        public static bool isLoginRegexValide(string login)
        {
            Match isRegexValide = Regex.Match(login, @"\b[A-Za-z]\w{2,19}$");
            return isRegexValide.Success;
        }
        
        public static bool isLoginValide(string login)
        {
            return isLoginRegexValide(login);
        }
    }
}