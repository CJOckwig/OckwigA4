using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterNS
{
    abstract public class Character
    {
        /*********************************************************************** 
         * ***  METHOD  Hero                                                *** 
         * ********************************************************************* 
         * ***  DESCRIPTION :  Overloaded constructor. Creates new Hero object   *** 
         * ***  INPUT ARGS :  Hero object                                    *** 
         * ***  OUTPUT ARGS :  none                                          ***
         * ***  IN/OUT ARGS :  none                                          ***
         * ***  RETURN :  void                                               *** 
         * ********************************************************************/
        public Character(string n = "Geralt", Global.RaceType r = Global.RaceType.WITCHER, short h = 200)
        {
            Name = n;
            Race = r;
            Health = h;
        }
        public Character(Character c)
        {
            Name = c.Name;
            Race = c.Race;
            Health = c.Health;
        }
        /*********************************************************************** 
         * ***  METHOD  getters and Setters                                                *** 
         * ********************************************************************* 
         * ***  DESCRIPTION :  gets and sets different properties of the Character class   *** 
         * ***  INPUT ARGS :  Name/Race/Health                                             *** 
         * ***  OUTPUT ARGS :  none                                                        ***
         * ***  IN/OUT ARGS :  none                                                        ***
         * ***  RETURN :  Name/Race/Health                                                 *** 
         * ********************************************************************/
        public string Name { get; set; }
        public Global.RaceType Race { get; set; }
        public short Health { get; set; }

    }
}
