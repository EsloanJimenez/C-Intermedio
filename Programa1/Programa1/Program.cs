using Programa1;
using static System.Console;

string nombreSocio1, nombreSocio2, nombreSocio3;
nombreSocio1 = nombreSocio2 = nombreSocio3 = "";

int antiguedadSocio1, antiguedadSocio2, antiguedadSocio3;
antiguedadSocio1 = antiguedadSocio2 = antiguedadSocio3 = 0;

int contador;

do {
    contador = 0;
    try
    {
        Write("\nDgite el nombre del primer socio: ");
        nombreSocio1 = ReadLine();

        Write("Cuantos años de antiguedad tiene el primer socio: ");
        antiguedadSocio1 = int.Parse(ReadLine());

        Write("\nDgite el nombre del segundo socio: ");
        nombreSocio2 = ReadLine();

        Write("Cuantos años de antiguedad tiene el segundo socio: ");
        antiguedadSocio2 = int.Parse(ReadLine());

        Write("\nDgite el nombre del tercer socio: ");
        nombreSocio3 = ReadLine();

        Write("Cuantos años de antiguedad tiene el tercer socio: ");
        antiguedadSocio3 = int.Parse(ReadLine());

    }
    catch (FormatException e)
    {
        contador++;
        WriteLine(e.Message);
        WriteLine("\nEl valor ingresado en el campo -ANTIGUEDAD- no es de tipo de dato numerico, \npor favor debe de ingresar valores de tipo numerico\n\n");
    }
    catch (Exception e)
    {
        contador++;
        WriteLine(e.ToString());
    }
} while(contador > 0);


Socio socio1 = new Socio(nombreSocio1, antiguedadSocio1);
Socio socio2 = new Socio(nombreSocio2, antiguedadSocio2);
Socio socio3 = new Socio(nombreSocio3, antiguedadSocio3);

Club club = new Club(socio1, socio2, socio3);
club.SocioMasAntiguo();

