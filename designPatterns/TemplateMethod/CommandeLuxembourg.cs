public class CommandeLuxembourg : Commande
{
  protected override void calculeTva()
  {
    montantTva = montantHt * 0.15;
  }
}
