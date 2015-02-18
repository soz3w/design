using System;
using System.Collections.Generic;

public class DessinUnVehiculeLigne : DessinCatalogue
{

  public void dessine(IList<VueVehicule> contenu)
  {
    Console.WriteLine(
      "Dessine les v�hicules avec un v�hicule par ligne");
    foreach (VueVehicule vueVehicule in contenu)
    {
      vueVehicule.dessine();
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
