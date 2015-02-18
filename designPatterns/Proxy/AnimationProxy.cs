using System;

public class AnimationProxy : Animation
{
  protected Film film = null;
  protected string photo = "affichage de la photo";

  public void clic()
  {
    if (film == null)
    {
      film = new Film();
      film.charge();
    }
    film.joue();
  }

  public void dessine()
  {
    if (film != null)
      film.dessine();
    else
      dessine(photo);
  }

  public void dessine(string photo)
  {
    Console.WriteLine(photo);
  }
}
