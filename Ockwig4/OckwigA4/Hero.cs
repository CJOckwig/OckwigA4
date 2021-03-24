using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/******************************************************************** 
 * ***  NAME  :        ***
 * ***  CLASS  :  CSc XXX       *** 
 * ***  ASSIGNMENT :        *** 
 * ***  DUE DATE :        *** 
 * ***  INSTRUCTOR :  GAMRADT       *** 
 * ********************************************************************* ***  DESCRIPTION : <detailed english description of the current assignment> *** ********************************************************************/


namespace CharacterNS
{
    public class Hero : Character
    {
        /*********************************************************************** 
        * ***  METHOD  Getters and setters                                                *** 
        * ********************************************************************* 
        * ***  DESCRIPTION :  provides getters and setters for each of the  ***
        * ***                 Hero classes variables. Each return their type***
        * ***                 or is a void statement respectively           *** 
        * ***  INPUT ARGS :  none                                           *** 
        * ***  OUTPUT ARGS :  none                                          ***
        * ***  IN/OUT ARGS :  none                                          ***
        * ***  RETURN :  void                                               *** 
        * ********************************************************************/

        public Global.WeaponType Weapon { get; set; }
        public short Protection { get; set; }
        /*********************************************************************** 
         * ***  METHOD  Hero                                                *** 
         * ********************************************************************* 
         * ***  DESCRIPTION :  Creates a Hero with default settings          *** 
         * ***  INPUT ARGS :  Hero object                                    *** 
         * ***  OUTPUT ARGS :  none                                          ***
         * ***  IN/OUT ARGS :  none                                          ***
         * ***  RETURN :  void                                               *** 
         * ********************************************************************/
        public Hero():base()
        {

        }
        public Hero(string n = "Geralt", Global.RaceType r=Global.RaceType.DWARF, short h=200, short p = 50, Global.WeaponType w = Global.WeaponType.AXE) : base (n, r, h)
        {
            Name = n;
            Race = r;
            Health = h;
            Weapon = w;
            Protection = p;

        }
        /*********************************************************************** 
         * ***  METHOD  Hero()                                                *** 
         * ********************************************************************* 
         * ***  DESCRIPTION :  Creates hero with the given parameters to math a hero   *** 
         * ***  INPUT ARGS :  string name, RaceType, Health, Protection, and weapon type     *** 
         * ***  OUTPUT ARGS :  none                                          ***
         * ***  IN/OUT ARGS :  none                                          ***
         * ***  RETURN :  void                                               *** 
         * ********************************************************************/

        /*********************************************************************** 
         * ***  METHOD  Hero                                                *** 
         * ********************************************************************* 
         * ***  DESCRIPTION :  Creates a copy of the Hero                    *** 
         * ***  INPUT ARGS :  Hero object                                    *** 
         * ***  OUTPUT ARGS :  none                                          ***
         * ***  IN/OUT ARGS :  Hero                                          ***
         * ***  RETURN :  void                                               *** 
         * ********************************************************************/
        public Hero(Hero h)
        {
            Name = h.Name;
            Race = h.Race;
            Health = h.Health;
            Protection = h.Protection;
            Weapon = h.Weapon;
        }





    }


}
