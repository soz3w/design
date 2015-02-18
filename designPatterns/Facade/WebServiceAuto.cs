using System;
using System.Collections.Generic;

public interface WebServiceAuto
{
  string document(int index);
  IList<string> chercheVehicules(int prixMoyen, int
    ecartMax);
}
