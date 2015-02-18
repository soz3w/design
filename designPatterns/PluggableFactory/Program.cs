using System;

class Program
{
 static void Main(string[] args)
 {
  Automobile protoAutomobileStandardBleu = new
   AutomobileElectricite();
  protoAutomobileStandardBleu.modele = "standard";
  protoAutomobileStandardBleu.couleur = "bleu";

  Scooter protoScooterClassicRouge = new ScooterEssence();
  protoScooterClassicRouge.modele = "classic";
  protoScooterClassicRouge.couleur = "rouge";

  FabriqueVehicule fabrique = new FabriqueVehicule();
  fabrique.prototypeAutomobile =
   protoAutomobileStandardBleu;
  fabrique.prototypeScooter = protoScooterClassicRouge;

  Automobile auto = fabrique.creeAutomobile();
  auto.afficheCaracteristiques();
  Scooter scooter = fabrique.creeScooter();
  scooter.afficheCaracteristiques();
 }
}

