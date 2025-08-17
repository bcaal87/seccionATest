# Examen Único (5 pts) — Funciones, Arreglos y Flujo Git

## Objetivo
Implementar en C# una función que calcule el promedio de 5 enteros y, usando un flujo de trabajo con Git y GitHub, entregar el trabajo mediante un Pull Request (PR) desde una rama propia.

## Estructura del Repositorio
/
├─ README.md
├─ CONTRIBUTORS.md
└─ alumnos/
   └─ (aquí irá tu carpeta personal con carnet)

## Pasos del Estudiante
1. Clonar el repositorio y crear rama `feature/promedio-<CARNET>`
2. Crear carpeta `alumnos/<CARNET>/` y dentro un proyecto .NET console `PromedioApp`
3. Implementar en `Program.cs` la función:
   ```csharp
   static double Promedio(int[] numeros)
   ```
   que reciba un arreglo de 5 enteros y devuelva el promedio.
4. Mostrar el promedio con 2 decimales y validar entradas enteras.
5. Editar `CONTRIBUTORS.md` agregando su nombre y carnet.
6. Hacer commit y push de la rama.
7. Crear un Pull Request a `main` con captura de ejecución.

## Criterios de Evaluación (5 pts)
- Rama y convención: 0.5 pts
- Implementación C#: 2.0 pts
- Evidencia y PR: 2.5 pts
