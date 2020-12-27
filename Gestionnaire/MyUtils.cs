using System;
using System.IO;
using System.Windows.Forms;
using Gestionnaire.model;

namespace Gestionnaire
{
    public static class MyUtils
    {
        public const char SEPARATOR = ';';
        public const string EXTENSION = ".txt";
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
                
                FileStream fs = File.Create(pathString);
                if (isProfilFile)
                {
                    fs.Close();
                }
                //TODO Ajout des groupes par défauts
                /*else
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine();
                    }
                }*/
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return fileName;
        }
        
    }

    public static class UtilsGestionnaire
    {
        public static bool AddEntry(string filePath, Entry e)
        {
            if (File.Exists(filePath))
            {
                using StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine(e.ToDataBase());
                return true;
            }

            return false;
        }

        public static bool DeleteEntry(string filePath, Entry e)
        {
            if (File.Exists(filePath))
            {
                
            }

            return false;
        }
        
    }

    public static class UtilsDataBase
    {
        public static bool IsTableExist(string filePath, string tableName)
        {
            if (File.Exists(filePath))
            {
                using StreamReader sr = new StreamReader(filePath);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine()!;
                    if (String.Equals(line, "table : " + tableName))
                        return true;
                }
            }

            return false;
        }

        public static bool CreateTable(string filePath, string tableName)
        {
            if (File.Exists(filePath))
            {
                using StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine("table : " + tableName);
            }

            return false;
        }
    }
}