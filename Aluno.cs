namespace Abstracao
{
    internal class Aluno
    {
        public string nome;
        public string matricula;
        public int Nota1;
        public int Nota2;
        double media;
        public double calcularMedia()
        {
            media = (Nota1 + Nota2) / 2.0;
            return media;
        }

        public void exibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Matrícula: {matricula}");
            Console.WriteLine($"Nota 1: {Nota1}");
            Console.WriteLine($"Nota 2: {Nota2}");
            Console.WriteLine($"Média: {calcularMedia()}");
            Console.WriteLine("-----------------------");
        }



    }
}