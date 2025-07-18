double potenz = 0;
double potenzzaehler = 0;
double n;
double k;

System.Console.Write("Gebe N ein: ");
n = Int32.Parse(Console.ReadLine());

while (potenz * 2 <= n)
{
    potenz = Math.Pow(2, potenzzaehler);
    potenzzaehler++;
}
double z = n - potenz;

k = 1 + 2 * z;
System.Console.WriteLine($"K: {k}");