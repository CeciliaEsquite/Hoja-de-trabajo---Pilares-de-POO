using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_tarea1.Ejercicios
{
    public class Libro
    {
        // ENCAPSULAMIENTO: los campos están marcados como privados, no se puede acceder a ellos directamente desde otras clases.
        private string titulo;
        private string autor;
        private bool disponible;
        private Guid id;
        private string usuarioPrestamo;

        public string Titulo => titulo;
        public string Autor => autor;
        public bool Disponible => disponible;
        public Guid Id => id;

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.disponible = true;
            this.id = Guid.NewGuid(); // ABSTRACCIÓN: se usa un ID sin exponerlo.
        }

        // Aplica ENCAPSULAMIENTO: modifica el estado del objeto.
        public bool Prestar(string usuario)
        {
            if (!disponible) return false;
            disponible = false;
            usuarioPrestamo = usuario;
            return true;
        }
        public void Devolver()
        {
            disponible = true;
            usuarioPrestamo = null;
        }
    }
}