using System;

using CharacterNS;
class Program
{
    static void Main(string[] args)
    {
        Hero Test2 = new Hero("Kobra Kid", Global.RaceType.DWARF, 500, 69, Global.WeaponType.SPELL);
        Hero Test = new Hero();
        Hero KobraKid = new Hero(Test);
        KobraKid.Name = "Kobra";
        KobraKid.Weapon = Global.WeaponType.SWORD;

        Hero Party = new Hero(KobraKid);
        View.ViewV(Test);

    }
}
