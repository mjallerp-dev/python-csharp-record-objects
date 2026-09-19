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
