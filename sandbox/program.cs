using System;
class Program
{
    static void Main(string[] args )
    {
        Cart cart = new Cart();
        cart._name = "Shopping List for Walmart";

        Menu menu = new Menu();

        bool done = false;
        while (!done)
        {
            cart.Add();
            
        }



    }

}
