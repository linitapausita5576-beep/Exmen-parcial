using System.Windows.Markup;

namespace Exmen_parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro de Producto Electronico");

            Console.WriteLine("Nombre: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Codigo: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            double p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            double cc1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Garantia de meses: ");
            double g = double.Parse(Console.ReadLine());

            ProductoElectronico proele = new ProductoElectronico(n1, c1, p1, cc1, g);

            Console.WriteLine("Registro de Alimentos");

            Console.WriteLine("Nombre: ");
            string n2 = Console.ReadLine();
            Console.WriteLine("Codigo: ");
            double c2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            double p2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            double cc2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Fecha de vencimiento: ");
            double fv = double.Parse(Console.ReadLine());

            ProductoAlimento proali = new ProductoAlimento(n2, c2, p2, cc2, fv);

            Console.WriteLine("\nResultados");
            proele.MostrarProducto();
            Console.WriteLine($"Impuesto (0.18): {proele.CalcularImpuesto}");

            Console.WriteLine("\nResultados");
            proali.MostrarProducto();
            Console.WriteLine($"Impuesto (0.08): {proali.CalcularImpuesto}");

        }
    }

    public class Producto 
    {
        private string _Nombre;
        private double _Codigo;
        private double _Precio;
        private double _Cantidad;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public double Codigo { get => _Codigo; set => _Codigo = value; }
        public double Precio { get => _Precio; set => _Precio = value; }

        public double Cantidad { get => _Cantidad; set => _Cantidad = value; }

        public Producto(string nombre, double codigo, double precio, double cantidad)
        {
            Nombre = nombre;
            Codigo = codigo;
            Precio = precio;
            Cantidad = cantidad;

        }

        public void MostrarProducto() 
        {
            Console.WriteLine($"Producto: {Nombre}");
            Console.WriteLine($"Codigo: {Codigo}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Caantidad: {Cantidad}");
        }
        public virtual double CalcularImpuesto() 
        {
            return 0;
        }
    }

    public class ProductoElectronico : Producto 
    { 
     private double GarantiaDeMeses { get; set; }

        public ProductoElectronico(string nombre, double codigo, double precio, double cantidad, double garantia) 
        : base(nombre, codigo, precio, cantidad)
        {
            GarantiaDeMeses = garantia;
        }

        public void MostrarProducto() 
        {
            Console.WriteLine($"Garantia de Meses: {GarantiaDeMeses}");
        }
        public override double CalcularImpuesto() 
        {
            return (Precio * 0.18);
        }
    }

    public class ProductoAlimento: Producto 
    { 
     private double FechadeVencimiento { get; set; }

        public ProductoAlimento(string nombre, double codigo, double precio, double cantidad, double vencimiento)
            : base (nombre, codigo, precio, cantidad)
        {
            FechadeVencimiento = vencimiento;
        }

        public void MostrarProducto() 
        {
            Console.WriteLine($"Fecha de vencimiento: {FechadeVencimiento}");
        }
        public override double CalcularImpuesto()
        {
            return (Precio * 0.08);
        }
    }
}
