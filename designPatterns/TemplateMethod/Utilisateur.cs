public class Utilisateur
{
  static void Main(string[] args)
  {
    Commande commandeFrance = new CommandeFrance();
    commandeFrance.setMontantHt(10000);
    commandeFrance.calculeMontantTtc();
    commandeFrance.affiche();


    Commande commandeLuxembourg = new CommandeLuxembourg();
    commandeLuxembourg.setMontantHt(10000);
    commandeLuxembourg.calculeMontantTtc();
    commandeLuxembourg.affiche();
  }
}
