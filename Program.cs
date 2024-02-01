using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crie uma sistema para uma escola. O sistema deve ajudar a secretaria a cadastrar
            e alterar as notas de um aluno.O sistema deve ter as seguintes funcionalidades:
            1 - Adicionar um aluno
            2 - Acessar o perfil de um aluno
            3 - No perfil do aluno, a opção de inserir notas e verificar a media final do 
            aluno se possível.Deve ser possível inserir até 4 notas para o aluno.
            
            O sistema deve possuir um menu que mostre as opções:
            1 - Adicionar Aluno
            2 - Lista de Alunos
            3 - Sair  */

            const int QUANTIDADE_ALUNOS = 2;

            string[] aluno = new string[QUANTIDADE_ALUNOS];
            int[] idade = new int[aluno.Length];
            string[] sexo = new string[aluno.Length];
            decimal[] nota1 = new decimal[aluno.Length];
            decimal[] nota2 = new decimal[aluno.Length];
            decimal[] nota3 = new decimal[aluno.Length];
            decimal[] nota4 = new decimal[aluno.Length];

            int index = 1;
            int menu = 0;
            int perfil_aluno = 0;
          

            Console.WriteLine(" Bem vindo ao menu da escola");
            Console.WriteLine(" 1 - Adicionar aluno.");
            Console.WriteLine(" 2 - Lista de alunos.");
            Console.WriteLine(" 3 - Sair.");
            Console.WriteLine(" ");
            Console.Write("Digite a opção desejada: ");
            menu = int.Parse(Console.ReadLine());
            Console.Clear();



            while (menu != 3)
            {
                if (menu == 0)

                {
                    Console.WriteLine(" Bem vindo ao menu da escola");
                    Console.WriteLine(" 1 - Adicionar aluno.");
                    Console.WriteLine(" 2 - Lista de alunos.");
                    Console.WriteLine(" 3 - Sair.");
                    Console.WriteLine(" ");
                    Console.Write("Digite a opção desejada: ");
                    menu = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                if (menu == 1)
                {
                   
                    Console.WriteLine("...: MENU ADICIONAR ALUNOS :...");
                    Console.WriteLine("Qual o nome do aluno?");
                    aluno[(index - 1)] = Console.ReadLine();

                    Console.WriteLine("Qual a idade do aluno?");
                    idade[(index - 1)] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o sexo do aluno? (M/F): ");
                    sexo[(index - 1)] = Console.ReadLine();
                    index++;
                    Console.Clear();

                    Console.WriteLine("Deseja adicionar mais alunos? (S/N)");
                    string add_alunos = Console.ReadLine();
                    if (add_alunos == "S")
                    {
                        menu = 1;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        menu = 0;
                    }
                }

                if (menu == 2)
                {
                    Console.WriteLine("...: MENU LISTA DE ALUNOS :...");

                    for (int pos_aluno = 0; pos_aluno < aluno.Length; pos_aluno++)
                    {
                        if (aluno[pos_aluno] == null)
                        {
                            continue;
                        }

                        Console.WriteLine($"{pos_aluno + 1} -  {aluno[pos_aluno]}");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("Digite código do aluno para acessar seu perfil. ");
                    Console.WriteLine("99 - Voltar ao menu inicial.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite a opção desejada: ");
                    int opcao_0 = int.Parse(Console.ReadLine());

                    if (opcao_0 != 99)
                    {
                        perfil_aluno = opcao_0;
                        menu = 4;
                        Console.Clear();
                    }
                    else if (opcao_0 == 99)
                    {
                        menu = 0;
                        Console.Clear();
                    }
                }
                
                if (menu == 4)
                {
                    Console.WriteLine("...: PERFIL DO ALUNO :...");
                    Console.WriteLine($"Nome do aluno: {aluno[perfil_aluno - 1]}");
                    Console.WriteLine($"Idade do aluno: {idade[perfil_aluno - 1]} anos");
                    Console.WriteLine($"Sexo do aluno: {sexo[perfil_aluno - 1]}");
                    Console.WriteLine(" ");

                    // Mostra as notas do aluno
                    if (nota1[(perfil_aluno - 1)] == 0)
                    {
                        Console.WriteLine($"A NOTA 1 do aluno é: N/A");
                    }
                    else
                    Console.WriteLine($"A NOTA 1 do aluno é: {nota1[(perfil_aluno - 1)]}");

                    if (nota2[(perfil_aluno - 1)] == 0)
                    {
                        Console.WriteLine($"A NOTA 2 do aluno é: N/A"); ;
                    }
                    else
                    Console.WriteLine($"A NOTA 2 do aluno é: {nota2[(perfil_aluno - 1)]}");


                    if (nota3[(perfil_aluno - 1)] == 0)
                    {
                        Console.WriteLine($"A NOTA 3 do aluno é: N/A");
                    }
                    else
                        Console.WriteLine($"A NOTA 3 do aluno é: {nota3[(perfil_aluno - 1)]}");

                    if (nota4[(perfil_aluno - 1)] == 0)
                    {
                        Console.WriteLine($"A NOTA 4 do aluno é: N/A");
                    }
                    else
                        Console.WriteLine($"A NOTA 4 do aluno é: {nota4[(perfil_aluno-1)]}");


                    Console.WriteLine(" ");
                    Console.WriteLine("1 - Adicionar notas");
                    Console.WriteLine("2 - Voltar ao menu inicial");
                    Console.WriteLine(" ");
                    Console.Write("Digite a opção desejada: ");
                    int opcao_1 = int.Parse(Console.ReadLine());

                    if (opcao_1 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("...: ADICIONAR NOTAS :...");
                        Console.WriteLine($"Nome do aluno: {aluno[perfil_aluno - 1]}");
                        Console.Write("Digite a NOTA 1 do aluno: ");
                        nota1[(perfil_aluno - 1)] = decimal.Parse(Console.ReadLine());

                        Console.Write("Digite a NOTA 2 do aluno: ");
                        nota2[(perfil_aluno - 1)] = decimal.Parse(Console.ReadLine());

                        Console.Write("Digite a NOTA 3 do aluno: ");
                        nota3[(perfil_aluno - 1)] = decimal.Parse(Console.ReadLine());

                        Console.Write("Digite a NOTA 4 do aluno: ");
                        nota4[(perfil_aluno - 1)] = decimal.Parse(Console.ReadLine());

                        Console.Clear();
                    }
                    else if (opcao_1 == 2)
                    {
                        menu = 0;
                        Console.Clear();
                    }
                } 
                    
            }
        }
    }               
}
