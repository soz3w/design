using System;
using System.Collections.Generic;

public abstract class ExpediteurAbstrait
 <TMessage, TRecepteur>
  where TMessage : MessageAbstrait
  where TRecepteur : RecepteurAbstrait<TMessage>
{
 protected IList<TRecepteur> registre =
  new List<TRecepteur>();

 public void ajoute(TRecepteur recepteur)
 {
  registre.Add(recepteur);
 }

 public void envoieMultiple(TMessage message)
 {
  foreach (TRecepteur recepteur in registre)
   recepteur.recoit(message);
 }
}

