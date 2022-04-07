using Geometria;

Console.WriteLine("Inserisci base del rettangolo");
int baseInputUtente = int.Parse(Console.ReadLine());


Console.WriteLine("Inserisci altezza del rettangolo");
int altezzaInputUtente = int.Parse(Console.ReadLine());

rettangolo rettangolo1 = new rettangolo(baseInputUtente, altezzaInputUtente);

Console.WriteLine("Area:" + rettangolo1.calcoloArea());

}