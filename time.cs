using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class Time
    {
        public string NomeDoTime;
        public List<Jogador> ListaDeJogadores = new List<Jogador>();

        public void AdicionarJogador(Jogador jogador)
        {
            ListaDeJogadores.Add(jogador);
        }

        public void ListarJogadores()
        {
            Console.WriteLine("Time: " + NomeDoTime);
            Console.WriteLine("Escalação:");

            foreach (Jogador jogador in ListaDeJogadores)
            {
                Console.WriteLine("Camisa " + jogador.NumeroCamisa + " - " + jogador.Nome + " - " + jogador.Posicao);
            }
        }
    }
}