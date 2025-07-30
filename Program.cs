using POO_tarea1.Ejercicios;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ABSTRACCIÓN: Uso de la clase Biblioteca para registrar libros sin conocer detalles.
        var biblioteca = new Biblioteca();
        biblioteca.RegistrarLibro("Cien Años de Soledad", "Gabriel García Márquez");
        biblioteca.RegistrarLibro("El Principito", "Antoine de Saint-Exupéry");

        Console.WriteLine("Libros disponibles:");
        // ABSTRACCIÓN: No se manipula la lista interna de libros, solo se muestra el resultado.
        foreach (var libro in biblioteca.MostrarLibrosDisponibles())
            Console.WriteLine(libro);

        // ABSTRACCIÓN y ENCAPSULAMIENTO: Se presta un libro pero no se accede directamente al estado del mismo.
        biblioteca.PrestarLibro("El Principito", "Juan Pérez");

        Console.WriteLine("\nDespués del préstamo:");
        foreach (var libro in biblioteca.MostrarLibrosDisponibles())
            Console.WriteLine(libro);

        var usuario = new Usuario
        {
            Nombre = "Joseph Aldana",
            DPI = "1234123451234"  
        };
        usuario.AsignarContraseña("*contra123"); 

        // ENCAPSULAMIENTO: No se expone la contraseña, solo se verifica.
        Console.WriteLine($"\nAutenticación: {(usuario.Autenticar("*contra123*") ? "Éxito" : "Fallido")}");

        // ABSTRACCIÓN y ENCAPSULAMIENTO: se ingresan de manera interna los productos.
        var inventario = new Inventario();
        inventario.AgregarProducto("Lápiz", 10);
        inventario.AgregarProducto("Cuaderno", 5);
        inventario.RetirarProducto("Lápiz", 3);
        inventario.AgregarProducto("Lápiz", 10);

        Console.WriteLine("\nInventario:");
        foreach (var item in inventario.MostrarInventario())
            Console.WriteLine(item);
    }
}