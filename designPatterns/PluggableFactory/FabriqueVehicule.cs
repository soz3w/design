using System;

public class FabriqueVehicule
{
 public Automobile prototypeAutomobile { get; set; }
 public Scooter prototypeScooter { get; set; }

 public FabriqueVehicule()
 {
  prototypeAutomobile = null;
  prototypeScooter = null;
 }

 public FabriqueVehicule(Automobile prototypeAutomobile,
  Scooter prototypeScooter)
 {
  this.prototypeAutomobile = prototypeAutomobile;
  this.prototypeScooter = prototypeScooter;
 }

 public Automobile creeAutomobile()
 {
  if (prototypeAutomobile == null)
   return null;
  return prototypeAutomobile.duplique();
 }

 public Scooter creeScooter()
 {
  if (prototypeScooter == null)
   return null;
  return prototypeScooter.duplique();
 }
}

