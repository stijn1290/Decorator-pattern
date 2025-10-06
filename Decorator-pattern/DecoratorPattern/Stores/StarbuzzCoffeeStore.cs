using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Stores
{
    class StarbuzzCoffeeStore : CoffeeStore
    {
        public override List<string> MenuItems { get; } = new List<string>
        {
            "Espresso",
            "Doppio",
            "Lungo",
            "Macchiato",
            "Corretta",
            "ConPanna",
            "Cappucinno",
            "Americano",
            "CaffeLatte",
            "FlatWhite",
            "Romana",
            "Morocchino",
            "Mocha",
            "Bicerin",
            "Breve",
            "RafCoffee",
            "Meadraf",
            "Galao",
            "CaffeAffogato",
            "ViennaCoffee",
            "Glace",
            "ChocolateMilk",
            "DemiCreme",
            "LatteMacchiato",
            "Freddo",
            "Frappuccino",
            "CaramelFrappuccino",
            "Frappe",
            "IrishCoffee"
        };

        public override Beverage CreateCoffee(string type)
        {
            switch (type.ToLower())
            {
                case "espresso":
                    Beverage espresso = new Espresso();
                    espresso.Size = Size.TALL;
                    return espresso;
                case "doppio":
                    Beverage doppio = new Espresso();
                    doppio.Size = Size.GRANDE;
                    doppio = new Espresso(doppio);
                    return doppio;
                case "lungo":
                    Beverage lungo = new Espresso();
                    lungo.Size = Size.VENDI;
                    lungo = new Water(lungo);
                    return lungo;
                case "macchiato":
                    Beverage macchiato = new Espresso();
                    macchiato.Size = Size.VENDI;
                    macchiato = new MilkFoam(macchiato);
                    return macchiato;
                case "corretta":
                    Beverage corretta = new Espresso();
                    corretta.Size = Size.TALL;
                    corretta = new Liquor(corretta);
                    return corretta;
                case "conpanna":
                    Beverage conPanna = new Espresso();
                    conPanna.Size = Size.GRANDE;
                    conPanna = new Whip(conPanna);
                    return conPanna;
                case "cappucinno":
                    Beverage cappucinno = new Espresso();
                    cappucinno.Size = Size.VENDI;
                    cappucinno = new SteamedMilk(cappucinno);
                    cappucinno = new MilkFoam(cappucinno);
                    return cappucinno;
                case "americano":
                    Beverage americano = new Espresso();
                    americano.Size = Size.GRANDE;
                    americano = new Water(americano);
                    americano = new Water(americano);
                    return americano;
                case "caffelatte":
                    Beverage cafeLatte = new Espresso();
                    cafeLatte.Size = Size.TALL;
                    cafeLatte = new SteamedMilk(cafeLatte);
                    cafeLatte = new SteamedMilk(cafeLatte);
                    cafeLatte = new MilkFoam(cafeLatte);
                    return cafeLatte;
                case "flatwhite":
                    Beverage flatWhite = new Espresso();
                    flatWhite.Size = Size.TALL;
                    flatWhite = new SteamedMilk(flatWhite);
                    flatWhite = new SteamedMilk(flatWhite);
                    return flatWhite;
                case "romana":
                    Beverage romana = new Espresso();
                    romana.Size = Size.GRANDE;
                    romana = new Lemon(romana);
                    return romana;
                case "morocchino":
                    Beverage morocchino = new Espresso();
                    morocchino.Size = Size.GRANDE;
                    morocchino = new Chocolate(morocchino);
                    morocchino = new MilkFoam(morocchino);
                    return morocchino;
                case "mocha":
                    Beverage mocha = new Espresso();
                    mocha.Size = Size.VENDI;
                    mocha = new Chocolate(mocha);
                    mocha = new SteamedMilk(mocha);
                    mocha = new Whip(mocha);
                    return mocha;
                case "bicerin":
                    Beverage bicerin = new Espresso();
                    bicerin.Size = Size.VENDI;
                    bicerin = new BlackChocolate(bicerin);
                    bicerin = new WhiteChocolate(bicerin);
                    bicerin = new Whip(bicerin);
                    return bicerin;
                case "breve":
                    Beverage breve = new Espresso();
                    breve.Size = Size.GRANDE;
                    breve = new MilkFoam(breve);
                    breve = new HalfMilk(breve);
                    return breve;
                case "rafcoffee":
                    Beverage rafCoffee = new Espresso();
                    rafCoffee.Size = Size.VENDI;
                    rafCoffee = new VanillaSugar(rafCoffee);
                    rafCoffee = new Cream(rafCoffee);
                    return rafCoffee;
                case "meadraf":
                    Beverage meadRaf = new Espresso();
                    meadRaf.Size = Size.VENDI;
                    meadRaf = new Honey(meadRaf);
                    meadRaf = new Cream(meadRaf);
                    return meadRaf;
                case "galao":
                    Beverage galao = new Espresso();
                    galao.Size = Size.GRANDE;
                    galao = new MilkFoam(galao);
                    galao = new MilkFoam(galao);
                    return galao;
                case "caffeaffogato":
                    Beverage caffeAffogato = new Espresso();
                    caffeAffogato.Size = Size.GRANDE;
                    caffeAffogato = new Espresso(caffeAffogato);
                    caffeAffogato = new IceCream(caffeAffogato);
                    return caffeAffogato;
                case "viennacoffee":
                    Beverage viennaCoffee = new Espresso();
                    viennaCoffee.Size = Size.GRANDE;
                    viennaCoffee = new Espresso(viennaCoffee);
                    viennaCoffee = new Whip(viennaCoffee);
                    viennaCoffee = new Whip(viennaCoffee);
                    return viennaCoffee;
                case "glace":
                    Beverage glace = new Espresso();
                    glace.Size = Size.GRANDE;
                    glace = new IceCream(glace);
                    return glace;
                case "chocolatemilk":
                    Beverage chocolateMilk = new Chocolate();
                    chocolateMilk.Size = Size.VENDI;
                    chocolateMilk = new Milk(chocolateMilk);
                    chocolateMilk = new Milk(chocolateMilk);
                    return chocolateMilk;
                case "demicreme":
                    Beverage demiCreme = new Espresso();
                    demiCreme.Size = Size.GRANDE;
                    demiCreme = new Espresso(demiCreme);
                    demiCreme = new Cream(demiCreme);
                    demiCreme = new Cream(demiCreme);
                    return demiCreme;
                case "lattemacchiato":
                    Beverage latteMacchiato = new Espresso();
                    latteMacchiato.Size = Size.TALL;
                    latteMacchiato = new SteamedMilk(latteMacchiato);
                    latteMacchiato = new SteamedMilk(latteMacchiato);
                    latteMacchiato = new MilkFoam(latteMacchiato);
                    return latteMacchiato;
                case "freddo":
                    Beverage freddo = new Espresso();
                    freddo.Size = Size.TALL;
                    freddo = new Liquor(freddo);
                    freddo = new Ice(freddo);
                    return freddo;
                case "frappuccino":
                    Beverage frappuccino = new Espresso();
                    frappuccino.Size = Size.VENDI;
                    frappuccino = new Ice(frappuccino);
                    frappuccino = new SteamedMilk(frappuccino);
                    frappuccino = new Whip(frappuccino);
                    return frappuccino;
                case "caramelfrappuccino":
                    Beverage caramelFrappuccino = new Espresso();
                    caramelFrappuccino.Size = Size.VENDI;
                    caramelFrappuccino = new Ice(caramelFrappuccino);
                    caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
                    caramelFrappuccino = new Whip(caramelFrappuccino);
                    caramelFrappuccino = new Syrup(caramelFrappuccino);
                    return caramelFrappuccino;
                case "frappe":
                    Beverage frappe = new Espresso();
                    frappe.Size = Size.TALL;
                    frappe = new SteamedMilk(frappe);
                    frappe = new SteamedMilk(frappe);
                    frappe = new IceCream(frappe);
                    return frappe;
                case "irishcoffee":
                    Beverage irishCoffee = new Espresso();
                    irishCoffee.Size = Size.GRANDE;
                    irishCoffee = new Espresso(irishCoffee);
                    irishCoffee = new Whiskey(irishCoffee);
                    irishCoffee = new Whip(irishCoffee);
                    return irishCoffee;
                default:
                    throw new ArgumentException($"Coffee type '{type}' is not on the menu.");
            }
        }
    }
}
