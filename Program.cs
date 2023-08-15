namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            IFactoryPizza factory = new FactoryPizza();

            Pizza pizza = factory.CriarPizza(1);
            Console.WriteLine(pizza.Nome);

        }
    }
}