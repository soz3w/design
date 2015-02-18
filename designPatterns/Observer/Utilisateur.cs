using System;

public class Utilisateur
{
  static void Main(string[] args)
  {
    Vehicule vehicule = new Vehicule();
    vehicule.description = "Vehicule bon marché";
    vehicule.prix = 5000.0;
    VueVehicule vueVehicule = new VueVehicule(vehicule);
    vueVehicule.redessine();
    vehicule.prix = 4500.0;
    VueVehicule vueVehicule2 = new VueVehicule(vehicule);
    vehicule.prix = 5500.0;
  }
}
