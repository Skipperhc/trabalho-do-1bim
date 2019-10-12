//feito por vitor hainosz
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_do_leonel
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, quantidade, sairmesmo, excluir, numero_aleatorio;
            quantidade = 0;
            numero_aleatorio = -999;
            id = 0;
            Boolean sair = true;
            List<Pessoas> lista_de_pessoas = new List<Pessoas>();

            Console.WriteLine("CADASTRO DE PESSOA");
            do
            {
                Console.WriteLine($"" +
                    $"\n Digite uma das opções:  " +
                    $"\n 01 para Incluir  |  04 para Listar" +
                    $"\n 02 para Alterar  |  05 para Pesquisa" +
                    $"\n 03 para Excluir  |  06 para Sair");
                string opc = Console.ReadLine();

                switch (opc)
                {
                    case "01"://inserir
                        lista_de_pessoas.Insert(id, incluirpessoa());
                        id++;
                        quantidade++;
                        break;

                    case "02"://alterar
                        Console.WriteLine("digite o ID que deseja alterar");
                        int altID = Convert.ToInt32(Console.ReadLine());
                        Pessoas alt = lista_de_pessoas.Find(p => p.id == altID);
                        if (Convert.ToString(altID) != null)
                        {
                            Console.WriteLine($"ID: {alt.id} - Nome {alt.Nome} - Sobrenome {alt.sobrenome}  -  Email {alt.Email}\n");
                            Console.Write("ID: ");
                            alt.id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Nome: ");
                            alt.Nome = Console.ReadLine();
                            Console.Write("Sobrenome: ");
                            alt.sobrenome = Console.ReadLine();
                            Console.Write("Email: ");
                            alt.Email = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("ID Inexistente");
                            Console.ReadKey();
                        }
                        break;

                    case "03"://excluir
                        Console.WriteLine("digite o ID que deseja Excluir");
                        altID = Convert.ToInt32(Console.ReadLine());
                        alt = lista_de_pessoas.Find(p => p.id == altID);
                        if (Convert.ToString(altID) != null)
                        {
                            Console.WriteLine("tem certeza de que deseja Excluir?");
                            Console.WriteLine("01 - SIM");
                            Console.WriteLine("09 - NÂO");
                            excluir = Convert.ToInt32(Console.ReadLine());
                            if (excluir == 01)
                            {
                                
                                alt.id = numero_aleatorio;
                                alt.Nome = "X";
                                alt.sobrenome = "X";
                                alt.Email = "X";
                                quantidade--;
                                Console.WriteLine("ID zerado");
                                numero_aleatorio++;
                                Console.ReadKey();
                            }
                            else if (excluir == 09)
                            {}
                            else
                            {
                                Console.WriteLine("opção Inexistente");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("ID Inexistente");
                            Console.ReadLine();
                        }
                        break;

                    case "04"://listar
                        Console.WriteLine("\nID  |  Nome  | Sobrenome  |  Email \n");
                        for (int p = 0; p < lista_de_pessoas.Count; p++)
                        {
                            foreach (Pessoas pessoa in lista_de_pessoas)
                            {
                                Console.WriteLine($"{pessoa.id} | {pessoa.Nome} | {pessoa.sobrenome} | {pessoa.Email}");
                                p++;
                            }
                        }
                        Console.WriteLine("existe nesse momento " + quantidade + " IDs cadastrados");
                        Console.ReadKey();
                        break;

                    case "05"://Pesquisar
                        Console.WriteLine("escolha um campo que deseja pesquisar");
                        Console.WriteLine("01 - Nome | 02 - sobrenome | 03 - Email");
                        int esccampo = Convert.ToInt32(Console.ReadLine());

                        switch (esccampo)
                        {
                            case 01://nome
                                Console.WriteLine("digite o Nome que procura: ");
                                string pesq = Console.ReadLine();
                                alt = lista_de_pessoas.Find(p => p.Nome == pesq);
                                if (Convert.ToString(pesq) != null)
                                {
                                    Console.WriteLine($" \nID: {alt.id} \n Nome: {alt.Nome} \n Sobrenome: {alt.sobrenome} \n Email: {alt.Email}\n");
                                    Console.ReadLine();
                                }
                                break;

                            case 02://sobrenome
                                Console.WriteLine("digite o Sobrenome que procura: ");
                                pesq = Console.ReadLine();
                                alt = lista_de_pessoas.Find(p => p.sobrenome == pesq);
                                if (Convert.ToString(pesq) != null)
                                {
                                    Console.WriteLine($" \nID: {alt.id} \n Nome: {alt.Nome} \n Sobrenome: {alt.sobrenome} \n Email: {alt.Email}\n");
                                    Console.ReadLine();
                                }
                                break;

                            case 03:
                                Console.WriteLine("digite o Email que procura:");
                                pesq = Console.ReadLine();
                                alt = lista_de_pessoas.Find(p => p.Email == pesq);
                                if (Convert.ToString(pesq) != null)
                                {
                                    Console.WriteLine($" \nID: {alt.id} \n Nome: {alt.Nome} \n Sobrenome: {alt.sobrenome} \n Email: {alt.Email}\n");
                                    Console.ReadLine();
                                }
                                break;


                            default:
                                break;
                        }
                        break;

                    case "06"://Sair
                        Console.WriteLine("tem certeza de que deseja sair?");
                        Console.WriteLine("01 - SIM");
                        Console.WriteLine("09 - NÂO");
                        sairmesmo = Convert.ToInt32(Console.ReadLine());
                        if (sairmesmo == 01)
                        {
                            sair = false;
                            Console.WriteLine("SESSÃO ENCERRADA");
                            Console.ReadKey();
                        }
                        else if (sairmesmo == 09){}
                        else { Console.WriteLine("opção Inexistente"); }
                        break;

                    default:
                        Console.WriteLine("opção Inexistente");
                        Console.ReadKey();
                        break;
                }

            } while (sair);
        }
        private static Pessoas incluirpessoa()
        {
            Pessoas Pessoa = new Pessoas();
            Console.WriteLine("cadastro de pessoa: ");
            Console.Write("nome: ");
            Pessoa.Nome = Console.ReadLine();
            Console.Write("Sobrenome: ");
            Pessoa.sobrenome = Console.ReadLine();
            Console.Write("email: ");
            Pessoa.Email = Console.ReadLine();
            Console.Write("insira seu numero de identificação: ");
            Pessoa.id = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            return Pessoa;
        }
    }
}//feito por vitor hainosz