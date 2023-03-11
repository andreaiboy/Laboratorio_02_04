// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Andrea Gabriela Iboy Casados 1076623");
Console.WriteLine("Ejercicio 1");
Console.Write("Ingrese un numero entero: ");

try
{
    int x = Convert.ToInt32(Console.ReadLine());

    if (x == 0)
    {
        Console.WriteLine("El numero es cero");
    }
    else if (x > 0)
    {
        Console.WriteLine("El numero es positivo");
    }
    else
    {
        Console.WriteLine("El numero es negativo");
    }
}
catch (Exception ex)
{
    Console.WriteLine("no ingreso un numero. " + ex.Message);
}

Console.WriteLine("Ejercicio 2");
Console.WriteLine("Ingresa el número de día");

try
{
    int numerodia = int.Parse(Console.ReadLine());
    
    if (numerodia < 1 || numerodia > 7) 
    {
        Console.WriteLine("Error, el número a ingresar debe estar contenido entre 1 y 7");
    }
    else
    {
        string dia = "";
        if (numerodia == 1) ;
        {
            dia = "Lunes";
        }
        if (numerodia == 2)
        {
            dia = "Martes";
        }
        else if (numerodia == 3)
        {
            dia = "Miercoles";
        }
        else if (numerodia == 4)
        {
            dia = "Jueves"; 
        }
        else if (numerodia == 5)
        {
            dia = "Viernes";
        }
        else if (numerodia == 6)
        {
            dia = "Sábado";
        }
        else if (numerodia == 7)
        {
            dia = "Domingo";
        }
        Console.WriteLine("Día: " + dia);
    }
}
catch
{
    Console.WriteLine("Error, intentalo de nuevo");
}
Console.WriteLine("______________________________________");
Console.WriteLine("Andrea Gabriela Iboy Casados 1076623");
Console.WriteLine("______________________________________");
Console.WriteLine("Tarea - Problema No. 2");
Console.WriteLine("Ingrese la cantidad de dinero");
double cantidad = double.Parse(Console.ReadLine());

int billetes100 = 0, billetes50 = 0, billetes20 = 0, billetes10 = 0, billetes5 = 0;
int monedas1 = 0, monedas25 = 0, monedas1cent = 0;

if (cantidad % 1 != 0)
{
    int centavos = (int)Math.Round((cantidad % 1) * 100);

    monedas25 = centavos / 25;
    centavos -= monedas25 * 25;

    monedas1cent = centavos / 1;
    centavos -= monedas1cent;

    cantidad -= cantidad % 1;
}

int cantidadEntera = (int)cantidad;
int residuo = cantidadEntera;

billetes100 = residuo / 100;
residuo = residuo % 100;

billetes50 = residuo / 50;
residuo = residuo % 50;

billetes20 = residuo / 20;
residuo = residuo % 20;

billetes10 = residuo / 10;
residuo = residuo % 10;

billetes5 = residuo / 5;
residuo = residuo % 5;

monedas1 = residuo;

Console.WriteLine("Billetes de 100 quetzales: " + billetes100);
Console.WriteLine("Billetes de 50 quetzales: " + billetes50);
Console.WriteLine("Billetes de 20 quetzales: " + billetes20);
Console.WriteLine("Billetes de 10 quetzales: " + billetes10);
Console.WriteLine("Billetes de 5 quetzales: " + billetes5);
Console.WriteLine("Monedas de 1 quetzal: " + monedas1);

if (monedas25 > 0)
{
    Console.WriteLine("Monedas de 25 centavos: " + monedas25);
}

if (monedas1cent > 0)
{
    Console.WriteLine("Monedas de 1 centavo: " + monedas1cent);
}
