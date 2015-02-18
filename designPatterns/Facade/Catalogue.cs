using System;
using System.Collections.Generic;

public interface Catalogue
{
  IList<string> retrouveVehicules(int prixMin, int
    prixMax);
}
