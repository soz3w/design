using System;
using System.Collections.Generic;

public class WebServiceAutoImpl : WebServiceAuto
{
  protected Catalogue catalogue = new ComposantCatalogue();
  protected GestionDocument gestionDocument = new
    ComposantGestionDocument();

  public string document(int index)
  {
    return gestionDocument.document(index);
  }

  public IList<string> chercheVehicules(int prixMoyen,
    int ecartMax)
  {
    return catalogue.retrouveVehicules(prixMoyen -
      ecartMax, prixMoyen + ecartMax);
  }
}
