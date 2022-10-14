//Variables
double dinero;
string moneda;

//creacion de lo que el programa te va a solicitar
Console.WriteLine("Ingrese la cantidad que desea convertir");
dinero = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("¿En que moneda esta la cantidad ingresada?");
Console.WriteLine("|dolares|libras|yenes|");
moneda = Console.ReadLine();
Console.WriteLine(ConversionMoneda(dinero, moneda));//llamamos a la funcion Conversion moneda y le pasamos los parametros

double ConversionMoneda(double dinero, string moneda)
{
    //lo divide en casos y va validando depende en que ingresas la moneda y realiza la conversion
    double ans;
    switch (moneda)
    {
        case "dolares":
            ans = (dinero * 0.75);
            return ans;
        case "libras":
            ans = (dinero * 1.22);
            return ans;
        case "yenes":
            ans = (dinero * 0.009);
            return ans;
        default:
            Console.WriteLine("No existe esa opción...");
            break;
    }
    return 0;
}