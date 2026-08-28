
namespace Abstracao
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int ano;
        public string cor;

        public void exibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}");
            Console.WriteLine($"Cor: {cor}, Ano: {ano}");
            Console.WriteLine("-----------------");
        }
    }
}
