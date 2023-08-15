namespace Factory
{
    public class FactoryPizza : IFactoryPizza
    {

        public Dictionary<int, Pizza> Pizzas = new Dictionary<int, Pizza>
        {
            {1, new PizzaCalabresa()},
            {2, new PizzaMussarela()},
        };

        public Pizza CriarPizza(int tipo)
        {
            Pizzas.TryGetValue(tipo, out Pizza pizza);
            return pizza;
        }
    }
}