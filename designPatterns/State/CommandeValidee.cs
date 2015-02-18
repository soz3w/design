public class CommandeValidee : EtatCommande
{
  public CommandeValidee(Commande commande) : base
    (commande){}

  public override void ajouteProduit(Produit produit){}

  public override void efface()
  {
    commande.Produits.Clear();
  }

  public override void retireProduit(Produit produit){}

  public override EtatCommande etatSuivant()
  {
    return new CommandeLivree(commande);
  }
}
