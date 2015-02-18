using System;
using System.Collections.Generic;

public class SocieteMere : Societe
{
  protected IList<Societe> filiales = 
      new List<Societe>();

  public SocieteMere(string nom, string email, string
    adresse) : base(nom, email, adresse){}

  public override void accepteVisiteur(Visiteur visiteur)
  {
    visiteur.visite(this);
    foreach (Societe filiale in filiales)
      filiale.accepteVisiteur(visiteur);
  }

  public override bool ajouteFiliale(Societe filiale)
  {
    filiales.Add(filiale);
    return true;
  }
}
