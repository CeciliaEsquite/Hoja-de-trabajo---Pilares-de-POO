using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Persona
{
    public string Nombre { get; set; }
    // Constructor que asigna el nombre
    public Persona(string nombre) => Nombre = nombre;
    public abstract string MostrarPerfil();
}
// Clase Estudiante que hereda de Persona
public class Estudiante : Persona
{
    public string Grado { get; set; }
    public Estudiante(string nombre, string grado) : base(nombre) => Grado = grado;
    // Implementación personalizada del método MostrarPerfil()
    public override string MostrarPerfil() => $"Estudiante: {Nombre}, Grado: {Grado}";
}
// Clase Maestro que también hereda de Persona
public class Maestro : Persona
{
    public string Materia { get; set; }
    public Maestro(string nombre, string materia) : base(nombre) => Materia = materia;
    public override string MostrarPerfil() => $"Maestro: {Nombre}, Materia: {Materia}";
}
// Clase Escuela que gestiona una lista de Personas que pueden llegar a ser Maestros o Estudiantes
public class Escuela
{
    private List<Persona> personas = new();

    public void AgregarPersona(Persona persona) => personas.Add(persona);
    // recorre la lista y llama a MostrarPerfil() en cada persona
    public void MostrarTodosLosPerfiles()
    {
        Console.WriteLine("\n--- Perfiles en la Escuela ---");
        foreach (var persona in personas)
            Console.WriteLine(persona.MostrarPerfil());
        Console.WriteLine("--------------------------------");
    }
}


