using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerramentaeChamados.ConsoleApp1
{

    internal class GerenciadorDeChamados
    {
        public static ArrayList nomesChamado = new ArrayList();
        public static ArrayList descricaoChamado = new ArrayList();
        public static ArrayList equipamento = new ArrayList();
        public static ArrayList datasChamado = new ArrayList();
        public static ArrayList idChamado = new ArrayList();
        public static ArrayList diasTotais = new ArrayList();
        


        public static void adicionarChamado()
        {
            Console.Clear();

            bool temFerramenta = Program.VerificarSeAhFerramentas();

            if (!temFerramenta)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhum Equipamento registrado");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                return;
            }

            Console.Write("\nQual o nome do chamado: ");
            nomesChamado.Add(Console.ReadLine());

            Console.Clear();

            Console.Write("\nQual a descricao do chamado: ");
            descricaoChamado.Add(Console.ReadLine());

            Console.Clear();

            GerenciadoDeEquipamento.mostrarFerramentas();

            Console.Write("\nQual o id do equipamento necessitando um chamado: \n");

            int idTroca = int.Parse(Console.ReadLine());

            int indexTroca = GerenciadoDeEquipamento.ids.IndexOf(idTroca);

            equipamento.Add(GerenciadoDeEquipamento.nomes[indexTroca]);

            Console.Clear();

            Console.Write("\nQual a data do chamado: ");
            datasChamado.Add(Console.ReadLine());

            idChamado.Add(idChamado.Count);

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Chamado adicionado com sucesso!");
            Console.ResetColor();
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

        public static void VerSeAhChamado()
        {
            bool temChamdo = Program.VerificarSeAhChamados();

            if (!temChamdo)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhum chamado adicionado!");
                Console.WriteLine("Aperte algo para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                return;
            }
            
        }

        public static void editarChamado()
        {
            Console.Clear();

            bool temChamdo = Program.VerificarSeAhChamados();

            if (!temChamdo)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhum chamado adicionado!");
                Console.WriteLine("Aperte algo para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                return;
            }

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

            bool temChamdo = Program.VerificarSeAhChamados();

            if (!temChamdo)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhum chamado adicionado!");
                Console.WriteLine("Aperte algo para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                return;
            }

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

            Console.Clear();

            bool temChamdo = Program.VerificarSeAhChamados();

            if (!temChamdo)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Nenhum chamado adicionado!");
                Console.WriteLine("Aperte algo para continuar");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                return;
            }


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

            Console.ReadLine();
            Console.Clear();


        }



    }
}
