using System;

public class Vehicule : Sujet
{
  protected string _description;
  protected double _prix;

  public string description
  {
    get
    {
      return _description;
    }
    set
    {
      _description = value;
      this.notifie();
    }
  }

  public double prix
  {
    get
    {
      return _prix;
    }
    set
    {
      _prix = value;
      this.notifie();
    }
  }

}
