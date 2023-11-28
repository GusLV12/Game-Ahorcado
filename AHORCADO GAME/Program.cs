using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "sol", "perro", "gato", "luna" };
            string opc = "";
            bool flag = true;

            Random random = new Random();
            Console.WriteLine("Juego del AHORCADO.");
            Console.WriteLine("1) 1 player?");
            Console.WriteLine("2) 2 players? ");
            opc = Console.ReadLine();
            Console.Clear();

            while (flag)
            {
                if (opc == "1")
                {
                    flag = false;
                    int random_num = random.Next(0, words.Length);
                    char[] letras = words[random_num].ToCharArray();
                    int word_length = letras.Length;
                    int[] flagLetras = new int[word_length];
                    int intentos = 6;

                    for (int i = 0; i < word_length; i++)
                    {
                        flagLetras[i] = 0;
                    }

                    bool game = true;

                    do
                    {
                        int letras_check = 0;
                        Console.WriteLine("Intentos restantes " + intentos);
                        for (int i = 0; i < word_length; i++)
                        {
                            if (flagLetras[i] == 0)
                            {
                                Console.Write(" _ ");
                            }
                            else
                            {
                                Console.Write(" " + letras[i] + " ");
                                letras_check++;
                            }
                        }

                        if (letras_check == word_length)
                        {
                            game = false;
                            Console.WriteLine("\nHAS GANADO!!! \n JUEGO TERMINADO.");
                        }
                        else
                        {
                            Console.WriteLine("\n\n Ingrese una letra:");
                            char ltr = Convert.ToChar(Console.ReadLine());
                            bool flagCheck = false;

                            for (int i = 0; i < word_length; i++)
                            {
                                if (ltr == letras[i])
                                {
                                    flagLetras[i] = 1;
                                    flagCheck = true;
                                }
                            }

                            if (flagCheck == false)
                            {
                                intentos--;
                            }

                            if (intentos == 0)
                            {
                                game = false;
                                Console.WriteLine("GAME OVER!!");
                            }
                        }
                    } while (game);
                }
                else if (opc == "2")
                {
                    flag = false;
                    Console.WriteLine("Ingrese una palabra para el jugador dos: ");
                    string word = Console.ReadLine();
                    Console.Clear();

                    char[] letras = word.ToCharArray();
                    int word_length = letras.Length;
                    int[] flagLetras = new int[word_length];
                    int intentos = 6;

                    for (int i = 0; i < word_length; i++)
                    {
                        flagLetras[i] = 0;
                    }

                    bool game = true;

                    do
                    {
                        int letras_check = 0;
                        Console.WriteLine("Intentos restantes " + intentos);
                        for (int i = 0; i < word_length; i++)
                        {
                            if (flagLetras[i] == 0)
                            {
                                Console.Write(" _ ");
                            }
                            else
                            {
                                Console.Write(" " + letras[i] + " ");
                                letras_check++;
                            }
                        }

                        if (letras_check == word_length)
                        {
                            game = false;
                            Console.WriteLine("\nJugador 2 has ganado!!!");
                        }
                        else
                        {
                            Console.WriteLine("\n\n Ingrese una letra:");
                            char ltr = Convert.ToChar(Console.ReadLine());
                            bool flagCheck = false;

                            for (int i = 0; i < word_length; i++)
                            {
                                if (ltr == letras[i])
                                {
                                    flagLetras[i] = 1;
                                    flagCheck = true;
                                }
                            }

                            if (flagCheck == false)
                            {
                                intentos--;
                            }

                            if (intentos == 0)
                            {
                                game = false;
                                Console.WriteLine("\nJugador 1 has ganado!!!");
                            }
                        }
                    } while (game);
                }
                else
                {
                    Console.WriteLine("Ingrese una opcion valida!!!");
                    break;
                }
            }
        }
    }
}
