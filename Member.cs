//ICI ON CREER UNE CLASS MEMBER POUR POUVOIR TRAVAILLER AVEC DANS PROGRAM

using System; //Importe et permet d'utiliser le systeme (structure .NET)
using System.Xml.Serialization;//Importe et permet d'utiliser le systeme.XML.Serialization (structure .NET)

namespace XmlDemo //Ouverture de l'espace du projet XmlDemo
{
    [Serializable] //Permet de dire que la class Member (Public) peut être Serializer
    public class Member //Déclaration de la class Member en publique
    {
        public string Name { get; set; } //Etablissement des différentes données get pour aquerir set pour écrire.
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime JoiningDate { get; set; } //On utilise le module DateTime incorporé a Visual Studio
        public bool IsPlatinumMember { get; set; }
    }
}
