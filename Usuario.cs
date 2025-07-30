using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_tarea1.Ejercicios
{
    // La clase Usuario representa a un usuario del sistema con nombre, DPI y una contraseña privada.
    // Aplica fuertemente los principios de ENCAPSULAMIENTO y ABSTRACCIÓN.
    public class Usuario
    {
        // ENCAPSULAMIENTO: los datos sensibles están protegidos con campos privados.
        private string dpi;
        private string contraseña;

        // Propiedad pública para el nombre, sin validación (por simplicidad).
        public string Nombre { get; set; }

        // Propiedad con lógica de validación en el 'set' para DPI.
        // ENCAPSULAMIENTO: protege la asignación de un valor inválido desde el exterior.
        public string DPI
        {
            get => dpi;
            set
            {
                if (value.Length == 13 && value.All(char.IsDigit))
                    dpi = value;
                else
                    throw new ArgumentException("El DPI debe tener exactamente 13 dígitos.");
            }
        }

        // Método para asignar una contraseña al usuario.
        // ABSTRACCIÓN: oculta cómo se guarda o valida la contraseña.
        public void AsignarContraseña(string nuevaContraseña)
        {
            if (nuevaContraseña.Length >= 6)
                contraseña = nuevaContraseña;
            else
                throw new ArgumentException("La contraseña debe tener al menos 6 caracteres.");
        }

        // Método para verificar la contraseña introducida por el usuario.
        // ENCAPSULAMIENTO: el campo `contraseña` nunca se expone directamente.
        public bool Autenticar(string input)
        {
            return input == contraseña;
        }
    }
}