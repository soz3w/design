using System;

public class Client
{
  static void Main(string[] args)
  {
    FabriqueOption fabrique = new FabriqueOption();
    VehiculeCommande vehicule = new VehiculeCommande();
    vehicule.ajouteOptions("air bag", 80, fabrique);
    vehicule.ajouteOptions("direction assistée", 90,
      fabrique);
    vehicule.ajouteOptions("vitres électriques", 85,
      fabrique);
    vehicule.afficheOptions();
  }
}
