using System;

public class Utilisateur
{
  static void Main(string[] args)
  {
    Expression expressionRequete = null;
    Console.Write("Entrez votre requête : ");
    string requete = Console.ReadLine();
    try
    {
      expressionRequete = Expression.analyse(requete);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
      expressionRequete = null;
    }
    if (expressionRequete != null)
    {
      Console.WriteLine(
        "Entrez le texte de description d'un véhicule : ");
      string description = Console.ReadLine();
      if (expressionRequete.evalue(description))
        Console.WriteLine(
          "La description répond à la requête");
      else
        Console.WriteLine(
          "La description ne répond pas à la requête");
    }
  }
}
