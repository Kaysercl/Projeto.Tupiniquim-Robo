using System;

namespace Projeto.Tupiniquim.ConsolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            while (opcao != "S")
            {
                Console.WriteLine("Bem-vindo ao projeto tupiniquim");
                Console.WriteLine("Primeiro vamos setar o espaço onde o robô vai andar");
                Console.WriteLine("Digite os valores do eixo X e do eixo Y respectivamente");
                Console.WriteLine("Exemplo: 1 1");


                string[] dimensoes = new string[2];
                dimensoes = Console.ReadLine().Split(' ');
                int x, y;
                x = Convert.ToInt32(dimensoes[0]);
                y = Convert.ToInt32(dimensoes[1]);
                int aux = x;
                int auy = y;


                Console.Clear();
                Console.WriteLine("Digite a posição inicial do robô");
                Console.WriteLine("Sendo X, Y coordenadas e N, S, L, O a direção do robô");
                Console.WriteLine("Exemplo 1 1 N");

                string[] strposicao = new string[3];
                strposicao = Console.ReadLine().Split(' ');
                int inicialx = Convert.ToInt32(strposicao[0]);
                int inicialy = Convert.ToInt32(strposicao[1]);
                string direcao = strposicao[2];
                Console.Clear();

                Console.WriteLine("E movimentar para a esquerda");
                Console.WriteLine("D movimentar para a direita");
                Console.WriteLine("M movimentar para a frente");

                string strmovimento = Console.ReadLine();
                char[] movimento = strmovimento.ToCharArray();

                for (int i = 0; i < movimento.Length; i++)
                {
                    if (direcao == "N" || direcao == "S" || direcao == "L" || direcao == "O")
                    {
                        if (movimento[i] == 'E')
                        {
                            if (direcao == "N")
                            {
                                direcao = "O";
                            }
                            else if (direcao == "L")
                            {
                                direcao = "N";
                            }
                            else if (direcao == "S")
                            {
                                direcao = "L";
                            }
                            else if (direcao == "O")
                            {
                                direcao = "S";
                            }
                        }


                        if (movimento[i] == 'D')
                        {
                            if (direcao == "N")
                            {
                                direcao = "L";
                            }
                            else if (direcao == "L")
                            {
                                direcao = "S";
                            }
                            else if (direcao == "S")
                            {
                                direcao = "O";
                            }
                            else if (direcao == "O")
                            {
                                direcao = "N";
                            }
                        }

                        if (movimento[i] == 'M')
                        {
                            if (direcao == "N")
                            {
                                if (inicialy == auy)
                                {
                                    inicialy = inicialy + 0;
                                }
                                else
                                {
                                    inicialy = inicialy + 1;
                                }

                            }

                            else if (direcao == "L")
                            {
                                if (inicialx == aux)
                                {
                                    inicialx = inicialx + 0;
                                }
                                else
                                {
                                    inicialx = inicialx + 1;
                                }
                            }

                            else if (direcao == "S")
                            {
                                if (inicialy >= auy)
                                {
                                    inicialy = inicialy + 0;
                                }
                                else
                                {
                                    inicialy = inicialy - 1;
                                }
                            }

                            else if (direcao == "O")
                                if (inicialx >= aux)
                                {
                                    inicialx = inicialx + 0;
                                }
                                else
                                {
                                    inicialx = inicialx - 1;
                                }
                        }
                    }

                }


                Console.WriteLine(inicialx + " " + inicialy + " " + direcao);

                Console.WriteLine("Digite a posição inicial do robô");
                Console.WriteLine("Sendo X, Y coordenadas e N, S, L, O a direção do robô");
                Console.WriteLine("Exemplo 1 1 N");

                string[] strposicao2 = new string[3];
                strposicao = Console.ReadLine().Split(' ');
                int inicial2x = Convert.ToInt32(strposicao[0]);
                int inicial2y = Convert.ToInt32(strposicao[1]);
                string direcao2 = strposicao[2];
                Console.Clear();

                Console.WriteLine("E movimentar para a esquerda");
                Console.WriteLine("D movimentar para a direita");
                Console.WriteLine("M movimentar para a frente");

                string strmovimento2 = Console.ReadLine();
                char[] movimento2 = strmovimento2.ToCharArray();

                for (int i = 0; i < movimento.Length; i++)
                {
                    if (direcao == "N" || direcao == "S" || direcao == "L" || direcao == "O")
                    {
                        if (movimento2[i] == 'E')
                        {
                            if (direcao2 == "N")
                            {
                                direcao2 = "O";
                            }
                            else if (direcao2 == "L")
                            {
                                direcao2 = "N";
                            }
                            else if (direcao2 == "S")
                            {
                                direcao2 = "L";
                            }
                            else if (direcao2 == "O")
                            {
                                direcao2 = "S";
                            }
                        }


                        if (movimento2[i] == 'D')
                        {
                            if (direcao2 == "N")
                            {
                                direcao2 = "L";
                            }
                            else if (direcao2 == "L")
                            {
                                direcao2 = "S";
                            }
                            else if (direcao2 == "S")
                            {
                                direcao2 = "O";
                            }
                            else if (direcao2 == "O")
                            {
                                direcao2 = "N";
                            }
                        }

                        if (movimento2[i] == 'M')
                        {
                            if (direcao2 == "N")
                            {
                                if (inicial2y == auy)
                                {
                                    inicial2y = inicial2y + 0;
                                }
                                else
                                {
                                    inicial2y = inicial2y + 1;
                                }

                            }

                            else if (direcao2 == "L")
                            {
                                if (inicial2x == aux)
                                {
                                    inicial2x = inicial2x + 0;
                                }
                                else
                                {
                                    inicial2x = inicial2x + 1;
                                }
                            }

                            else if (direcao2 == "S")
                            {
                                if (inicial2y >= auy)
                                {
                                    inicial2y = inicial2y + 0;
                                }
                                else
                                {
                                    inicial2y = inicial2y - 1;
                                }
                            }

                            else if (direcao2 == "O")
                                if (inicial2x >= aux)
                                {
                                    inicial2x = inicial2x + 0;
                                }
                                else
                                {
                                    inicial2x = inicial2x - 1;

                                }
                        }
                    }

                }

                Console.WriteLine(inicial2x + " " + inicial2y + " " + direcao2);
            }
        }
    }
    
}
