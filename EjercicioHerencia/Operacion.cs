

namespace EjercicioHerencia
{
    public class Operacion
    {


        // Método para calcular el área de un cuadrado
        public double Cuadrado(double lado)
        {
            return lado * lado;
        }

        // Método para calcular el área de un triángulo
        public double Triangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }
        // Método para calcular el área de una circunferencia
       
        public double Circunferencia(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

    }
}
