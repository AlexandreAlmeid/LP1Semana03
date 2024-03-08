using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks player = Perks.Stealth | Perks.AutoHeal | Perks.DoubleJump | Perks.WaterBreathing;
            int[] count = new int[4] {0,0,0,0};

            int flag = 0;

            Console.WriteLine("Insere uma combinação WASD: ");
            string str = Console.ReadLine();
            foreach(char c in str)
            {
                if(c == 'w' || c == 'W')
                {
                    count[0]++;
                }
                else if(c == 'a' || c == 'A')
                {
                    count[1]++;
                }
                else if(c == 's' || c == 'S')
                {
                    count[2]++;
                }
                else if(c == 'd' || c == 'D')
                {
                    count[3]++;
                }
                else
                {
                    Console.WriteLine("Unknown perk!");
                    flag = 1;
                    break;
                }
            }

            if(count[0] == 0 && count[1] == 0 && count[2] == 0 && count[3] == 0)
            {
                Console.WriteLine("No perks at all!");
            }
            else if(flag == 0)
            {    
                if(count[0] % 2 == 0)
                {
                    player &= ~Perks.WaterBreathing;
                }
                if(count[1] % 2 == 0)
                {
                    player &= ~Perks.AutoHeal;
                }
                if(count[2] % 2 == 0)
                {
                    player &= ~Perks.Stealth;
                }
                if(count[3] % 2 == 0)
                {
                    player &= ~Perks.DoubleJump;
                }
                Console.WriteLine(player);
                if ((player & Perks.AutoHeal) != Perks.AutoHeal)
                {
                    Console.WriteLine("Not gonna make it!");
                }
                if (((player & Perks.DoubleJump) == Perks.DoubleJump) && ((player & Perks.Stealth) == Perks.Stealth))
                {
                    Console.WriteLine("Silent Jumper!");
                }
            }
        }
    }
}
