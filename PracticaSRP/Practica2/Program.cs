using Practica2;
using Practica2.Entities;

Imprimir mostrarDatos = new Imprimir("Enrique", 30, "Sagrario Diaz", "EsloanJimenez@gmail.com");
EnviarCorreo enviarCorreo = new EnviarCorreo("Enyher", 8, "Sagrario Diaz", "EnyherJimenez@gmail.com");

mostrarDatos.ImprimirDatos();
enviarCorreo.EnviarCorreoElectronico("Mandame una cotizacion de una boda para 200 personas con todo sus servicios incluidos.");