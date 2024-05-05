using System;

class NotasAlumno
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese las notas
        Console.WriteLine("Ingrese la primera nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        // Calcular el promedio
        double promedio = (nota1 + nota2 + nota3) / 3;

        // Determinar el mensaje según el promedio
        string mensaje;
        if (promedio >= 7)
        {
            mensaje = "Promocionado";
        }
        else if (promedio >= 4 && promedio < 7)
        {
            mensaje = "Regular";
        }
        else
        {
            mensaje = "Reprobado";
        }

        // Mostrar el resultado
        Console.WriteLine("El alumno está " + mensaje);
    }
}
