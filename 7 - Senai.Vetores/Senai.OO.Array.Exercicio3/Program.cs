using System;
using Senai.OO.Array.Exercicio3.Classes;

namespace Senai.OO.Array.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntCadastros;
            int opcao;

            System.Console.WriteLine("Informe a quantidade de cadastros");
            qntCadastros = int.Parse(Console.ReadLine());

            Usuario[] usuarios = new Usuario[qntCadastros];

            do
            {
                System.Console.WriteLine("\nEscolha a opção desejada");
                System.Console.WriteLine("1 - Menu de cadastro");
                System.Console.WriteLine("2 - Exibir usuários cadastrados");
                System.Console.WriteLine("3 - Acessar sistema");
                System.Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                    {
                        for (int i = 0; i < qntCadastros; i++)
                        {
                            usuarios[i] = new Usuario();

                            usuarios[i].ReceberDados();
                        }
                        break;
                    }

                    case 2:
                    {
                        System.Console.WriteLine("");
                        for (int c = 0; c < qntCadastros; c++)
                        {
                            System.Console.WriteLine($"{c+1} - {usuarios[c].Nome} | {usuarios[c].Email}");
                        }
                        break;
                    }

                    case 3:
                    {
                        System.Console.WriteLine("Informe o e-mail de acesso");
                        string login = Console.ReadLine();
                        
                        for (int c = 0; c < qntCadastros; c++)
                        {
                            if (login == usuarios[c].Email)
                            {
                                System.Console.WriteLine("Informe a senha de acesso");
                                string senhaAcesso = Console.ReadLine();
                                if (senhaAcesso == usuarios[c].Senha)
                                {
                                    System.Console.WriteLine("Acesso liberado!");
                                }
                                else
                                {
                                    System.Console.WriteLine("Senha inválida!");
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("E-mail inválido!");
                            }
                        }
                        break;
                    }

                    case 0:
                    {
                        break;
                    }
                    
                    default:
                    {
                        System.Console.WriteLine("Opção inválida. Tente novamente");
                        break;
                    }
                }

            } while (opcao != 0);
        }
    }
}
