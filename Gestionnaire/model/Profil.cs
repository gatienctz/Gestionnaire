using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Gestionnaire.manager;

namespace Gestionnaire.model
{
    public class Profil
    {
        private string _login;
        private string _password;
        private string _idUSB;
        private string _pathFileEntries;
        
        private static string folderName = @"../../../Data";
        private static string fileName = "profilDataBase.xml";
        private static string path = Path.Combine(folderName, fileName);
        
        public string Login
        {
            get => _login;
            set
            {
                if (IsValidLogin(value))
                {
                    _login = value;
                }
                else
                {
                    throw new FormatException("Login mal formé");
                }
            }
        }
        
        public string IdUsb
        {
            get => _idUSB;
            set
            {
               _idUSB = value;
            }
        }

        public string PathFileEntries
        {
            get => _pathFileEntries;
            set => _pathFileEntries = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Password
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

        public Profil(string login, string password,string idUSB)
        {
            Login = login;
            Password = password;
            IdUsb = idUSB;
        }

        public void WriteToFile()
        {
            //Vérification de l'existance du fichier des profils
            if (!File.Exists(path))
            {
                //Création du fichier des profils
                fileName = MyUtils.CreateFile(folderName, fileName, true);
            }
            //Génération d'un fichier d'entrées pour le profil
            _pathFileEntries = MyUtils.CreateFile(Entry.folderName, _pathFileEntries, false);
            //Ajout du profil dans la base de donnée
            MyUtils.CreateNodeProfil(path, this);
        }

        public static bool IsLoginExist(string login)
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

        public static Profil? Connection(string login, string password)
        {
            bool correct; 
            if (!File.Exists(path))
                return null;

            using (StreamReader sr = new StreamReader(path))
            {
                var usbDevices = UsbDeviceInfoMain.GetUSBDevices();
                while (!sr.EndOfStream)
                {
                    string[] profil = sr.ReadLine()!.Split(';');
                    correct = profil[0].Equals(login) && profil[1].Equals(password);
                    
                    //On rajoute la vérif de la clé
                    if (correct)
                    {
                        bool cleInsert = false;
                        foreach (var entry in usbDevices)
                        {
                            if (profil[2].Equals("Device ID:" + entry.DeviceID + " , PNP Device ID: " +
                                                 entry.PnpDeviceID +
                                                 ", Description: " + entry.Description)) cleInsert = true;
                        }

                        if (cleInsert)
                        {
                            Profil p = new Profil(profil[0], profil[1], profil[2]);
                            return p;
                        }
                        MessageBox.Show("Erreur, clé non connectée !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            MessageBox.Show("Erreur, nom d'utilisateur ou mot de passe incorrect !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        
        public static bool IsValidLoginRegex(string login)
        {
            Match isValidRegex = Regex.Match(login, @"\b[A-Za-z]\w{2,19}$");
            return isValidRegex.Success;
        }
        
        public static bool IsValidLogin(string login)
        {
            return IsValidLoginRegex(login);
        }
    }
}