using EjercicioHerencia;

//creando un objeto
Formulas operacionArea = new Formulas();

// Calcular áreas utilizando los métodos heredados
double Cuadrado = operacionArea.Cuadrado(7);
double Triangulo = operacionArea.Triangulo(6, 4);
double Circunferencia = operacionArea.Circunferencia(5);


// Imprimir resultados
Formulas.Imprimir(Cuadrado,Triangulo, Circunferencia);
