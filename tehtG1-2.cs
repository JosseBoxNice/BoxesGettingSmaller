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
        int i = 1;  // Kertoo monesko neliö
        Camera.ZoomToLevel(1200);
        double nelioXY = 0;
        double nelioidenMaara = 10;
        double LaatikonKoko = 180;

        while (i <= nelioidenMaara)
        {
            double UusiLaatikonKoko = (nelioidenMaara + 1 - i) / nelioidenMaara * LaatikonKoko;
            PiirraNelio(this, UusiLaatikonKoko, nelioXY);
            nelioXY += UusiLaatikonKoko / 2 + (UusiLaatikonKoko - 18) / 2;
            i++;
        }
    }

    /// <summary>
    /// Aliohjelma piirtää ruutuun yhden neliön, jonka
    /// sivun pituus on LaatikonKoko, ja keskipiste on (nelioXY, nelioXY).
    /// </summary>
    /// <param name="peli">Peli, johon neliö piirretään</param>
    /// <param name="UusiLaatikonKoko">Laatikon sivun pituus</param>
    /// <param name="nelioXY">laatikon x ja y coordinaatit</param>
    public static void PiirraNelio(PhysicsGame peli, double UusiLaatikonKoko, double nelioXY)
    {
        GameObject nelio = new GameObject(UusiLaatikonKoko, UusiLaatikonKoko);
        nelio.Shape = Shape.Rectangle;
        nelio.X = nelioXY;
        nelio.Y = nelioXY;
        peli.Add(nelio);
    }
    // BYCODEEND
}