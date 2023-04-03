using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerramentaeChamados.ConsoleApp1
{

    internal class GerenciadorDeChamados
    {
        static ArrayList nomesChamado = new ArrayList();
        static ArrayList descricaoChamado = new ArrayList();
        static ArrayList equipamento = new ArrayList();
        static ArrayList datasChamado = new ArrayList();
        static ArrayList idChamado = new ArrayList();
        static ArrayList diasTotais = new ArrayList();


        public static void adicionarChamado()
        {
            Console.Clear();

            Console.Write("\nQual o nome do chamado: ");
            nomesChamado.Add(Console.ReadLine());

            Console.Write("\nQual a descricao do chamado: ");
            descricaoChamado.Add(Console.ReadLine());

            Console.Write("\nQual o equipamento necessitando um chamado: ");
            equipamento.Add(Console.ReadLine());

            Console.Write("\nQual a data do chamado: ");
            datasChamado.Add(Console.ReadLine());

            idChamado.Add(idChamado.Count);

            Console.WriteLine();
        }

        public static void PegarQuantiadedeDeDiasAberto()
        {

            DateTime dateTime = DateTime.Now;
            for (int i = 0; i < datasChamado.Count; i++)
            {

                string dataInicial = (string)datasChamado[i];
                string dataFinal = dateTime.ToString();

                TimeSpan date = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);

                int DiasTotais = date.Days;

                diasTotais.Add(DiasTotais);

            }

        }

        public static void editarChamado()
        {
            Console.Clear();

            Console.WriteLine("Qual o id do chamado que necessita edicao: ");
            int idTroca = int.Parse(Console.ReadLine());

            int indexTroca = idChamado.IndexOf(idTroca);

            Console.WriteLine("Qual o novo nome: ");
            nomesChamado[indexTroca] = Console.ReadLine();

            Console.WriteLine("Qual o novo equipamento: ");
            equipamento[indexTroca] = Console.ReadLine();

            Console.WriteLine("Qual a nova descricao: ");
            descricaoChamado[indexTroca] = Console.ReadLine();

            Console.WriteLine("Qual a nova data: ");
            datasChamado[indexTroca] = Console.ReadLine();

        }

        public static void excluirChamado()
        {
            Console.Clear();

            mostrarChamados();
            Console.WriteLine();


            Console.WriteLine("Qual o id do chamado que necessita ser excluido: ");
            int idexcluir = int.Parse(Console.ReadLine());

            int excluir = idChamado.IndexOf(idexcluir);

            nomesChamado.RemoveAt(excluir);
            descricaoChamado.RemoveAt(excluir);
            equipamento.RemoveAt(excluir);
            datasChamado.RemoveAt(excluir);
            idChamado.RemoveAt(excluir);
        }

        public static void mostrarChamados()
        {
            //Console.WriteLine("|       nomes        |       descricao       |       equipamento        |     datasChamado    |     id / totalDias   |");
            //Console.WriteLine("|--------------------|--------------------|--------------------|--------------------|--------------------|");

            //int count = nomesChamado.Count;

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"{nomesChamado[i],14}{descricaoChamado[i],18}{equipamento[i],20}{datasChamado[i],20}{idChamado[i],20}{diasTotais[i],20}");
            //}

            //for (int j = 0; j < 10 - count; j++)
            //{
            //    Console.WriteLine("|                    |                    |                    |                    |                    |                    |");
            //}

            //Console.WriteLine("\n");

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20} | {4, -10} | {5,-10}", "Nome", "descricaoChamado", "equipamento", "datasChamado", "diasTotais", "ID");
            Console.ResetColor();

            Console.WriteLine();

            for (int i = 0; i < nomesChamado.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("{0,-20} | {1,-20} | {2,-20} | {3,-20} | {4, -10} | {5,-10}", nomesChamado[i], descricaoChamado[i], equipamento[i], datasChamado[i], diasTotais[i], idChamado[i]);
            }
            Console.ResetColor();

            Console.WriteLine("\n\n\n");


        }



    }
}
