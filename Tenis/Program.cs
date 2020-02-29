using System;
using System.Collections;
using Tenis.Players;

namespace Tenis {
    class Program {
        static void Main (string[] args) {
            playersTennis p1 = new playersTennis ();

            playersTennis p2 = new playersTennis ();

            Skills skillp1 = new Skills ();

            int alternativeP1;

            Skills skillp2 = new Skills ();

            p2.name = "Geraldo";

            Console.WriteLine ("\nBem-vindo Jogador! Digite seu nome!");
            p1.name = Console.ReadLine ();

            Console.WriteLine ($"\n{p1.name}, Seu adversario de hojê se chama {p2.name}");

            Console.WriteLine ($"\nBom {p1.name}, Deixaremos você começar !");

            while (skillp1.saque == false) {

                Console.WriteLine ("\nDigite 1 para sacar");
                alternativeP1 = int.Parse (Console.ReadLine ());

                if (alternativeP1 == 1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ("\n NOSSSSSA!!!! Que Exelência de saque");
                    skillp1.saque = true;
                } else {
                    Console.WriteLine ("\nVocê precisa Sacar");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            skillp1.saque = false;
            skillp2.ContraAtaque = true;

            if (skillp2.ContraAtaque == true) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ($"\nMas {p2.name} faz um ótimo contra ataque !!!!!");
                skillp2.ContraAtaque = false;
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine ("\n Para qual lado ir ?");

            Console.WriteLine ("\n 1 - esquerda");
            Console.WriteLine ("\n 2 - direita ?");

            alternativeP1 = int.Parse (Console.ReadLine ());

            if (alternativeP1 == 1) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ($"\n{p1.name} Corresponde com um jeito impressionate ! E MARCA OS 15 PONTOS");
                p1.Pontos = 15;
            } else if (alternativeP1 == 2) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ($"\n Ops !!! A bola faz uma imensa curva e {p1.name} Acaba Levando o ponto!  {p2.name} MARCA OS 15 PONSTO");
                p2.Pontos = 15;
            } else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ($"\n Ops !! {p1.name} Ficou parado e Acaba Levando o ponto!  {p2.name} MARCA OS 15 PONSTO");
                p2.Pontos = 15;
            }
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine ($"\n Placar : ");
            Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
            Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");

            Console.ForegroundColor = ConsoleColor.White;

            if (p1.Pontos == 15) {
                Console.WriteLine ($"\n  Com a vantagem de 15 Pontos {p1.name} ira sacar novamente ");

            } else if (p2.Pontos == 15) {
                Console.WriteLine ($"\n Com a desvantagem 15 Pontos {p1.name} ira sacar novamente ");
            }

            while (skillp1.saque == false) {

                Console.WriteLine ($"\n 1 -  Tentar um saque forte ");
                Console.WriteLine ($"\n 2 -  Tentar um saque com curva ");
                alternativeP1 = int.Parse (Console.ReadLine ());

                if (alternativeP1 == 2) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ($"\n  A bola faz Uma linda Curva e {p1.name} Marca 15 Pontos ");
                    p1.Pontos = 15 + p1.Pontos;
                    skillp1.saque = true;

                } else if (alternativeP1 == 1) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ($"\n A bola vai forte porem não ultrapassa a rede, {p2.name} Marca 15 Pontos ");
                    p2.Pontos = 15 + p2.Pontos;
                    skillp1.saque = true;
                } else {
                    Console.WriteLine ($"\n Você precisa sacar ! ");

                }

                Console.ForegroundColor = ConsoleColor.White;

            }
            skillp1.saque = false;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine ($"\n Placar : ");
            Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
            Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine ($"\n Vez de {p2.name} Sacar");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ($"\n {p2.name} Manda um foguete extremamente rapido !!!!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine ($"\n 1 -  Rebater Forte ");
            Console.WriteLine ($"\n 2 -  Rebater com efeito ");
            alternativeP1 = int.Parse (Console.ReadLine ());

            if (alternativeP1 == 1) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ($"\n  {p1.name} Não consegue alcançar a bola, Mas porem a bola vai para fora ! ! ! ");
                if (p1.Pontos == 30) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n  E {p1.name} Alcança os incriveis 40 pontos  ! ! ! ");
                    p1.Pontos = p1.Pontos + 10;
                } else {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n  E {p1.name} Ganha mais 15 pontos ! ");
                    p1.Pontos = 15 + p1.Pontos;

                }
                Console.ForegroundColor = ConsoleColor.White;

            }
            if (alternativeP1 == 2) {
                Console.WriteLine ($"\n {p2.name} Tenta rebater uma bola desgovernada, Porem ela pinga dentro da quadra !! ");

                if (p2.Pontos == 30) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n  E {p2.name} Alcança os incriveis 40 pontos  ! ! ! ");
                    p2.Pontos = p2.Pontos + 10;
                } else {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n  E {p2.name} Ganha mais 15 pontos ! ");
                    p2.Pontos = 15 + p2.Pontos;

                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ($"\n Placar : ");
            Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
            Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine ($"\n {p2.name} Se prepara e faz um Lindo Saque com ótima precisão ! !");

            Console.WriteLine ("\n1 - Tentar rebater Saque com extrema cautela !");
            Console.WriteLine ("\n2 - Tentar rebater Saque com velocidade maxima !");

            alternativeP1 = int.Parse (Console.ReadLine ());

            //               VERIFICACOES DO PLAYER 1 ESCOLHA

            if (alternativeP1 == 2) {

                if (p1.Pontos == 40) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    p1.Pontos = p1.Pontos + 10;

                    Console.WriteLine ($"\nNossaaaa ! ! ! Isto é Um massacre, {p1.name} acaba com á partida ! e é campeão da edição 2020 !!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"\n Placar : ");
                    Console.WriteLine ($"\n {p1.name} : Ganhador ");
                    Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Environment.Exit (0);
                } else if (p1.Pontos == 30) {
                    p1.Pontos = p1.Pontos + 10;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\nMeu Deus ! !  {p1.name} Que espetacular esta defesa ! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                } else {
                    p1.Pontos = p1.Pontos + 15;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\nMeu Deus ! !  {p1.name} Que Bela esta defesa ! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                }
            }

            //               VERIFICACOES DO PLAYER 1 ESCOLHA

            //               VERIFICACOES DO PLAYER 2 ESCOLHA

            if (alternativeP1 == 1) {

                if (p2.Pontos == 40) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    p2.Pontos = p2.Pontos + 10;

                    Console.WriteLine ($"\nNossaaaa ! ! ! Isto é Um massacre, {p2.name} acaba com á partida ! e é campeão da edição 2020 !!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"\n Placar : ");
                    Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
                    Console.WriteLine ($"\n {p2.name} : Ganhador");
                    Console.ForegroundColor = ConsoleColor.White;

                    Environment.Exit (0);
                } else if (p2.Pontos == 30) {
                    p2.Pontos = p2.Pontos + 10;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name} Com um excelente saque Alcança 40 pontos ! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                } else {
                    p2.Pontos = p2.Pontos + 15;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name} Marca mais 15 pontos! !");

                    Console.ForegroundColor = ConsoleColor.White;

                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ($"\n Placar : ");
            Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
            Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");
            Console.ForegroundColor = ConsoleColor.White;
            //               VERIFICACOES DO PLAYER 2 ESCOLHA

            //         Termino De 4 Rodadas Uma possivel vitoria de 4 a 0.

            //Tentativa 1

            Console.WriteLine ($" {p1.name} Sua vez de sacar !");

            Console.WriteLine ("\n1 - Saque com segurança");
            Console.WriteLine ("\n2 - Saque com Arriscado");

            alternativeP1 = int.Parse (Console.ReadLine ());

            if (alternativeP1 == 1) {

                if (p1.Pontos == 40) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    p1.Pontos = p1.Pontos + 10;

                    Console.WriteLine ($"\n{p1.name} acaba com á partida ! e é campeão da edição 2020 !!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"\n Placar : ");
                    Console.WriteLine ($"\n {p1.name} : Ganhador ");
                    Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Environment.Exit (0);

                } else if (p1.Pontos == 30) {
                    p1.Pontos = p1.Pontos + 10;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\nMeu Deus ! !  {p1.name} bate com segurança demais e marcaaa! ");

                    Console.ForegroundColor = ConsoleColor.Red;

                } else {

                    p1.Pontos = p1.Pontos + 15;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\nMeu Deus ! !  {p1.name} batida seca com firmeza e marcaa 15 pontos! ");

                    Console.ForegroundColor = ConsoleColor.White;

                }

            } else if (alternativeP1 == 2) {
                if (p2.Pontos == 40) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    p2.Pontos = p2.Pontos + 10;

                    Console.WriteLine ($"\n{p2.name} faz otíma defesa e acaba com á partida ! e é campeão da edição 2020 !!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"\n Placar : ");
                    Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
                    Console.WriteLine ($"\n {p2.name} : Ganhador");
                    Console.ForegroundColor = ConsoleColor.White;

                    Environment.Exit (0);

                } else if (p2.Pontos == 30) {
                    p2.Pontos = p2.Pontos + 10;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name} Com um excelente defesa Alcança 40 pontos ! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                } else {
                    p2.Pontos = p2.Pontos + 15;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name} Marca mais 15 pontos! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                }

            } else {
                Console.WriteLine ($"\nVocê demorou para sacar");

                if (p2.Pontos == 40) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    p2.Pontos = p2.Pontos + 10;

                    Console.WriteLine ($"\n{p2.name} ganha por desistencia! e é campeão da edição 2020 !!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"\n Placar : ");
                    Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
                    Console.WriteLine ($"\n {p2.name} : Ganhador");
                    Console.ForegroundColor = ConsoleColor.White;

                    Environment.Exit (0);

                } else if (p2.Pontos == 30) {
                    p2.Pontos = p2.Pontos + 10;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name}  ganha 40 pontos ! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                } else {

                    p2.Pontos = p2.Pontos + 15;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name} ganha mais 15 pontos! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                }

            }

            //tentativa 2

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ($"\n Placar : ");
            Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
            Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine ($"Agora {p1.name} podera prosseguir para seu proximo saque !");

            Console.WriteLine ("\n1 - Saque com Manobra arriscada");
            Console.WriteLine ("\n2 - Saque Tranquilo");

            alternativeP1 = int.Parse (Console.ReadLine ());
            if (alternativeP1 == 1) {
                if (p1.Pontos == 40) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    p1.Pontos = p1.Pontos + 10;

                    Console.WriteLine ($"\n QUEE Manobra sensacional {p1.name}, acaba com á partida ! e é campeão da edição 2020 !!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"\n Placar : ");
                    Console.WriteLine ($"\n {p1.name} : Ganhador ");
                    Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Environment.Exit (0);

                } else if (p1.Pontos == 30) {
                    p1.Pontos = p1.Pontos + 10;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\nMeu Deus ! !  {p1.name} Bate de jeito excepcional ");

                    Console.ForegroundColor = ConsoleColor.Red;

                } else {

                    p1.Pontos = p1.Pontos + 15;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\nMeu Deus ! !  {p1.name} batida nunca vista antes, de um jeito lindo marca 15 pontos ");

                    Console.ForegroundColor = ConsoleColor.White;

                }

            } else if (alternativeP1 == 2) {
                if (p2.Pontos == 40) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    p2.Pontos = p2.Pontos + 10;

                    Console.WriteLine ($"\n{p2.name} faz otíma defesa e acaba com á partida ! e é campeão da edição 2020 !!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"\n Placar : ");
                    Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
                    Console.WriteLine ($"\n {p2.name} : Ganhador");
                    Console.ForegroundColor = ConsoleColor.White;

                    Environment.Exit (0);

                } else if (p2.Pontos == 30) {
                    p2.Pontos = p2.Pontos + 10;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n saque tranquilo demais, e {p2.name} corresponde com um ótimo corte ! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                } else {
                    p2.Pontos = p2.Pontos + 15;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name} Marca mais 15 pontos com um corte seco ! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                }

            } else {
                Console.WriteLine ($"\nVocê demorou para sacar");

                if (p2.Pontos == 40) {
                    Console.ForegroundColor = ConsoleColor.Green;

                    p2.Pontos = p2.Pontos + 10;

                    Console.WriteLine ($"\n{p2.name} ganha por desistencia! e é campeão da edição 2020 !!");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"\n Placar : ");
                    Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
                    Console.WriteLine ($"\n {p2.name} : Ganhador");
                    Console.ForegroundColor = ConsoleColor.White;

                    Environment.Exit (0);

                } else if (p2.Pontos == 30) {
                    p2.Pontos = p2.Pontos + 10;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name}  ganha 40 pontos ! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                } else {

                    p2.Pontos = p2.Pontos + 15;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine ($"\n{p2.name} ganha mais 15 pontos! !");

                    Console.ForegroundColor = ConsoleColor.Red;

                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine ($"\n Placar : ");
            Console.WriteLine ($"\n {p1.name} : {p1.Pontos} ");
            Console.WriteLine ($"\n {p2.name} : {p2.Pontos}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine ($"\n Jogo empatado Entraremos em rodada de desempate, quem abrir 2 rodadas de vantagem nessa etapa sera o vencedor! ");

            Console.WriteLine ($"\n Serão, 2 rodadas, com 4 respostas, em cada rodada tera 50 % de chance");

            Console.WriteLine ($"\n Caso houver empate as perguntas vão se repetir !");

            Console.WriteLine ($"\n Achar uma resposta certa de começo, sera crucial !");

            if (p1.Pontos == p2.Pontos) {

                while (p1.Pontos == p2.Pontos) {

                    Console.WriteLine ("\n 1 - Rebater Com segurança Total ");
                    Console.WriteLine ("\n 2 - Dar corte venenoso ");
                    Console.WriteLine ("\n 3 - Rebater Firme nas laterais");
                    Console.WriteLine ("\n 4 - Rebater com efeito impressionante");

                    alternativeP1 = int.Parse (Console.ReadLine ());

                    if (alternativeP1 == 1) {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine ("\n 1 - Foi com tanta segurança que colocou força excessiva na raquete e a bola vai para fora");

                        Console.ForegroundColor = ConsoleColor.White;

                        p2.Pontos = p2.Pontos + 10;

                    } else if (alternativeP1 == 2) {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine ("\n 2 - Com corte impressionante, forte e certeiro ");

                        Console.ForegroundColor = ConsoleColor.White;

                        p1.Pontos = p1.Pontos + 10;

                    } else if (alternativeP1 == 3) {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine ("\n 2 - Tentou o Mesmo arroz e feijão e  errou a quadra ");

                        p2.Pontos = p2.Pontos + 10;

                        Console.ForegroundColor = ConsoleColor.White;

                    } else if (alternativeP1 == 4) {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine ("\n 2 - Tirou uma carta da manga, esplêndido ! ! ! ");

                        p1.Pontos = p1.Pontos + 10;

                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    Console.WriteLine ("\n Você Ira sacar o que fazer?");

                    Console.WriteLine ("\n 1 - Sacar bola Firme ");
                    Console.WriteLine ("\n 2 - Jogar para cima bem alto e rebater ");
                    Console.WriteLine ("\n 3 - Sacar com efeito");
                    Console.WriteLine ("\n 4 - Sacar de olhos fechados");

                    alternativeP1 = int.Parse (Console.ReadLine ());

                    if (alternativeP1 == 1) {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine ("\n 1 - Manda Um foguete para fora ");

                        Console.ForegroundColor = ConsoleColor.White;

                        p2.Pontos = p2.Pontos + 10;

                        if (p2.Pontos > p1.Pontos) {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine ($"\n{p2.name} é campeão da edição 2020 !!");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine ($"\n Placar : ");
                            Console.WriteLine ($"\n {p1.name} : 40 ");
                            Console.WriteLine ($"\n {p2.name} : Ganhador");
                            Console.ForegroundColor = ConsoleColor.White;

                            break;

                        }

                    } else if (alternativeP1 == 2) {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine ("\n 2 - Joga a bola para cima mas perde o tempo dela ");

                        Console.ForegroundColor = ConsoleColor.White;

                        p2.Pontos = p2.Pontos + 10;

                        if (p2.Pontos > p1.Pontos) {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine ($"\n{p2.name} é campeão da edição 2020 !!");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine ($"\n Placar : ");
                            Console.WriteLine ($"\n {p1.name} : 40 ");
                            Console.WriteLine ($"\n {p2.name} : Ganhador");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        }

                    } else if (alternativeP1 == 3) {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine ("\n 2 - Bola linda com uma curva perfeita  ");

                        p1.Pontos = p1.Pontos + 10;

                        Console.ForegroundColor = ConsoleColor.White;

                        if (p1.Pontos > p2.Pontos) {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine ($"\n{p1.name} é campeão da edição 2020 !!");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine ($"\n Placar : ");
                            Console.WriteLine ($"\n {p1.name} : Ganhador ");
                            Console.WriteLine ($"\n {p2.name} : 40");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        }

                    } else if (alternativeP1 == 4) {

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine ("\n 2 - O milagre aconteceu o saque vai direto ponto Magnifico ! ");

                        p1.Pontos = p1.Pontos + 10;

                        Console.ForegroundColor = ConsoleColor.White;

                        if (p1.Pontos > p2.Pontos) {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine ($"\n{p1.name} é campeão da edição 2020 !!");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine ($"\n Placar : ");
                            Console.WriteLine ($"\n {p1.name} : Ganhador ");
                            Console.WriteLine ($"\n {p2.name} : 40");
                            Console.ForegroundColor = ConsoleColor.White;

                            break;

                        }

                    }

                }

            }

        }
    }
}