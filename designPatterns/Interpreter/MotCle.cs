using System;

public class MotCle : Expression
{
  protected string motCle;

  public MotCle(string motCle)
  {
    this.motCle = motCle;
  }

  public override bool evalue(string description)
  {
    return description.IndexOf(motCle) !=  -1;
  }

  // partie analyse syntaxique
  public static new Expression parse()
  {
    Expression resultat;
    resultat = new MotCle(jeton);
    prochainJeton();
    return resultat;
  }
}
