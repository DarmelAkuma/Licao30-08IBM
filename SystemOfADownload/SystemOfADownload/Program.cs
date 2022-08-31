using System;

namespace SystemOfADownload {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite quantas músicas serão reproduzidas: ");
            var C = int.Parse(Console.ReadLine());
            for (int i = 0; i < C; i++) {
                Console.WriteLine("Pressione dois botões de 0 à 5: ");
                string[] valores = Console.ReadLine().Split(' ');
                var botao1 = int.Parse(valores[0]);
                var botao2 = int.Parse(valores[1]);
                Playlist soma = new Playlist(botao1, botao2);
                Console.WriteLine(soma.SomaCodigo());
            }
        }
    }
}