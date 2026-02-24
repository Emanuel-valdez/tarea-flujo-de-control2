namespace tarea_flujo_de_control2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos estudiantes desea ingresar? ");
            int n = int.Parse(Console.ReadLine());

            // Header
            Console.WriteLine();
            Console.WriteLine($"{"Estudiante",-25} {"Nota 1",7} {"Nota 2",7} {"Nota 3",7} {"Nota 4",7} {"Promedio",9} {"Estatus",10}");
            Console.WriteLine(new string('-', 80));

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"\nIngrese el nombre del estudiante {i}: ");
                string nombre = Console.ReadLine();

                double[] notas = new double[4];
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"  Nota {j + 1}: ");
                    notas[j] = double.Parse(Console.ReadLine());
                }

                double promedio = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;
                string estatus = promedio >= 70 ? "Aprobado" : "Reprobado";

                Console.WriteLine($"\n{"Estudiante",-25} {"Nota 1",7} {"Nota 2",7} {"Nota 3",7} {"Nota 4",7} {"Promedio",9} {"Estatus",10}");
                Console.WriteLine($"{nombre,-25} {notas[0],7} {notas[1],7} {notas[2],7} {notas[3],7} {promedio,9:F2} {estatus,10}");
                Console.WriteLine(new string('-', 80));
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
