using System;
using System.Collections.Generic;

public class DessinTroisVehiculesLigne : DessinCatalogue
{
  public void dessine(IList<VueVehicule> contenu)
  {
    int compteur;
    Console.WriteLine(
      "Dessine les véhicules avec trois véhicules par ligne");
    compteur = 0;
    foreach (VueVehicule vueVehicule in contenu)
    {
      vueVehicule.dessine();
      compteur++;
      if (compteur == 3)
      {
        Console.WriteLine();
        compteur = 0;
      }
      else
        Console.Write(" ");
    }
    if (compteur != 0)
      Console.WriteLine();
    Console.WriteLine();
  }
}
