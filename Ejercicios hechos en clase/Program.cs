//PRIMER EJERCICIO
int año = int.Parse("2004");
if (año >= 1928 && año <= 1945)
{
    Console.WriteLine("Usted pertenece a la generación silenciosa");
}
else if (año >= 1946 && año <= 1964)
{
    Console.WriteLine("Usted pertenece a la generación baby boomer");
}
else if (año >= 1965 && año <= 1980)
{
    Console.WriteLine("Usted pertenece a la generación X");
}
else if (año >= 1981 && año <= 1996)
{
    Console.WriteLine("Usted pertenece a la generación de los millennials");
}
else if (año >= 1997 && año <= 2012)
{
    Console.WriteLine("Usted pertenece a la generacion Z");
}
else if (año >= 2013)
{
    Console.WriteLine("Usted pertenece a la generación Alfa");
}
else
{
    Console.WriteLine("Año invalido");
}

//EJERCICIO 2
string nombre, pais;
int edad;
char genero;

Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine().ToUpper();//Convierte en mayusculas

Console.WriteLine("Ingrese su pais");
pais = Console.ReadLine();

Console.WriteLine("Ingrese su edad");
edad = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingrese su genero (m o f)");
genero = char.Parse(Console.ReadLine().ToUpper());

if (!nombre.StartsWith("A") && (edad >= 18 || genero == 'F')
    && (pais == "GUATEMALA " || pais == "MEXICO"))
{
    Console.WriteLine("Ud. cumple ls requisitos");
}
else
{
    Console.WriteLine("no admitido");
}