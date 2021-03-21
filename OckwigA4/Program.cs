using System;

using HeroNS;
class Program
{
    static void Main(string[] args)
    {
        Hero Test = new Hero("God", Global.RaceType.DRAGON, 1000, 92, Global.WeaponType.MACE);

        Hero KobraKid = new Hero(Test);
        KobraKid.Name = "Kobra";
        View.ViewV(Test);

    }
}
