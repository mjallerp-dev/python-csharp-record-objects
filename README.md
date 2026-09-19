# Records y objetos

Consola con la misma lógica en Python y C#: record `Alumno` y clase `Estudiante` (nombre, edad, promedio).

## Requisitos

- Python 3 (solo biblioteca estándar)
- .NET SDK 8.0 o superior (para la versión C#)

No hay base de datos, dependencias extra ni variables de entorno.

## Ejecutar

### Python

Desde la carpeta `python/`:

```
python alumno.py
python estudiante.py
```

### C#

Record `Alumno`:

```
dotnet run --project csharp/Alumno
```

Clase `Estudiante`:

```
dotnet run --project csharp/Estudiante
```

## Cómo probar

No hay menú: cada programa crea 3 instancias, las recorre y cambia el promedio de Miguel Jaller a 8.9.

**Alumno (record):** imprime nombre, edad y promedio. En Python el promedio se asigna al campo; en C# el record es inmutable y se actualiza con `with`.

**Estudiante (clase):** llama `mostrarInfo()` en cada objeto y cambia el promedio con `setPromedio(8.9)`.

## Comparativa

Este repo implementa Python y C#. El enunciado lista más lenguajes; la lógica es la misma y cambia el constructo.

| Lenguaje | Record / struct | Clase / objeto | Cómo se cambia el promedio |
| --- | --- | --- | --- |
| Python | `@dataclass` (`Alumno`) | `class` con `__init__` | Campo directo o `setPromedio` |
| C# | `record` (inmutable) | `class` con propiedades | `with { Promedio = 8.9 }` o `setPromedio` |
| Java | `record` (inmutable) | `class` | Nuevo record o setter |
| JavaScript | objeto literal | `class` | Asignación a la propiedad |
| TypeScript | `type` / `interface` | `class` | Igual que JS (tipos se borran al compilar) |
| Kotlin | `data class` | `class` | `var` en la propiedad |
| Dart | no hay record nativo | `class` | Asignación al campo |
| Go | `struct` | — | `alumnos[i].Promedio = …` |
| C | `struct` | — | `alumnos[i].promedio = …` |
| C++ | `struct` | `class` | Campo o método |
| PHP | — | `class` (constructor promoted) | Asignación o setter |

Diferencias relevantes:

1. **Inmutabilidad.** C# `record` y Java `record` no mutan el campo: se copia (`with` o constructor nuevo). Python `@dataclass`, JS, Go y C sí permiten `promedio = 8.9`.
2. **Métodos.** El record/struct guarda datos. La clase `Estudiante` añade `mostrarInfo` y `setPromedio`.
3. **Identidad.** Un `record` de C# compara por valor. Una `class` compara por referencia salvo que se implemente igualdad.
4. **Memoria.** En C, C++ y Go el `struct` suele ir por valor en el arreglo; hay que mutar `arreglo[i]`, no una copia local. Python, Java y C# (clases) guardan referencias.
