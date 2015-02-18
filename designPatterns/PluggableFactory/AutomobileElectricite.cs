using System;

public class AutomobileElectricite : Automobile
{

 public override void afficheCaracteristiques()
 {
  Console.WriteLine(
   "Automobile électrique de modèle : " + modele +
   " de couleur : " + couleur + " de puissance : " +
   puissance + " d'espace : " + espace);
 }
}


