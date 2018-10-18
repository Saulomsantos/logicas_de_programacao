using System;
using Senai.OO.Array.Exercicio3Fernando.Classe;

namespace Senai.OO.Array.Exercicio3Fernando
{
    class Program
    {
        static Usuario[] arrayUsuario;
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe a quantidade de cadastros");
            int quantMaximaUsuarios = int.Parse(Console.ReadLine());

            arrayUsuario = new Usuario[quantMaximaUsuarios];
            int opcao = 0;
            int contador = 0;

            //Fica no laço do menu de opções
            do
            {
                MostrarMenu();
                //Pega do usuário a opção do menu
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    {
                        if (contador < quantMaximaUsuarios)
                        {
                            //Instancio o meu objeto Usuário no índice do contador
                            arrayUsuario[contador] = new Usuario();

                            #region Email
                            bool emailValido = false;
                            do
                            {
                                System.Console.WriteLine("Informe seu e-mail");
                                string email = Console.ReadLine();
                                
                                if (email.Contains("@"))
                                {
                                    emailValido = true;
                                    arrayUsuario[contador].Email = email;
                                }
                                else
                                {
                                    System.Console.WriteLine("E-mail inválido");
                                }
                                
                            } while (!emailValido); //é o mesmo que escrever 'emailValido == false'
                            #endregion

                            #region Senha
                            bool senhaValida = false;
                            do
                            {
                                System.Console.WriteLine("Informe sua senha");
                                string senha = Console.ReadLine();
                                
                                if (senha.Length >= 4)
                                {
                                    senhaValida = true;
                                    arrayUsuario[contador].Senha = senha;
                                }
                                else
                                {
                                    System.Console.WriteLine("Senha inválida");
                                }
                                
                            } while (!senhaValida); //é o mesmo que escrever 'senhaValida == false'
                            #endregion

                            #region Nome
                            System.Console.WriteLine("Informe seu nome");
                            arrayUsuario[contador].Nome = Console.ReadLine();
                            #endregion

                            System.Console.WriteLine("Usuário cadastrado!");

                            contador++;
                        }
                        else
                        {
                            System.Console.WriteLine("Número máximo de usuários atingido");
                        }
                        break;
                    }
                    case 2:
                    {
                        ListarUsuarios();
                        break;
                    }
                    case 3:
                    {
                        string email;
                        string senha;
                        #region Email
                            bool emailValido = false;
                            do
                            {
                                System.Console.WriteLine("Informe seu e-mail");
                                string email = Console.ReadLine();
                                
                                if (email.Contains("@"))
                                {
                                    emailValido = true;
                                    arrayUsuario[contador].Email = email;
                                }
                                else
                                {
                                    System.Console.WriteLine("E-mail inválido");
                                }
                                
                            } while (!emailValido); //é o mesmo que escrever 'emailValido == false'
                            #endregion
                        #region Senha
                            bool senhaValida = false;
                            do
                            {
                                System.Console.WriteLine("Informe sua senha");
                                string senha = Console.ReadLine();
                                
                                if (senha.Length >= 4)
                                {
                                    senhaValida = true;
                                    arrayUsuario[contador].Senha = senha;
                                }
                                else
                                {
                                    System.Console.WriteLine("Senha inválida");
                                }
                                
                            } while (!senhaValida); //é o mesmo que escrever 'senhaValida == false'
                            #endregion
                        ValidaEmailSenha(email,senha);
                        break;
                    }
                    case 0:
                    {
                        System.Console.WriteLine("Volte sempre!");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Opção inválida");
                        break;
                    }
                }
                
            } while (opcao != 0);
        }

        /// <summary>
        /// Monta a estrutura do menu
        /// </summary>
        static void MostrarMenu()
        {
            System.Console.WriteLine("Menu de opções");
            System.Console.WriteLine("1 - Cadastrar novo usuário");
            System.Console.WriteLine("2 - Listar usuários");
            System.Console.WriteLine("3 - Acessar sistema");
            System.Console.WriteLine("0 - Sair");
        }

        /// <summary>
        /// Lista todos os usuários cadastrados
        /// </summary>
        static void ListarUsuarios()
        { 
            foreach (Usuario item in arrayUsuario)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"{item.Nome} - {item.Email}");
                }
            }
        }

        static void ValidaEmailSenha(string email, string senha)
        {
            bool encontrado = false;
            foreach (Usuario item in arrayUsuario)
            {
                if (item != null)
                {
                    if (item.Email == email && item.Senha == senha)
                    {
                        System.Console.WriteLine("Acesso Liberado");
                        encontrado = true;
                        break;
                    }
                    if (!encontrado)
                    {
                        System.Console.WriteLine("Acesso não autorizado");
                    }
                }
            }
        }
    }
}
