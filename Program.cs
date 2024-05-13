//ICI ON REALISE DIFFERNETNES METHODES POUR CONVERTIR DANS UN SENS OU DANS L'AUTRE LA CLASS MEMBER DU PORGRAM MEMBER

using System; //appel initialisation de la bilbiothèque System
using System.Collections.Generic;//....
using System.Linq;//....
using System.Xml.Serialization;//.....

namespace XmlDemo//Ce code (Program) travail dans le projet XmlDemo
{
    public class Program //Définit comme public donc n'importe quelle partie du code peut y faire appel peut importe les dépendances.
    {
        public static void Main(string[] args)//Boucle Principale du code ???
        {
            SerializeObjectToXmlString();//Initialisation de la méthode de sérialization

            Console.WriteLine("Process completed...");//Ecrit dans la commande "Process Completed"
            Console.ReadKey();//afficher la console sur l'écran pour pouvoir lire ce qu'il y a dedans.
        }

        private static void SerializeObjectToXmlString()//Initialisation de la boucle qui sérializee pour sérializer une liste en XML Méthode
        {
            var member = new Member //Initialisation de la liste member dans la liste Member
            {
                Name = "John",//Name de member dans Member = John
                Email = "john@gmail.com",//.....
                Age = 30,//.....
                JoiningDate = DateTime.Now,//.....
                IsPlatinumMember = false//.....
            };

            var xmlSerializer = new XmlSerializer(typeof(Member));//Initialisation d'un objet XmlSerializer pour la liste Member ????
            using (var writer = new StringWriter())//????
            {
                xmlSerializer.Serialize(writer, member);//Serialize l'objet member
                var xmlContent = writer.ToString();//Convertion de l'objet Serialze en chaine de caractere
                Console.WriteLine(xmlContent);//Ecrit dans la console la chaine de caractere
                DeserializeXmlStringToObject(xmlContent);//Importe la méthode inverse de Serialzation
            }
        }

        private static void DeserializeXmlStringToObject(string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));//Initialization de la variable XmlSeri... pour Member ????
            using (var reader = new StringReader(xmlString))//On utilise un lecteur de chaine de caractere pour déserialiser la chaine XML
            {
                var member = (Member)xmlSerializer.Deserialize(reader);//Deserialize l'objet Member dans la variable member
            }
        }

        private static void SerializeObjectToXmlFile() //Nouvelle méthode transformation d'une liste en objet XML
        {
            var member = new Member //Var member dans liste MEMBER
            {
                Name = "John", //données ....
                Email = "john@gmail.com",
                Age = 30,
                JoiningDate = DateTime.Now,
                IsPlatinumMember = false
            };

            var xmlSerializer = new XmlSerializer(typeof(Member)); //Serialize Objet en Xml
            using (var writer = new StreamWriter(@"C:\Users\cshoa\Desktop\XmlDemo\xml-files\sampl01.xml"))// Permet d'écrire dans un fichier XML avec le chemin d'acces suivant
            {
                xmlSerializer.Serialize(writer, member);//Serialize et et écrit dans member
            }
        }

        private static void SerializeListToXmlFile()//Nouvelle méthode
        {
            var memberList = new List<Member> //Nouvelle lsite d'objet Member
            {
                new Member //Rajoute plusieurs Member dasn la liste memberliste
                {
                    Name = "John",
                    Email = "john@gmail.com",
                    Age = 30,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = false
                },
                new Member // ....
                {
                    Name = "Peter",
                    Email = "peter@gmail.com",
                    Age = 35,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = true
                },
                new Member //....
                {
                    Name = "David",
                    Email = "david@gmail.com",
                    Age = 25,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = true
                },
                new Member
                {
                    Name = "George",
                    Email = "george@gmail.com",
                    Age = 29,
                    JoiningDate = DateTime.Now,
                    IsPlatinumMember = false
                }
            };

            var xmlSerializer = new XmlSerializer(typeof(List<Member>)); //Initialise le Serializer
            using (var writer = new StreamWriter(@"C:\Users\cshoa\Desktop\XmlDemo\xml-files\sample02.xml"))//Permet d'écrire dans un ficheier XML
            {
                xmlSerializer.Serialize(writer, memberList);//Serialize et écrit dans le fichier memberlist
            }
        }

        private static void DeserializeXmlFileToList() //NOuvelle méthode pour transformer un fichier XML en liste
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Member>)); //Initialisation nouvelle Lsite Member
            using (var reader = new StreamReader(@"C:\Users\cshoa\Desktop\XmlDemo\xml-files\sample02.xml"))//Ouvre et permet d'écrire dans un fichier XML avec le chemin d'access correspondant
            {
                var members = (List<Member>)xmlSerializer.Deserialize(reader); //Dessarialze le fichier XML en liste

            }
        }

        private static void DeserializeXmlFileToObject()//Nouvelle méthode pour desarialize en objet ??? différence avec liste ????
        {
            var xmlSerializer = new XmlSerializer(typeof(Member));//Création nouvel objet Member
            using (var reader = new StreamReader(@"C:\Users\cshoa\Desktop\XmlDemo\xml-files\sampl01.xml"))//Ouvre et lit un fichier xml avec le chemin d'acces suivant
            {
                var member = (Member)xmlSerializer.Deserialize(reader);//Permet de lire et d'écrire dans l'objet à partir du fichier XML

            }
        }
    }
}