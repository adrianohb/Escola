using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

            string[] aluno = new string[4];
            int[] idade = new int[aluno.Length];
            string[] sexo = new string[aluno.Length];

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

                { Console.WriteLine(" Bem vindo ao menu da escola");
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

                    /* for (int pos_aluno = 0; pos_aluno <= aluno.Length; pos_aluno++)
                     {
                         Console.WriteLine($"{pos_aluno + 1} -  {aluno[pos_aluno]}");
                     }
                    */

                    Console.WriteLine(aluno[0]);
                    Console.WriteLine(aluno[1]);

                    Console.WriteLine("Qual aluno deseja acessar?");
                    perfil_aluno = int.Parse(Console.ReadLine());
                    menu = 4;
                }

                if (menu == 4)
                {
                    Console.WriteLine("...: PERFIL DO ALUNO :...");
                    // int perfil_atual = 0;
                    Console.WriteLine(aluno[perfil_aluno - 1]);
                    Console.WriteLine(idade[perfil_aluno - 1]);
                    Console.WriteLine(sexo[perfil_aluno - 1]);
                    
                }


            }

        }

    


    }               
}
