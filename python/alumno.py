from dataclasses import dataclass
import sys


@dataclass
class Alumno:
    nombre: str
    edad: int
    promedio: float


if __name__ == "__main__":
    sys.stdout.reconfigure(encoding="utf-8")

    alumnos = [
        Alumno("Miguel Jaller", 28, 8.5),
        Alumno("Carlos Pérez", 22, 7.8),
        Alumno("María García", 19, 9.2),
    ]

    print("Recorrido inicial")
    for alumno in alumnos:
        print(f"Nombre: {alumno.nombre} | Edad: {alumno.edad} | Promedio: {alumno.promedio}")

    print("\nModificación del promedio de Miguel Jaller a 8.9")
    alumnos[0].promedio = 8.9
    for alumno in alumnos:
        print(f"Nombre: {alumno.nombre} | Edad: {alumno.edad} | Promedio: {alumno.promedio}")
