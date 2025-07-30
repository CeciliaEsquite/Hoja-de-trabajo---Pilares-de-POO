using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_tarea1.Ejercicios
{
    public class Inventario
    {
        // ENCAPSULAMIENTO: el diccionario de productos está oculto (private).
        private Dictionary<string, int> productos = new Dictionary<string, int>();

        // ABSTRACCIÓN: el usuario del método no necesita saber cómo se almacenan los productos.
        public bool AgregarProducto(string nombre, int cantidad)
        {
            if (cantidad <= 0) return false;

            if (productos.ContainsKey(nombre))
                productos[nombre] += cantidad;
            else
                productos[nombre] = cantidad;

            return true;
        }


        public bool RetirarProducto(string nombre, int cantidad)
        {
            if (!productos.ContainsKey(nombre) || cantidad <= 0) return false;

            if (productos[nombre] >= cantidad)
            {
                productos[nombre] -= cantidad;

                if (productos[nombre] == 0)
                    productos.Remove(nombre);

                return true;
            }

            return false;
        }

        // ENCAPSULAMIENTO: solo se muestra un resumen de los productos
        public List<string> MostrarInventario()
        {
            List<string> resultado = new List<string>();

            foreach (var kvp in productos)
            {
                resultado.Add($"{kvp.Key}: {kvp.Value}");
            }

            return resultado;
        }
    }
}