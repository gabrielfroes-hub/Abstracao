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




            Console.ReadKey();
        }
    }
}
