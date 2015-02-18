public class Utilisateur
{
  static void Main(string[] args)
  {
    VueCatalogue vueCatalogue1 = new VueCatalogue(new
      DessinTroisVehiculesLigne());
    vueCatalogue1.dessine();
    VueCatalogue vueCatalogue2 = new VueCatalogue(new
      DessinUnVehiculeLigne());
    vueCatalogue2.dessine();
  }
}
