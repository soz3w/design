using System;
using System.Collections.Generic;

public class MessageGeneral : MessageAbstrait
{
 public IList<string> contenu { get; protected set; }

 public MessageGeneral(IList<string> contenu)
 {
  this.contenu = contenu;
 }
}

