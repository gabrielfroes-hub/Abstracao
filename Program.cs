using System.Timers;

namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CRIANDO UM OBJETO (INSTANCIAÇÃO)
            Carro meuFusca = new Carro();

            meuFusca.Marca = "Volkswagen";
            meuFusca.Modelo = "Fusca";
            meuFusca.ano = 1975;
            meuFusca.cor = "Azul";

            Carro carroVizinho = new Carro();

            carroVizinho.Marca = "Chevrolet";
            carroVizinho.Modelo = "Corsa";
            carroVizinho.ano = 2005;
            carroVizinho.cor = "Prata";

            Console.WriteLine("Informações do meu carro:");
            meuFusca.exibirInformacoes();

            Console.WriteLine("Informações do carro do vizinho");
            carroVizinho.exibirInformacoes();

            // EXERCÍCIO 1
            Produto produto = new Produto();

            produto.Nome = "Notebook";
            produto.Preco = 3500.00;
            produto.Quantidadeemestoque = 10;

            Console.WriteLine("Produtos");
            produto.ExibirInformacoes();

            // EXERCÍCIO 2
            Aluno Informacoesaluno = new Aluno();

            Informacoesaluno.nome = "João";
            Informacoesaluno.matricula = "123456";
            Informacoesaluno.Nota1 = 8;
            Informacoesaluno.Nota2 = 7;


            Console.WriteLine("Informações do aluno");
            Informacoesaluno.exibirInformacoes();

            // EXERCÍCIO 3
            ContaBancaria conta = new ContaBancaria();

            conta.Titular = "Froés";
            conta.NumeroConta = "25";
            conta.Saldo = 750;

            Console.WriteLine("Informações da conta bancaria:");
            conta.ExibirInformacoesContaBancaria1();
            conta.Depositar(500);
            conta.ExibirInformacoesContaBancaria2();
            conta.Sacar(300);
            conta.ExibirInformacoesContaBancaria3();


            // EXERCÍCIO 4 

            Time time = new Time();

            time.NomeDoTime = "Xuripitas FC";

            Jogador jogador1 = new Jogador();

            jogador1.Nome = "Gabriel Fróes";
            jogador1.Posicao = "Volante";
            jogador1.NumeroCamisa = 8;

            Jogador jogador2 = new Jogador();

            jogador2.Nome = "Neymar";
            jogador2.Posicao = "Ponta";
            jogador2.NumeroCamisa = 10;

            Jogador jogador3 = new Jogador();

            jogador3.Nome = "Murilo";
            jogador3.Posicao = "Atacante";
            jogador3.NumeroCamisa = 9;

            time.AdicionarJogador(jogador1);
            time.AdicionarJogador(jogador2);
            time.AdicionarJogador(jogador3);

            time.ListarJogadores();
            Console.WriteLine("--------------------------------------");

            Console.ReadKey();
        }
    }
}
