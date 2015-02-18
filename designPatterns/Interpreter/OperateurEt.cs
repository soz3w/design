using System;

public class OperateurEt : OperateurBinaire
{
  public OperateurEt(Expression operandeGauche,
    Expression operandeDroite) : base(operandeGauche,
    operandeDroite){}

  public override bool evalue(string description)
  {
    return operandeGauche.evalue(description) &&
      operandeDroite.evalue(description);
  }

  // partie analyse syntaxique
  public static new Expression parse()
  {
    Expression resultatGauche, resultatDroit;
    resultatGauche = Expression.parse();
    while ((jeton != null) && (jeton == "et"))
    {
      prochainJeton();
      resultatDroit = Expression.parse();
      resultatGauche = new OperateurEt(resultatGauche,
        resultatDroit);
    }
    return resultatGauche;
  }
}
