using System.Runtime.CompilerServices;
using Jypeli;
using Jypeli.Controls;

namespace tehtG1_2;

public class tehtG1_2 : PhysicsGame
{
    // BYCODEBEGIN
    /// <summary>
    /// Ohjelma piirtää n määrän neliöitä alkaen vasemmasta alakulmasta,
    /// siten että neliöt pienenevät samalla kun ne lähestyvät vastakkaista
    /// kulmaa.
    /// </summary>
    public override void Begin()
    {
        int i = 0;
        int nelioidenMaara = 10;
        int laatikonKoko = 180;
        Camera.ZoomToLevel(50);
        while (i <= nelioidenMaara)
        {
            PiirraNelio(this, laatikonKoko, nelioidenMaara, i);
            i++;
        }
    }

    /// <summary>
    /// Aliohjelma piirtää ruutuun yhden neliön, jonka
    /// sivun pituus on 80, ja keskipiste on (x, y).
    /// </summary>
    /// <param name="peli">Peli, johon neliö piirretään</param>
    /// <param name="x">Neliön keskipisteen x-koordinaatti.</param>
    /// <param name="y">Neliön keskipisteen y-koordinaatti.</param>
    public static void PiirraNelio(PhysicsGame peli, double laatikonKoko, double nelioidenMaara, double i)
    {
        double uusiLaatikonKoko = (nelioidenMaara + 1 - i) / nelioidenMaara * laatikonKoko;
        GameObject nelio = new GameObject(uusiLaatikonKoko, uusiLaatikonKoko);
        nelio.Shape = Shape.Rectangle;
        double nelionX = nelio.X + 1.5 * uusiLaatikonKoko;
        double nelionY = nelio.Y + 1.5 * uusiLaatikonKoko;
        peli.Add(nelio);
    }
    // BYCODEEND
}