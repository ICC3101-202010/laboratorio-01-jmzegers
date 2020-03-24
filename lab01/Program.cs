using System;

namespace Laboratorio_1_POO_jmzegers
{
    public class Jugador
    {
        public int resultado;

        static int Lanzar(int a, int b)
        {
            Random rnd = new Random();
            return rnd.Next(a, b);

        }

        public string nombre;
        public string apellido;
        private static int cachipun;
        private static int res;

        public Jugador(string nJugador, string aJugador)
        {
            nJugador = nombre;
            aJugador = apellido;
        }

        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador("Bob", "Kunga");
            res = Jugador.Lanzar(0, 3);
            Console.WriteLine(res);
            Console.WriteLine(jugador1);
        }
    }

}
