using System;

string Nombre;
int NumCalificaciones = 0;
string Validacion;
float SumaCalificaciones = 0;
float a;
float Promedio;

do
{
    Console.WriteLine("Ingrese su nombre: ");
    Nombre = Console.ReadLine();
} while (string.IsNullOrEmpty(Nombre));

do
{
    Console.WriteLine("Ingrese cantidad de calificaciones: ");
    Validacion = Console.ReadLine();
} while (string.IsNullOrEmpty(Validacion));
NumCalificaciones = int.Parse(Validacion);
do
{
    if (NumCalificaciones < 1)
    {
        Console.WriteLine("Ingrese una cantidaad válida: ");
        NumCalificaciones = int.Parse(Console.ReadLine());
    }

    else if (NumCalificaciones > 5)
    {
        Console.WriteLine("Ingrese una cantidad válida: ");
        NumCalificaciones = int.Parse(Console.ReadLine());
    }

} while (NumCalificaciones < 1 || NumCalificaciones > 5);


for (int i = 0; i < NumCalificaciones; i++)
{
    Console.WriteLine("Ingrese una Calificación: ");
    a = float.Parse(Console.ReadLine());
    while (a <= 0 || a >= 11)
    {
        Console.WriteLine("Ingrese una calificación válida: ");
        a = float.Parse(Console.ReadLine());
    }
    SumaCalificaciones += a;
}

Promedio = SumaCalificaciones / NumCalificaciones;
string Condicion;
if (Promedio >= 9)
    Condicion = "Excelente";
else if (Promedio >= 7 && Promedio < 9)
    Condicion = "Bueno";
else if (Promedio >= 6 && Promedio < 7)
    Condicion = "Regular";
else
    Condicion = "Reprobado";

Console.WriteLine(Nombre + " tu promedio es " + Promedio + " y tu condición es " + Condicion);