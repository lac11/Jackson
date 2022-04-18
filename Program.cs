using System;

namespace Jackson
{
    class Program
    {
        static void Main(string[] args)
        {
            void Walk(string[] jac, string space = "")
            {
                Console.Clear();
                for(int i = 0; i < jac.Length; i++)
                {
                    Console.WriteLine(space + jac[i]);
                }
                System.Threading.Thread.Sleep(110);
            }

            string[] jac = { "   O", "   |", "   |\\", "   | |", "  /|", "  \\|", "  =" };
            string[] jac1 = { "   O", "   |", "   |\\", "   | |", "  / \\", "  |  \\", "  =  =" };
            string[] jac2 = { "   O", "   |", "   |\\", "   | |", "  / \\", " |   \\", " =    =" };
            string[] jac3 = { "   O", "   |", "   |\\", "   | |", "  /|", " /  \\", "=    =" };
            string[] jac4 = { "   O", "   |", "   |\\", "   | |", "   |", "   |\\", "   = =" };

            string[] jacSpin = { " O", " |", " |", " |", " |", " |", " =" };
            string[] jacSpin1 = { " O", "/|", "\\|", " |", "/|", "||", "==" };
            string[] jacSpin2 = { "O ", "|\\ ", "|/", "| ", "|\\", "||", "=="};

            string[] jackBack = { "   O", "   |", "  /|", " | |", "   |\\", "   |/", "   =" };
            string[] jackBack1 = { "   O", "   |", "  /|", " | |", "  / \\", " /  |", " =  =" };
            string[] jackBack2 = { "   O", "   |", "  /|", " | |", "  / \\", " /   |", "=    =" };
            string[] jackBack3 = { "   O", "   |", "  /|", " | |", "   |\\", "  /  \\", " =    =" };
            string[] jackBack4 = { "   O", "   |", "  /|", " | |", "   |", "  /|", " = =" };

            string space = "";           
            while (true)
            {
                Start();
                Spin();
                Back();
                Spin();
            }

            void Start()
            {
                while (true)
                {
                    if (space.Length < 70)
                    {
                        Walk(jac, space += " ");
                        Walk(jac1, space += " ");
                        Walk(jac2, space += " ");
                        Walk(jac3, space += " ");
                        Walk(jac4, space += " ");
                    }
                    else
                    {
                        return;
                    }
                }
            }

            void Spin()
            {
                for (int j = 0; j < 2; j++)
                {
                    Walk(jacSpin, space);
                    Walk(jacSpin1, space);
                    Walk(jacSpin, space);
                    Walk(jacSpin2, space);
                }
            }
            
            void Back()
            {
                while (true)
                {
                    if (space.Length > 0)
                    {
                        Walk(jackBack, space = (space.Remove(space.Length - 1, 1)));
                        Walk(jackBack1, space = (space.Remove(space.Length - 1, 1)));
                        Walk(jackBack2, space = (space.Remove(space.Length - 1, 1)));
                        Walk(jackBack3, space = (space.Remove(space.Length - 1, 1)));
                        Walk(jackBack4, space = (space.Remove(space.Length - 1, 1)));
                    }
                    else
                        return;
                }
            }
        }
    }
}
