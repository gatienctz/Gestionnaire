using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Gestionnaire.model;

namespace Gestionnaire
{
    public static class MyUtils
    {
        public const string EXTENSION = ".xml";
        public static string CreateFile(string filePath, string fileName, bool isProfilFile)
        {
            try
            {
                //Génération aléatoire d'un nom de fichier
                if (String.IsNullOrEmpty(fileName))
                {
                    fileName = Path.GetRandomFileName();
                    fileName = Path.ChangeExtension(fileName, EXTENSION);
                }
                var pathString = Path.Combine(filePath, fileName);
            
                //Vérification de l'existance du nom de fichier, regénération aléatoire tant qu'il existe.
                while (File.Exists(filePath))
                {
                    fileName = Path.GetRandomFileName();
                    fileName = Path.ChangeExtension(fileName, EXTENSION);
                    pathString = Path.Combine(filePath, fileName);
                }

                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = true, 
                    NewLineOnAttributes = true,
                    ConformanceLevel = ConformanceLevel.Document,
                    Encoding = Encoding.UTF8
                };

                XmlWriter xtw = XmlWriter.Create(pathString, settings);
                if (isProfilFile)
                {
                    xtw.WriteStartElement("Profils");
                }
                else
                {
                    xtw.WriteStartElement("Database");
                }
                xtw.WriteEndElement();
                xtw.Close();
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return fileName;
        }

        public static bool CreateNodeProfil(string filePath, Profil p)
        {
            var xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(filePath);
            }
            catch (FileNotFoundException e)
            {
                return false;
            }
            //Initialisation d'un espace de nom vide
            XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces(
                new[]
                {
                    XmlQualifiedName.Empty
                });
            //Récupération du noeud racine dans le fichier des profils
            XmlNode rootNode = xmlDoc.GetElementsByTagName("Profils")[0];
            
            /*using XmlWriter writer = nav.AppendChild();
            var ser = new XmlSerializer(typeof(Profil));
            writer.WriteWhitespace(String.Empty);
            ser.Serialize(writer, p, xmlSerializerNamespaces);
            Console.WriteLine(xmlDoc.OuterXml);
            writer.Close();*/
            
            //Chaine de charactère de sortie du XML créé à partir d'un objet profil
            StringBuilder output = new StringBuilder();

            //Initialisation d'un XmlWriter qui omet la déclaration
            XmlWriter writer = XmlWriter.Create(output,
                new XmlWriterSettings { OmitXmlDeclaration = true });
            //Initialisation du sérialiseur avec le type Profil
            var ser = new XmlSerializer(typeof(Profil));
            //Sérialisation sans déclaration ni espace de nom
            ser.Serialize(writer, p, xmlSerializerNamespaces);
            //Création d'un fragment XML
            XmlDocumentFragment fragmentProfil = xmlDoc.CreateDocumentFragment();
            //Ajout du XML généré à l'aide du sérialiseur dans le fragment
            fragmentProfil.InnerXml = output.ToString();

            //Ajout du fragment dans le document
            rootNode.AppendChild(fragmentProfil);
            //Fermeture du writer
            writer.Close();
            //Sauvegarde des modifications dans le fichier
            xmlDoc.Save(filePath);
            return true;
        }
    }

    public static class UtilsGestionnaire
    {
        public static bool AddEntry(string filePath, Entry e)
        {
            if (File.Exists(filePath))
            {
               
            }

            return false;
        }

        public static bool DeleteEntry(string filePath, Entry e)
        {
            if (File.Exists(filePath))
            {
                string[] readText = File.ReadAllLines(filePath);  
                File.WriteAllText(filePath, String.Empty);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string s in readText)
                    {
                        if (!s.Equals(e))
                        {
                            writer.WriteLine(s);
                        }
                    }
                }  
            }

            return false;
        }
        
    }

    public static class UtilsDataBase
    {
        
    }
}