using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerramentaeChamados.ConsoleApp1
{
    public class GerenciadoDeEquipamento
    {

        public static ArrayList nomes = new ArrayList();
        public static ArrayList precos = new ArrayList();
        public static ArrayList ids = new ArrayList();
        public static ArrayList datas = new ArrayList();
        public static ArrayList fabricantes = new ArrayList();


        public static void PegarInformacoesFerramenta()
        {
            Console.Clear();

            string nomeAdicionar = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Qual o nome da ferramenta: ");
                nomeAdicionar = Console.ReadLine();


                if (nomeAdicionar.Length < 6)
                {
                    Console.WriteLine("Nome deve ter no minimo 6 caracteres\nAperte algo para continuar");
                    Console.ReadLine();
                }

            } while (nomeAdicionar.Length < 6);

            nomes.Add(nomeAdicionar);

            Console.WriteLine("Qual o preco da ferramenta: ");
            int valor = int.Parse(Console.ReadLine());
            precos.Add(valor);
            
            ids.Add(ids.Count);

            Console.WriteLine("Qual a data de fabricacao: ");
            datas.Add(Console.ReadLine());

            Console.WriteLine("Qual o fabricante: ");
            fabricantes.Add(Console.ReadLine());



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ferramenta adicionada com sucesso!");
            Console.ResetColor();

            Console.ReadLine();
            Console.Clear();


            //nomes.Add("Ferro");
            //nomes.Add("Machado");

            //precos.Add(100);
            //precos.Add(200);

            //ids.Add(342);
            //ids.Add(0);

            //datas.Add("12/12/12");
            //datas.Add("1/1/1");

            //fabricantes.Add("esse");
            //fabricantes.Add("moto");
        }

        public static void editarFerramenta()
        {
            Console.Clear();
            GerenciadoDeEquipamento.mostrarFerramentas();

            bool temChamado = Program.VerificarSeAhFerramentas();

            if (!temChamado)
            {
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhum Equipamento registrado");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                return;
            }

            Console.Write("Qual o id da ferramenta deseja editar: ");
            int editarFerramentaNumero = int.Parse(Console.ReadLine());

            int NumeroTrocar = ids.IndexOf(editarFerramentaNumero);

            string nomeTrocar = "";

            do
            {
                Console.Write("\nQual o nome da ferramenta: ");
                nomeTrocar = Console.ReadLine();

                if (nomeTrocar.Length < 6)
                {
                    Console.WriteLine("Nome deve ter mais de 6 caracteres");
                    Console.ReadLine();
                }

            } while (nomeTrocar.Length < 6);

            nomes[NumeroTrocar] = nomeTrocar;

            Console.Write("\nQual o preco da ferramenta: ");
            precos[NumeroTrocar] = int.Parse(Console.ReadLine());

            Console.Write("\nQual a data: ");
            datas[NumeroTrocar] = Console.ReadLine();

            Console.Write("\nQual o nome do fabricante: ");
            fabricantes[NumeroTrocar] = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ferramenta editada com sucesso!");
            Console.ResetColor();

            Console.ReadLine();
            Console.Clear();
        }

        public static void excluirFerramenta()
        {
            Console.Clear();

            bool temChamado = Program.VerificarSeAhFerramentas();

            if (!temChamado)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhum Equipamento registrado");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                return;
            }

            GerenciadoDeEquipamento.mostrarFerramentas();

            Console.Write("Qual o id da ferramenta deseja excluir: ");
            int excluirFerramenta = int.Parse(Console.ReadLine());

            int excluir = ids.IndexOf(excluirFerramenta);

            nomes.RemoveAt(excluir);
            precos.RemoveAt(excluir);
            ids.RemoveAt(excluir);
            datas.RemoveAt(excluir);
            fabricantes.RemoveAt(excluir);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ferramenta excluida com sucesso!");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

        }

        public static void mostrarFerramentas()
        {

            bool temChamado = Program.VerificarSeAhFerramentas();

            if (!temChamado)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhum Equipamento registrado");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                return;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4, -10}", "Nome", "Preco", "Data", "Fabricante", "Id");
            Console.ResetColor();

            Console.WriteLine();

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4, -10}", nomes[i], precos[i], datas[i], fabricantes[i], ids[i]);
            }
            Console.ResetColor();

            Console.WriteLine("\n\n\n");


        }
    }
}
