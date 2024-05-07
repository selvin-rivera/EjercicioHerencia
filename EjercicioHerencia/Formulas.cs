



namespace EjercicioHerencia
{
    public class Formulas : Operacion
    {
        // Método para imprimir los resultados de las operaciones
        public static void Imprimir(double Cuadrado, double Triangulo, double Circunferencia)
        {
            Console.WriteLine("Resultados de las operaciones:");
            Console.WriteLine($"Área del cuadrado: {Cuadrado}");
            Console.WriteLine($"Área del triángulo: {Triangulo}");
            Console.WriteLine($"Área de la circunferencia: {Circunferencia}");

        }
    }
}
