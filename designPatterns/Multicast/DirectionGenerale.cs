using System;
using System.Collections.Generic;

public class DirectionGenerale
{
 protected ExpediteurGeneral expediteurGeneral = new
  ExpediteurGeneral();

 public void envoieMessages()
 {
  IList<string> contenu = new List<string>();
  contenu.Add("Informations générales");
  contenu.Add("Informations spécifiques");
  MessageGeneral message = new MessageGeneral(contenu);
  expediteurGeneral.envoieMultiple(message);
 }

 public void ajouteRecepteurGeneral(Employe recepteur)
 {
  expediteurGeneral.ajoute(recepteur);
 }
}

