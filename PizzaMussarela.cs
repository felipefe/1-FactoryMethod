using System.Collections;

namespace Factory
{
    public class PizzaMussarela : Pizza
    {
        public override string Nome { get; set; }

        public PizzaMussarela()
        {
            Nome = "Pizza Mussarela";
        }
    }
}