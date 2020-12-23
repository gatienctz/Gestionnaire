
namespace Gestionnaire.model
{
    public class Entry
    {
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

        public Entry(string name, string url, string password)
        {
            Name = name;
            Url = url;
            Password = password;
        }
    }
}