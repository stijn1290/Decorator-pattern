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
                    doppio = new Espresso(doppio);
                    doppio.Size = Size.GRANDE;
                    return doppio;
                case "lungo":
                    Beverage lungo = new Espresso();
                    lungo = new Water(lungo);
                    lungo.Size = Size.VENDI;
                    return lungo;
                case "macchiato":
                    Beverage macchiato = new Espresso();
                    macchiato = new MilkFoam(macchiato);
                    macchiato.Size = Size.VENDI;
                    return macchiato;
                case "corretta":
                    Beverage corretta = new Espresso();
                    corretta = new Liquor(corretta);
                    corretta.Size = Size.TALL;
                    return corretta;
                case "conpanna":
                    Beverage conPanna = new Espresso();
                    conPanna = new Whip(conPanna);
                    conPanna.Size = Size.GRANDE;
                    return conPanna;
                case "cappucinno":
                    Beverage cappucinno = new Espresso();
                    cappucinno = new SteamedMilk(cappucinno);
                    cappucinno = new MilkFoam(cappucinno);
                    cappucinno.Size = Size.VENDI;
                    return cappucinno;
                case "americano":
                    Beverage americano = new Espresso();
                    americano = new Water(americano);
                    americano = new Water(americano);
                    americano.Size = Size.GRANDE;
                    return americano;
                case "caffelatte":
                    Beverage cafeLatte = new Espresso();
                    cafeLatte = new SteamedMilk(cafeLatte);
                    cafeLatte = new SteamedMilk(cafeLatte);
                    cafeLatte = new MilkFoam(cafeLatte);
                    cafeLatte.Size = Size.TALL;
                    return cafeLatte;
                case "flatwhite":
                    Beverage flatWhite = new Espresso();
                    flatWhite = new SteamedMilk(flatWhite);
                    flatWhite = new SteamedMilk(flatWhite);
                    flatWhite.Size = Size.TALL;
                    return flatWhite;
                case "romana":
                    Beverage romana = new Espresso();
                    romana = new Lemon(romana);
                    romana.Size = Size.GRANDE;
                    return romana;
                case "morocchino":
                    Beverage morocchino = new Espresso();
                    morocchino = new Chocolate(morocchino);
                    morocchino = new MilkFoam(morocchino);
                    morocchino.Size = Size.GRANDE;
                    return morocchino;
                case "mocha":
                    Beverage mocha = new Espresso();
                    mocha = new Chocolate(mocha);
                    mocha = new SteamedMilk(mocha);
                    mocha = new Whip(mocha);
                    mocha.Size = Size.VENDI;
                    return mocha;
                case "bicerin":
                    Beverage bicerin = new Espresso();
                    bicerin = new BlackChocolate(bicerin);
                    bicerin = new WhiteChocolate(bicerin);
                    bicerin = new Whip(bicerin);
                    bicerin.Size = Size.VENDI;
                    return bicerin;
                case "breve":
                    Beverage breve = new Espresso();
                    breve = new MilkFoam(breve);
                    breve = new HalfMilk(breve);
                    breve.Size = Size.GRANDE;
                    return breve;
                case "rafcoffee":
                    Beverage rafCoffee = new Espresso();
                    rafCoffee = new VanillaSugar(rafCoffee);
                    rafCoffee = new Cream(rafCoffee);
                    rafCoffee.Size = Size.VENDI;
                    return rafCoffee;
                case "meadraf":
                    Beverage meadRaf = new Espresso();
                    meadRaf = new Honey(meadRaf);
                    meadRaf = new Cream(meadRaf);
                    meadRaf.Size = Size.VENDI;
                    return meadRaf;
                case "galao":
                    Beverage galao = new Espresso();
                    galao = new MilkFoam(galao);
                    galao = new MilkFoam(galao);
                    galao.Size = Size.GRANDE;
                    return galao;
                case "caffeaffogato":
                    Beverage caffeAffogato = new Espresso();
                    caffeAffogato = new Espresso(caffeAffogato);
                    caffeAffogato = new IceCream(caffeAffogato);
                    caffeAffogato.Size = Size.GRANDE;
                    return caffeAffogato;
                case "viennacoffee":
                    Beverage viennaCoffee = new Espresso();
                    viennaCoffee = new Espresso(viennaCoffee);
                    viennaCoffee = new Whip(viennaCoffee);
                    viennaCoffee = new Whip(viennaCoffee);
                    viennaCoffee.Size = Size.GRANDE;
                    return viennaCoffee;
                case "glace":
                    Beverage glace = new Espresso();
                    glace = new IceCream(glace);
                    glace.Size = Size.GRANDE;
                    return glace;
                case "chocolatemilk":
                    Beverage chocolateMilk = new Chocolate();
                    chocolateMilk = new Milk(chocolateMilk);
                    chocolateMilk = new Milk(chocolateMilk);
                    chocolateMilk.Size = Size.VENDI;
                    return chocolateMilk;
                case "demicreme":
                    Beverage demiCreme = new Espresso();
                    demiCreme = new Espresso(demiCreme);
                    demiCreme = new Cream(demiCreme);
                    demiCreme = new Cream(demiCreme);
                    demiCreme.Size = Size.GRANDE;
                    return demiCreme;
                case "lattemacchiato":
                    Beverage latteMacchiato = new Espresso();
                    latteMacchiato = new SteamedMilk(latteMacchiato);
                    latteMacchiato = new SteamedMilk(latteMacchiato);
                    latteMacchiato = new MilkFoam(latteMacchiato);
                    latteMacchiato.Size = Size.TALL;
                    return latteMacchiato;
                case "freddo":
                    Beverage freddo = new Espresso();
                    freddo = new Liquor(freddo);
                    freddo = new Ice(freddo);
                    freddo.Size = Size.TALL;
                    return freddo;
                case "frappuccino":
                    Beverage frappuccino = new Espresso();
                    frappuccino = new Ice(frappuccino);
                    frappuccino = new SteamedMilk(frappuccino);
                    frappuccino = new Whip(frappuccino);
                    frappuccino.Size = Size.VENDI;
                    return frappuccino;
                case "caramelfrappuccino":
                    Beverage caramelFrappuccino = new Espresso();
                    caramelFrappuccino = new Ice(caramelFrappuccino);
                    caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
                    caramelFrappuccino = new Whip(caramelFrappuccino);
                    caramelFrappuccino = new Syrup(caramelFrappuccino);
                    caramelFrappuccino.Size = Size.VENDI;
                    return caramelFrappuccino;
                case "frappe":
                    Beverage frappe = new Espresso();
                    frappe = new SteamedMilk(frappe);
                    frappe = new SteamedMilk(frappe);
                    frappe = new IceCream(frappe);
                    frappe.Size = Size.TALL;
                    return frappe;
                case "irishcoffee":
                    Beverage irishCoffee = new Espresso();
                    irishCoffee = new Espresso(irishCoffee);
                    irishCoffee = new Whiskey(irishCoffee);
                    irishCoffee = new Whip(irishCoffee);
                    irishCoffee.Size = Size.GRANDE;
                    return irishCoffee;
                default:
                    throw new ArgumentException($"Coffee type '{type}' is not on the menu.");
            }
        }
    }
}
