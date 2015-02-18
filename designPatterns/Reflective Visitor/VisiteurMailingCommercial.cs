using System;

public class VisiteurMailingCommercial : Visiteur, VisiteurSociete
{
 public void visite(SocieteSansFiliale societe)
 {
  Console.WriteLine("Envoi d'un email � " +
   societe.nom + " adresse : " + societe.email
   + " Proposition commerciale pour votre soci�t�");
 }

 public void visite(SocieteMere societe)
 {
  Console.WriteLine("Envoi d'un email � " +
   societe.nom + " adresse : " + societe.email
   + " Proposition commerciale pour votre groupe");
  Console.WriteLine("Impression d'un courrier � " +
   societe.nom + " adresse : " +
   societe.adresse + 
   " Proposition commerciale pour votre groupe");
  foreach (Societe filiale in societe.filiales)
   this.demarreVisite(filiale);
 }
}
