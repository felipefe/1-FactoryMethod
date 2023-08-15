using System.Collections;

namespace Factory
{
    public class PizzaCalabresa : Pizza
    {
        public override string Nome { get; set; }

        public PizzaCalabresa()
        {
            Nome = "Pizza Calabresa";
        }
    }
}