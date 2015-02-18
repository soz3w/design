using System;

public class VueVehicule
{
  protected string description;

  public VueVehicule(string description)
  {
    this.description = description;
  }

  public void dessine()
  {
    Console.Write(description);
  }
}
