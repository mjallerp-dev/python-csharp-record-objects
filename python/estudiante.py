import sys


class Estudiante:
    def __init__(self, nombre: str, edad: int, promedio: float) -> None:
        self.nombre = nombre
        self.edad = edad
        self.promedio = promedio

    def mostrarInfo(self) -> None:
        print(f"Nombre: {self.nombre} | Edad: {self.edad} | Promedio: {self.promedio}")

    def setPromedio(self, nuevo_promedio: float) -> None:
        self.promedio = nuevo_promedio


if __name__ == "__main__":
    sys.stdout.reconfigure(encoding="utf-8")

    estudiantes = [
        Estudiante("Miguel Jaller", 27, 8.5),
        Estudiante("Carlos Pérez", 22, 7.8),
        Estudiante("María García", 19, 9.2),
    ]

    print("Recorrido inicial")
    for estudiante in estudiantes:
        estudiante.mostrarInfo()

    print("\nModificación del promedio de Miguel Jaller a 8.9")
    estudiantes[0].setPromedio(8.9)
    for estudiante in estudiantes:
        estudiante.mostrarInfo()
