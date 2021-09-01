using System;
using System.Collections.Generic;
namespace class1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shirt> Shirt = new List<Shirt>();
            Shirt ShoppingCart = new Shirt(1, "ShoppingCart");
            Shirt color = new Shirt(2, "color");
            Shirts.Add(ShoppingCart);
            Shirts.Add(color);
            foreach (Shirt shirt in shirt)
            {
                Console.WriteLine(shirt.name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shirt> Shirt = new List<Shirt>();
            Shirt ShoppingCart = new Shirt(1, "ShoppingCart");
            Shirt order = new Shirt(2, "color");
            Shirt whatIf = new Shirt(3, "What...if");
            Shirts.Add(ShoppingCart);
            Shirts.Add(color);
            Shirts.Insert(1, whatIf);
            foreach (Shirt shirt in shirt)
            {
                Console.WriteLine(shirt.name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace class3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shirt> Shirt = new List<Shirt>();
            Shirt ShoppingCart = new ShoppingCart(1, "ShoppingCart");
            Shirt ShoppingCart = new Shirt(2, "color");
            Shirt whatIf = new Shirt(3, "What...if");
            Shirts.Add(ShoppingCart);
            Shirts.Add(color);
            Shirts.Insert(1, whatIf);
            Shirts.Remove(ShoppingCart);
            foreach (Shirt shirt in shirt)
            {
                Console.WriteLine(shirt.name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace class4
class User
{
    public string name;
    private List<Shirt> shirts;
    public User(string valueName)
    {
        name = valueName;
        Shirt = new List<Shirt>();
    }
    public void addList(Shirt shirt)
    {
        shirts.Add(shirt);
    }
    public void getshirts()
    {
        shirts.ForEach(value => { Console.WriteLine(value.name); });
    }
}

using System;
using System.Collections.Generic;
namespace class5
{
    class Program
    {
        static void Main(string[] args)
        {
            User jame = new User("jame");
            Shirt order = new Shirt(1, "Tshirt");
            Shirt getshirts = new Shirt(2, "color");
            jame.addList(email);
            jame.addList(city);
            jame.addList(zipCode);
            jame.Address();
        }
    }
}