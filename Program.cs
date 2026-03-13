using SystemInventory.productos;
namespace SystemInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la informacion de su prodcuto Electronico:");
            Console.Write("Nombre: ");
            string Nombre = Console.ReadLine();
            Console.Write("código: ");
            string código = Console.ReadLine();
            Console.Write("precio: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("garantiaMeses: ");
            double garantiaMeses = double.Parse(Console.ReadLine());
            ProductoElectronico productoElectronico = new ProductoElectronico(Nombre, código, precio, cantidad, garantiaMeses);
            productoElectronico.MostrarProducto();

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ingrese la informacion de su prodcuto Alimentario:");
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("código: ");
            código = Console.ReadLine();
            Console.Write("precio: ");
            precio = double.Parse(Console.ReadLine());
            Console.Write("cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.Write("garantiaMeses: ");
            double fechaVencimiento = double.Parse(Console.ReadLine());
            ProductoAlimento productoAlimento = new ProductoAlimento(Nombre, código, precio, cantidad, fechaVencimiento);
            productoAlimento.MostrarProducto();

            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
