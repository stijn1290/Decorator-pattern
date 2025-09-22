using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Espresso
            Beverage espresso = new Espresso();
            espresso.Size = Size.TALL;
            PrintBeverage(espresso);

            //Doppio
            Beverage doppio = new Espresso();
            doppio = new Espresso(doppio);
            doppio.Size = Size.GRANDE;
            PrintBeverage(doppio);

            //Lungo
            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            lungo.Size = Size.VENDI;
            PrintBeverage(lungo);

            //Macchiato
            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            macchiato.Size = Size.VENDI;
            PrintBeverage(macchiato);

            //corretta
            Beverage corretta = new Espresso();
            corretta = new Liquor(corretta);
            corretta.Size = Size.TALL;
            PrintBeverage(corretta);

            //Con panna
            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            conPanna.Size = Size.GRANDE;
            PrintBeverage(conPanna);

            //Cappucinno
            Beverage cappucinno = new Espresso();
            cappucinno = new SteamedMilk(cappucinno);
            cappucinno = new MilkFoam(cappucinno);
            cappucinno.Size = Size.VENDI;
            PrintBeverage(cappucinno);

            //Americano
            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            americano.Size = Size.GRANDE;
            PrintBeverage(americano);

            //Caffe latte
            Beverage cafeLatte = new Espresso();
            cafeLatte = new SteamedMilk(cafeLatte);
            cafeLatte = new SteamedMilk(cafeLatte);
            cafeLatte = new MilkFoam(cafeLatte);
            cafeLatte.Size = Size.TALL;
            PrintBeverage(cafeLatte);

            //Flat white
            Beverage flatWhite = new Espresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite.Size = Size.TALL;
            PrintBeverage(flatWhite);

            //Romana
            Beverage romana = new Espresso();
            romana = new Lemon(romana);
            romana.Size = Size.GRANDE;
            PrintBeverage(romana);

            //Morocchino
            Beverage morocchino = new Espresso();
            morocchino = new Chocolate(morocchino);
            morocchino = new MilkFoam(morocchino);
            morocchino.Size = Size.GRANDE;
            PrintBeverage(morocchino);

            //Mocha
            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            mocha.Size = Size.VENDI;
            PrintBeverage(mocha);

            //Bicerin
            Beverage bicerin = new Espresso();
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            bicerin.Size = Size.VENDI;
            PrintBeverage (bicerin);

            //Breve
            Beverage breve = new Espresso();    
            breve = new MilkFoam (breve);
            breve = new HalfMilk (breve);
            breve.Size = Size.GRANDE;
            PrintBeverage(breve);
            
            //Raf Coffee
            Beverage rafCoffee = new Espresso();
            rafCoffee = new VanillaSugar (rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            rafCoffee.Size = Size.VENDI;
            PrintBeverage(rafCoffee);

            //Mead Raf
            Beverage meadRaf = new Espresso();
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            meadRaf.Size = Size.VENDI;
            PrintBeverage (meadRaf);

            //Galao
            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            galao.Size = Size.GRANDE;
            PrintBeverage (galao);

            //Caffe affogato
            Beverage caffeAffogato = new Espresso();
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato = new IceCream(caffeAffogato);
            caffeAffogato.Size = Size.GRANDE;
            PrintBeverage(caffeAffogato);

            //Vienna Coffee
            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip (viennaCoffee);
            viennaCoffee.Size = Size.GRANDE;
            PrintBeverage(viennaCoffee);

            //Glace
            Beverage glace = new Espresso();
            glace = new IceCream(glace);
            glace.Size = Size.GRANDE;
            PrintBeverage (glace);

            //Chocolate milk
            Beverage chocolateMilk = new Chocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk.Size = Size.VENDI;
            PrintBeverage(chocolateMilk);

            //Demi Creme
            Beverage demiCreme = new Espresso();
            demiCreme = new Espresso(demiCreme);
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream (demiCreme);
            demiCreme.Size = Size.GRANDE;
            PrintBeverage(demiCreme);

            //Latte Macchiato
            Beverage latteMacchiato = new Espresso ();  
            latteMacchiato = new SteamedMilk (latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam (latteMacchiato);
            latteMacchiato.Size = Size.TALL;
            PrintBeverage(latteMacchiato);

            //Freddo
            Beverage freddo = new Espresso ();
            freddo = new Liquor(freddo);
            freddo = new Ice(freddo);
            freddo.Size = Size.TALL;
            PrintBeverage (freddo);

            //Frappuccino
            Beverage frappuccino = new Espresso ();
            frappuccino = new Ice (frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            frappuccino.Size = Size.VENDI;
            PrintBeverage(frappuccino);

            // Caramel Frappuccino
            Beverage caramelFrappuccino = new Espresso ();
            caramelFrappuccino = new Ice (caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk (caramelFrappuccino);
            caramelFrappuccino = new Whip (caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            caramelFrappuccino.Size = Size.VENDI;
            PrintBeverage(caramelFrappuccino);

            //Frappe
            Beverage frappe = new Espresso ();
            //solution
            frappe.Size = Size.GRANDE;
            frappe = new SteamedMilk (frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream (frappe);
            frappe.Size = Size.TALL;
            PrintBeverage(frappe);

            //Irish Coffee
            Beverage irishCoffee = new Espresso ();
            irishCoffee = new Espresso (irishCoffee);
            irishCoffee = new Whiskey (irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            irishCoffee.Size = Size.GRANDE;
            PrintBeverage (irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.cost().ToString("#.##"));
        }
    }
}