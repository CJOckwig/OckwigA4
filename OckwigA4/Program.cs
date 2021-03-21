using System;

using HeroNS;
class Program
{
    static void Main(string[] args)
    {
        Hero Test = new Hero("Kobra Kid", Global.RaceType.DRAGON, 500, 69, Global.WeaponType.SPELL);
        Hero Test2 = new Hero();
        Hero KobraKid = new Hero(Test);
        KobraKid.Name = "Kobra";
        KobraKid.Weapon = Global.WeaponType.SWORD;

        Hero Party = new Hero(KobraKid);
        View.ViewV(Test2);

    }
}
