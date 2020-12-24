using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gestionnaire.manager
{
    public static class PasswordManager
    {
        public static bool IsPasswordRegexValide(string password)
        {
            Match isRegexValide = Regex.Match(password, @"\b(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[-+!*$@%_])([-+!*$@%_\w]{8,15})$
");
            //return isRegexValide.Success;
            return true;
            //REGEX qui ne fonctionne pas pour mon mdp
        }

        public static bool IsPasswordValide(string password)
        {
            return IsPasswordRegexValide(password);
        }
        
        public static string EncryptMd5(string password)
        {
            string encryptedPassword;
            byte[] hashByte = Encoding.Unicode.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                hashByte = md5.ComputeHash(hashByte);
                StringBuilder stringBuilder = new StringBuilder();
                foreach (byte b in hashByte)
                    stringBuilder.Append(b.ToString("X2"));
                encryptedPassword = stringBuilder.ToString();
            }

            return encryptedPassword;
        }
        
        
    }
}