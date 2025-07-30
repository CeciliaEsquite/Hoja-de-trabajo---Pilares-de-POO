using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_tarea1.Ejercicios
{
    public class Biblioteca
    {
        // ENCAPSULAMIENTO: La lista privada 'libros' no es accesible desde fuera.
        private List<Libro> libros = new List<Libro>();

        // ABSTRACCIÓN: Oculta cómo se registra un libro internamente.
        public bool RegistrarLibro(string titulo, string autor)
        {
            if (libros.Any(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)))
                return false;

            libros.Add(new Libro(titulo, autor));
            return true;
        }

        // ABSTRACCIÓN: El usuario solo llama a PrestarLibro sin saber la lógica.
        // ENCAPSULAMIENTO: Se delega la acción de prestar el Libro.
        public bool PrestarLibro(string titulo, string usuario)
        {
            var libro = libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase) && l.Disponible);
            if (libro != null)
            {
                return libro.Prestar(usuario);
            }
            return false;
        }

        // ABSTRACCIÓN: Solo hay una lista con información necesaria.
        public List<string> MostrarLibrosDisponibles()
        {
            return libros.Where(l => l.Disponible)
                         .Select(l => $"{l.Titulo} por {l.Autor}")
                         .ToList();
        }
    }
}