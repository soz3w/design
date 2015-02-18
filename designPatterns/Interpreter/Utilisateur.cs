using System;

public class Utilisateur
{
  static void Main(string[] args)
  {
    Expression expressionRequete = null;
    Console.Write("Entrez votre requ�te : ");
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
        "Entrez le texte de description d'un v�hicule : ");
      string description = Console.ReadLine();
      if (expressionRequete.evalue(description))
        Console.WriteLine(
          "La description r�pond � la requ�te");
      else
        Console.WriteLine(
          "La description ne r�pond pas � la requ�te");
    }
  }
}
