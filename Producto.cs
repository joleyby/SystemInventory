/*
Crear la clase base Producto
Atributos privados:
• nombre
• código
• precio
• cantidad
Debe incluir:
• Constructor
• Propiedades
• Método: MostrarProducto()
Aplicar Encapsulación
Todos los atributos deben ser privados.
El acceso debe realizarse mediante propiedades públicas.
*/
namespace SystemInventory
{
    internal class Producto
    {
        private string nombre { set; get; }
        private string código { set; get; }
        private double precio { set; get; }
        private int cantidad { set; get; }

        public Producto(string nombre, string código, double precio, int cantidad)
        {
            Nombre = nombre;
            Código = código;
            Precio = precio;
            Cantidad = cantidad;
        }

        public string Nombre {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Código {
            set { código = value; }
            get { return código; }
        }
        public double Precio {
            set { precio = value; }
            get { return precio; }
        }
        public int Cantidad { 
            set { cantidad = value; }
            get { return cantidad; }
        }

        public virtual void MostrarProducto()
        {
            Console.WriteLine("producto: " + Nombre);
            Console.WriteLine("Código: " + Código);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Cantidad: " + Cantidad);
        }

        public virtual double calcularImpuesto()
        {
            return 0;
        }
    }


}
