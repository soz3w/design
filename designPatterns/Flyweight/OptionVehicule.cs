using System;

public class OptionVehicule
{
  protected string nom;
  protected string description;
  protected int prixStandard;

  public OptionVehicule(string nom)
  {
    this.nom = nom;
    this.description = "Description de " + nom;
    this.prixStandard = 100;
  }

  public void affiche(int prixDeVente)
  {
    Console.WriteLine("Option");
    Console.WriteLine("Nom : " + nom);
    Console.WriteLine(description);
    Console.WriteLine("Prix standard : " + prixStandard);
    Console.WriteLine("Prix de vente : " + prixDeVente);
  }
}
