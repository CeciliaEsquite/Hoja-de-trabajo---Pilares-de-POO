using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CLASE ABSTRACTA que presentamos  un documento fiscal
public abstract class DocumentoFiscal
{
    public string Numero { get; set; }
    public DocumentoFiscal(string numero) => Numero = numero;
    // Método abstracto que cada documento implementa a su manera
    public abstract string GenerarPDF();
}

public class Factura : DocumentoFiscal
{
    public string Cliente { get; set; }
    public decimal Monto { get; set; }

    public Factura(string numero, string cliente, decimal monto) : base(numero)
    {
        Cliente = cliente;
        Monto = monto;
    }

    public override string GenerarPDF() => $"Factura {Numero} para {Cliente} por Q{Monto:F2}";
}

public class NotaCredito : DocumentoFiscal
{
    public string FacturaOriginal { get; set; }
    public string Razon { get; set; }

    public NotaCredito(string numero, string facturaOriginal, string razon) : base(numero)
    {
        FacturaOriginal = facturaOriginal;
        Razon = razon;
    }

    public override string GenerarPDF() => $"Nota de Crédito {Numero} ref. {FacturaOriginal} por '{Razon}'";
}

public class NotaDebito : DocumentoFiscal
{
    public string FacturaOriginal { get; set; }
    public decimal CargoAdicional { get; set; }

    public NotaDebito(string numero, string facturaOriginal, decimal cargoAdicional) : base(numero)
    {
        FacturaOriginal = facturaOriginal;
        CargoAdicional = cargoAdicional;
    }

    public override string GenerarPDF() => $"Nota de Débito {Numero} ref. {FacturaOriginal} por Q{CargoAdicional:F2}";
}
// La Clase gestiona una lista de documentos fiscales
public class GestorDocumentos
{
    private List<DocumentoFiscal> documentos = new();

    public void AgregarDocumento(DocumentoFiscal doc) => documentos.Add(doc);

    // Recorre los documentos y llama a GenerarPDF() en cada uno polimorfismo
    public void GenerarReportesPDF()
    {
        Console.WriteLine("\n--- Reportes PDF ---");
        foreach (var doc in documentos)
            Console.WriteLine(doc.GenerarPDF());
        Console.WriteLine("---------------------");
    }
}
