using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SystemInventory.productos
{
    internal class ProductoElectronico : Producto
    {
        private double garantiaMeses { get; set; }
        public ProductoElectronico(string nombre, string código, double precio, int cantidad, double garantiaMeses) : base(nombre, código, precio, cantidad)
        {
            this.garantiaMeses = garantiaMeses;
        }

        public override double calcularImpuesto()
        {
            return Precio * 0.18 * Cantidad;
        }

        public override void MostrarProducto()
        {
            Console.WriteLine("Datos del Producto: ");
            base.MostrarProducto();
            string gar = garantiaMeses <= 1 ? "mes" : "meses";
            Console.WriteLine("Garantia: " + gar);
            Console.WriteLine($"Impuesto: {garantiaMeses} " + calcularImpuesto());
        }

    }
}
