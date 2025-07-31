using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.ejercicios
{// CLASE ABSTRACTA que representa un vehículo genérico
    public abstract class Vehiculo
    { // Método concreto que los vehículos comparten
        public string Encender() => "El vehículo está encendido.";
        // Método Abstracto que  los vehículos comparten
        public abstract string Conducir();
    }
    // Clases Carro y moto hereda de la clase Vehiculo e implementa su versión de 'Conducir'
    public class Carro : Vehiculo
    {
        public override string Conducir() => "El carro está conduciendo a 40 km/h.";
    }
    
    public class Motocicleta : Vehiculo
    {
        public override string Conducir() => "La motocicleta está esquivando los carros para avanzar más rápido.";
    }
}