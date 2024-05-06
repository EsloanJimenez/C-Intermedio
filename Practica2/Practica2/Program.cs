using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Console;
public class Persona {

    private string nombre;
    private int edad;
    private string direccion;
    private string correoElectronico;

    public void EnviarCorreoElectronico(string mensaje)
    {
        // Lógica para enviar correo electrónico
    }

    public void ImprimirDatos() { 
        WriteLine($"Nombre: {nombre}");
        WriteLine($"Edad: {edad}");
        WriteLine($"Dirección: {direccion}");
        WriteLine($"Correo electrónico: {correoElectronico}");
    }
}