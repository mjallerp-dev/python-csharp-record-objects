public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Alumno[] alumnos =
        [
            new("Miguel Jaller", 28, 8.5),
            new("Carlos Pérez", 22, 7.8),
            new("María García", 19, 9.2),
        ];

        Console.WriteLine("Recorrido inicial");
        foreach (var alumno in alumnos)
        {
            Console.WriteLine($"Nombre: {alumno.Nombre} | Edad: {alumno.Edad} | Promedio: {alumno.Promedio}");
        }

        Console.WriteLine("\nModificación del promedio de Miguel Jaller a 8.9");
        alumnos[0] = alumnos[0] with { Promedio = 8.9 };
        foreach (var alumno in alumnos)
        {
            Console.WriteLine($"Nombre: {alumno.Nombre} | Edad: {alumno.Edad} | Promedio: {alumno.Promedio}");
        }
    }
}
