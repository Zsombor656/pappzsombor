namespace felezo_maximum_kiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rendezettTomb = { 99,1, 3, 5, 8, 11, 22,33 };
            Console.WriteLine(rendezettTomb[FelelzoMaximum(rendezettTomb, 0, rendezettTomb.Length-1)]);

        }
        public static int FelelzoMaximum(int[] Szamok, int bal, int jobb)
        {
            if (bal == jobb)
            {
                return bal;
            }
            else
            {
                int kozepsoErtek = (bal + jobb) / 2;
                int balmax = FelelzoMaximum(szamok, bal, kozepsoErtek);
                int jobbmax = FelelzoMaximum(szamok, kozepsoErtek + 1, jobb);
                if (Szamok[balmax] >= Szamok[jobbmax])
                {
                    return balmax;
                }
                else
                {
                    return jobbmax;
                }
            }
        }
    }
}
