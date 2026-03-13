namespace SystemInventory.productos
{
    internal class ProductoAlimento : Producto
    {
        private double fechaVencimiento { get; set; }
        public ProductoAlimento(string nombre, string código, double precio, int cantidad, double fechaVencimiento) : base(nombre, código, precio, cantidad)
        {
            this.fechaVencimiento = fechaVencimiento;
        }

        public override double calcularImpuesto()
        {
            return Precio * 0.8 * Cantidad;
        }

        public override void MostrarProducto()
        {
            Console.WriteLine("Datos del Producto: ");
            base.MostrarProducto();
            Console.WriteLine("Fecha De Vencimiento: " + fechaVencimiento);
            Console.WriteLine("Impuesto: " + calcularImpuesto());
        }
    }
}
