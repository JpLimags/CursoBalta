namespace Struct;

public class Struct
{
    struct Product
    {

        static void Main()
        {
            Product mouse = new Product(1, "Mouse Gamer", 285.60, EProudctType.Product);
            Product manutecaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProudctType.Service);
            
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }

        public Product(int id, string name, double price, EProudctType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        
        public int Id;
        public string Name;
        public double Price;
        public EProudctType Type;

        public double PriceInDOlar(double dolar)
        {

            return Price * dolar;
        }
    }

    enum EProudctType
    {
        
        Product = 1,
        Service = 2
    }
}