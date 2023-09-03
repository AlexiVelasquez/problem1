// See https://aka.ms/new-console-template for more information

Console.WriteLine("Escoja el tipo´de fruta:   ");
Console.WriteLine("***************************");
Console.WriteLine("1: Naranja:        ");
Console.WriteLine("2: Fresa:          ");
Console.WriteLine("3: Mango:          ");
int fruta = int.Parse(Console.ReadLine());

Console.WriteLine("Cuanto fue los kilometros recorridos?:");
float kilometro=float.Parse(Console.ReadLine());

switch (fruta)
{
    case 1:
        if (kilometro < 30)
        {
            fruta = 2;
        }
        else
        {
            fruta = 4;

        }
        break;
    case 2:
        if (kilometro <30)
        {
            fruta = 6;
        }
        else
        {
            fruta = 9;
        }
        break;
    case 3:
        if (kilometro < 30)
        {
            fruta = 3;
        }
        else
        {
            fruta = 5;
        }
        break;
    default:
        Console.WriteLine("Tiene que escoger una de las frutas :C");
        break;

}
Console.WriteLine("Usted estaria pagando:"+fruta+"$"+":D");

