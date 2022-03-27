// See https://aka.ms/new-console-template for more information
string wpisz, wypisz;
char[] alfabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
Console.WriteLine("Wartowść przesunięcia");
int nowaPozycja = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("wpisz hasło do zaszyfrowania:");
wpisz = Convert.ToString(Console.ReadLine());
char[] zdanie = wpisz.ToCharArray();

char[] zaszyfrowane = new char[zdanie.Length];

for (int i = 0; i < zdanie.Length; i++)
{
    char litera = zdanie[i];
    if (zdanie[i] == ' ' || zdanie[i] == '\n') continue;
    int pozycja = Array.IndexOf(alfabet, litera);

    char literaZaszyfrowana;
    if (pozycja + nowaPozycja < alfabet.Length )
    {
        literaZaszyfrowana = alfabet[pozycja + nowaPozycja];

    } else {
        literaZaszyfrowana = alfabet[(pozycja + nowaPozycja) % alfabet.Length];
    }

    zaszyfrowane[i] = literaZaszyfrowana;
}

wypisz = string.Join("", zaszyfrowane);
Console.WriteLine(wypisz);
