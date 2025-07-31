using Hoja_de_trabajo___Pilares_de_POO.ejercicios;
using System;
using System.Collections.Generic;
using static Hoja_de_trabajo___Pilares_de_POO.ejercicios.documento_fiscal;
using static Hoja_de_trabajo___Pilares_de_POO.ejercicios.Sistema_escolar;
internal class Program
{
    private static void Main(string[] args)
    {
        // Vehículos
        var miCarro = new Carro();
        var miMoto = new Motocicleta();

        Console.WriteLine("\nComportamiento individual:");
        Console.WriteLine($"Carro: {miCarro.Encender()} - {miCarro.Conducir()}");
        Console.WriteLine($"Moto: {miMoto.Encender()} - {miMoto.Conducir()}");

        var garaje = new List<Vehiculo> { new Carro(), new Motocicleta() };
        Console.WriteLine("\nLista de Vehículos (Polimorfismo):");
        foreach (var v in garaje)
            Console.WriteLine($"{v.GetType().Name}: {v.Encender()} - {v.Conducir()}");

        // Sistema escolar
        var escuela = new Escuela();
        escuela.AgregarPersona(new Estudiante("Ana", "7mo"));
        escuela.AgregarPersona(new Maestro("Lic. Mario", "Matemáticas"));
        escuela.MostrarTodosLosPerfiles();

        // Documentos fiscales
        var gestor = new GestorDocumentos();
        gestor.AgregarDocumento(new Factura("F-001", "Cliente X", 550));
        gestor.AgregarDocumento(new NotaCredito("NC-001", "F-001", "Producto defectuoso"));
        gestor.AgregarDocumento(new NotaDebito("ND-001", "F-001", 75.25m));
        gestor.GenerarReportesPDF();
    }
}
