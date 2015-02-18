using System;

public abstract class Scooter
{
 public string modele { get; set; }
 public string couleur { get; set; }
 protected int puissance { get; set; }

 public Scooter duplique()
 {
  Scooter resultat;
  resultat = (Scooter)this.MemberwiseClone();
  return resultat;
 }

 public abstract void afficheCaracteristiques();
}

