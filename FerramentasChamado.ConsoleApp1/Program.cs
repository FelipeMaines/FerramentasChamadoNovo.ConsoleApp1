
using FerramentaeChamados.ConsoleApp1;
using System.Collections;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace FerramentaeChamados.ConsoleApp1
{
    internal class Program
{
        #region 
        static int numero = 1;




        #endregion
        private static void MostrarMenuPrincipal()
        {
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("(1) Ferramentas\n(2) Chamados\n(0) Sair!");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        opcaoFerramenta();
                        break;

                    case 2:
                        opcaoChamado();
                        break;
                }

            } while (opcao != 0);
        }
        static void opcaoFerramenta()
        {
            Console.Clear();

            do
            {
                Console.WriteLine($"(1) Adicionar Ferramenta\n(2) Editar Ferramenta\n(3) Excluir Ferramenta\n(4) Mostrar Ferramenta\n(0)Para sair!");
                numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        GerenciadoDeEquipamento.PegarInformacoesFerramenta();
                        break;

                    case 2:
                        GerenciadoDeEquipamento.editarFerramenta();
                        break;

                    case 3:
                        GerenciadoDeEquipamento.excluirFerramenta();
                        break;

                    case 4:
                        GerenciadoDeEquipamento.mostrarFerramentas();
                        break;

                }
            } while (numero != 0);

        }
        static void opcaoChamado()
        {
            Console.Clear();

            do
            {
                Console.WriteLine($"(1) Adicionar Chamado\n(2) Mostrar Chamados\n(3) Editar Chamados\n(4) Excluir Chamados\n(0)Para sair!");
                numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        GerenciadorDeChamados.adicionarChamado();
                        break;

                    case 2:
                        GerenciadorDeChamados.PegarQuantiadedeDeDiasAberto();
                        GerenciadorDeChamados.mostrarChamados();
                        break;

                    case 3:
                        GerenciadorDeChamados.editarChamado();
                        break;

                    case 4:
                        GerenciadorDeChamados.excluirChamado();
                        break;

                }
            } while (numero != 0);
        }
        static void Main(string[] args)
        {
            MostrarMenuPrincipal();
        }

    }
}