using System;

public abstract class Employe : RecepteurGeneral
{
 protected string nom;

 public Employe(string nom)
 {
  this.nom = nom;
 }

 public void recoit(MessageGeneral message)
 {
  Console.WriteLine("Message général");
  Console.WriteLine("Nom : " + nom);
  Console.WriteLine("Message : ");
  foreach (string ligne in message.contenu)
   Console.WriteLine(ligne);
 }
}

