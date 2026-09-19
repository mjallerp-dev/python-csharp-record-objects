public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Promedio { get; set; }

    public Estudiante(string nombre, int edad, double promedio)
    {
        Nombre = nombre;
        Edad = edad;
        Promedio = promedio;
    }

    public void mostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre} | Edad: {Edad} | Promedio: {Promedio}");
    }

    public void setPromedio(double nuevoPromedio)
    {
        Promedio = nuevoPromedio;
    }
}
