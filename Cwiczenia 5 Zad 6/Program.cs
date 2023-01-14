namespace Cwiczenia_5_Zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, suma2 = 0;
            byte[,] liczby =
            {
                {1, 2, 3, 4, 4},
                {2, 2, 2, 2, 2},
                {2, 4, 100, 8, 1},
                {1, 3, 5, 7, 9},
                {9, 8, 7, 6, 5}
            };

            for (int i = 0; i <= 4; i++)
            {
                suma += liczby[i, i];
                suma2 += liczby[i, 4-i];
            }
            Console.WriteLine("Suma = " + suma + "\tSuma2 = " + suma2);
        }
    }
}