using System;
using System.Collections;


namespace Jokenpo {
    class Program {
        static void Main (string[] args) {

            ArrayList lista = new ArrayList ();

            lista.Add ("pedra");
            lista.Add ("papel");
            lista.Add ("tesoura");

            string escolha;
            Console.WriteLine ("\npedra papel Ou tesoura?");
            escolha = Console.ReadLine ();

            string Jokenpo = Sortearjokenpo (lista);
            Console.WriteLine (Jokenpo);

            Console.WriteLine ("\nJOKENNNPOOOOOO Maquina:" + Jokenpo);

            if (escolha == "Pedra" && Jokenpo == "papel") {
                Console.WriteLine ("\nVoce Perdeu!");
            } else if (escolha == "pedra" && Jokenpo == "tesoura") {
                Console.WriteLine ("\nVocê Ganhou : D");
            } else if (escolha == "papel" && Jokenpo == "pedra") {
                Console.WriteLine ("\nVocê Ganhou : D");
            } else if (escolha == "papel" && Jokenpo == "tesoura") {
                Console.WriteLine ("\nVoce Perdeu!");
            } else if (escolha == "tesoura" && Jokenpo == "pedra") {
                Console.WriteLine ("\nVoce Perdeu!");
            } else if (escolha == "tesoura" && Jokenpo == "papel") {
                Console.WriteLine ("\nVocê Ganhou : D");

            } else if (escolha == "tesoura" && Jokenpo == "tesoura") {
                Console.WriteLine ("\nEmpate");

            } else if (escolha == "pedra" && Jokenpo == "pedra") {
                Console.WriteLine ("\nEmpate");

            } else if (escolha == "papel" && Jokenpo == "papel") {
                Console.WriteLine ("\nEmpate");

            }
            static string Sortearjokenpo (ArrayList lista) {
                Random random = new Random ();
                int opcao = random.Next (0, lista.Count);
                return lista[opcao].ToString ();
            }
        }
    }
}