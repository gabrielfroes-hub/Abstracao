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
            meuFusca.Ano = 1975;
            meuFusca.Cor = "Azul";

            Carro carroVizinho = new Carro();

            carroVizinho.Marca = "Chevrolet";
            carroVizinho.Modelo = "Corsa";
            carroVizinho.Ano = 2005;
            carroVizinho.Cor = "Prata";

            Console.WriteLine("Informações do meu carro:");
            meuFusca.ExibirInformacoes();

            Console.WriteLine("Informações do carro do vizinho");
            carroVizinho.ExibirInformacoes();

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
            conta.Titular = "Maria";
            conta.saldo = 1000.00;
            conta.Numeroconta = 12345;
            conta = new Contabancaria();
            conta.depositar(1000.00);
            conta.sacar(500.00);

            Console.WriteLine("Informações da conta");
            conta.exibirInformacoes();

            // EXERCÍCIO 4 


            Console.ReadKey();
        }
    }
}
