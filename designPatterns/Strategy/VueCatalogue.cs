using System.Collections.Generic;

public class VueCatalogue
{
  protected IList<VueVehicule> contenu = 
      new List<VueVehicule>();
  protected DessinCatalogue dessin;

  public VueCatalogue(DessinCatalogue dessin)
  {
    contenu.Add(new VueVehicule("v�hicule bon march�"));
    contenu.Add(new VueVehicule("v�hicule spacieux"));
    contenu.Add(new VueVehicule("v�hicule rapide"));
    contenu.Add(new VueVehicule("v�hicule confortable"));
    contenu.Add(new VueVehicule("v�hicule sportif"));
    this.dessin = dessin;
  }

  public void dessine()
  {
    dessin.dessine(contenu);
  }
}
