using System;

public class Client
{
  static void Main(string[] args)
  {
    FabriqueOption fabrique = new FabriqueOption();
    VehiculeCommande vehicule = new VehiculeCommande();
    vehicule.ajouteOptions("air bag", 80, fabrique);
    vehicule.ajouteOptions("direction assist�e", 90,
      fabrique);
    vehicule.ajouteOptions("vitres �lectriques", 85,
      fabrique);
    vehicule.afficheOptions();
  }
}
