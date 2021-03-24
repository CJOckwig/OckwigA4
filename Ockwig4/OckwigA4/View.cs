using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterNS
{
    public static class View
    {
        /*********************************************************************** 
         * ***  METHOD  ViewH                                                *** 
         * ********************************************************************* 
         * ***  DESCRIPTION :  Shows a horizontal list of the hero's stats   *** 
         * ***  INPUT ARGS :  Hero object                                    *** 
         * ***  OUTPUT ARGS :  none                                          ***
         * ***  IN/OUT ARGS :  none                                          ***
         * ***  RETURN :  void                                               *** 
         * ********************************************************************/
        public static void ViewH(Hero h)
        {

            Console.WriteLine("Name            Race\tHealth\tProtection\tWeapon");
            Console.WriteLine(h.Name + "\t       " + h.Race + "\t" + h.Health + "\t" + h.Protection +
                "\t        " + h.Weapon);
        }
        /*********************************************************************** 
         * ***  METHOD  ViewV                                                *** 
         * ********************************************************************* 
         * ***  DESCRIPTION :  Shows a vertical list of the hero's stats   *** 
         * ***  INPUT ARGS :  Hero object                                    *** 
         * ***  OUTPUT ARGS :  none                                          ***
         * ***  IN/OUT ARGS :  none                                          ***
         * ***  RETURN :  void                                               *** 
         * ********************************************************************/
        public static void ViewV(Hero h)
        {
            Console.WriteLine("Name:       " + h.Name);
            Console.WriteLine("Race:       " + h.Race);
            Console.WriteLine("Health:     " + h.Health);
            Console.WriteLine("Protection: " + h.Protection);
            Console.WriteLine("Weapon:     " + h.Weapon);

        }
    }
}
