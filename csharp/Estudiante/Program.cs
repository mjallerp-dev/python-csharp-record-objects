public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Estudiante[] estudiantes =
        [
            new("Miguel Jaller", 27, 8.5),
            new("Carlos Pérez", 22, 7.8),
            new("María García", 19, 9.2),
        ];

        Console.WriteLine("Recorrido inicial");
        foreach (var estudiante in estudiantes)
        {
            estudiante.mostrarInfo();
        }

        Console.WriteLine("\nModificación del promedio de Miguel Jaller a 8.9");
        estudiantes[0].setPromedio(8.9);
        foreach (var estudiante in estudiantes)
        {
            estudiante.mostrarInfo();
        }
    }
}
