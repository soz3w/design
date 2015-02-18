using System;

public class ScooterEssence : Scooter
{

 public override void afficheCaracteristiques()
 {
  Console.WriteLine("Scooter à essence de modèle : " +
   modele + " de couleur : " + couleur +
   " de puissance : " + puissance);
 }
}


