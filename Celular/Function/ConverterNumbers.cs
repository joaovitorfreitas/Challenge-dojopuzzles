using System;
using System.Collections.Generic;

namespace Celular.Function {
    public class ConverterNumbers {
        public void Converter () {

            string Texto ;
            string letra;
            int posicaoProvisoria;
            int posicaoFinal;

            List<string> textoretorno = new List<string> ();

            Console.WriteLine ("Escreva o texto");
            Texto = Console.ReadLine ();

            int tamanho = Texto.Length;

            for (int i = 0; i < tamanho; i++) {
                letra = Texto.Substring (i, 1);

                if (Texto.Length > 255) {
                    Console.WriteLine ("Tamanho Invalido, Insira até 255 Caracteres !!! ");
                    break;
                }

                posicaoProvisoria = Texto.IndexOf ("a");
                posicaoFinal = Texto.LastIndexOf ("a");

                if (letra.ToLower () == "a") {

                    textoretorno.Add ("2");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "b" || Texto.Substring (posicaoProvisoria + 1, 1) == "c" || Texto.Substring (posicaoProvisoria + 1, 1) == "a") {
                        textoretorno.Add ("_");
                    }

                }

                posicaoProvisoria = Texto.IndexOf ("b");
                posicaoFinal = Texto.LastIndexOf ("b");

                if (letra.ToLower () == "b") {

                    textoretorno.Add ("22");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "c" || Texto.Substring (posicaoProvisoria + 1, 1) == "a" || Texto.Substring (posicaoProvisoria + 1, 1) == "b") {
                        textoretorno.Add ("_");

                    }

                }

                posicaoProvisoria = Texto.IndexOf ("c");
                posicaoFinal = Texto.LastIndexOf ("c");

                if (letra.ToLower () == "c") {

                    textoretorno.Add ("222");

                    if (posicaoFinal + 1 == tamanho) {
                        Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                        break;
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "b" || Texto.Substring (posicaoProvisoria + 1, 1) == "a" | Texto.Substring (posicaoProvisoria + 1, 1) == "c") {
                        textoretorno.Add ("_");
                    }

                }

                // ***** TODAS VERIFICACOES DE LETRAS DO A - C 

                // ***** TODAS VERIFICACOES DE LETRAS DO D - F 

                posicaoProvisoria = Texto.IndexOf ("d");
                posicaoFinal = Texto.LastIndexOf ("d");

                if (letra.ToLower () == "d") {
                    textoretorno.Add ("3");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }
                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "d" || Texto.Substring (posicaoProvisoria + 1, 1) == "e" || Texto.Substring (posicaoProvisoria + 1, 1) == "f") {
                        textoretorno.Add ("_");

                    }

                }

                posicaoProvisoria = Texto.IndexOf ("e");
                posicaoFinal = Texto.LastIndexOf ("e");

                if (letra.ToLower () == "e") {
                    textoretorno.Add ("33");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "d" || Texto.Substring (posicaoProvisoria + 1, 1) == "e" || Texto.Substring (posicaoProvisoria + 1, 1) == "f") {
                        textoretorno.Add ("_");

                    }

                }

                posicaoProvisoria = Texto.IndexOf ("f");
                posicaoFinal = Texto.LastIndexOf ("f");

                if (letra.ToLower () == "f") {
                    textoretorno.Add ("333");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "d" || Texto.Substring (posicaoProvisoria + 1, 1) == "e" || Texto.Substring (posicaoProvisoria + 1, 1) == "f") {
                        textoretorno.Add ("_");

                    }

                }

                //     ***** TODAS VERIFICACOES DE LETRAS DO D - F
                //     ***** TODAS VERIFICACOES DE LETRAS DO G - I

                posicaoProvisoria = Texto.IndexOf ("g");
                posicaoFinal = Texto.LastIndexOf ("g");

                if (letra.ToLower () == "g") {
                    textoretorno.Add ("4");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "g" || Texto.Substring (posicaoProvisoria + 1, 1) == "h" || Texto.Substring (posicaoProvisoria + 1, 1) == "i") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("h");
                posicaoFinal = Texto.LastIndexOf ("h");

                if (letra.ToLower () == "h") {
                    textoretorno.Add ("44");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "g" || Texto.Substring (posicaoProvisoria + 1, 1) == "h" || Texto.Substring (posicaoProvisoria + 1, 1) == "i") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("i");
                posicaoFinal = Texto.LastIndexOf ("i");

                if (letra.ToLower () == "i") {
                    textoretorno.Add ("444");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "g" || Texto.Substring (posicaoProvisoria + 1, 1) == "h" || Texto.Substring (posicaoProvisoria + 1, 1) == "i") {
                        textoretorno.Add ("_");

                    }
                }

                //     ***** TODAS VERIFICACOES DE LETRAS DO G - I
                //     ***** TODAS VERIFICACOES DE LETRAS DO J - L

                posicaoProvisoria = Texto.IndexOf ("j");
                posicaoFinal = Texto.LastIndexOf ("j");

                if (letra.ToLower () == "j") {
                    textoretorno.Add ("5");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "j" || Texto.Substring (posicaoProvisoria + 1, 1) == "k" || Texto.Substring (posicaoProvisoria + 1, 1) == "l") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("k");
                posicaoFinal = Texto.LastIndexOf ("k");

                if (letra.ToLower () == "k") {
                    textoretorno.Add ("55");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "j" || Texto.Substring (posicaoProvisoria + 1, 1) == "k" || Texto.Substring (posicaoProvisoria + 1, 1) == "l") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("l");
                posicaoFinal = Texto.LastIndexOf ("l");

                if (letra.ToLower () == "l") {
                    textoretorno.Add ("555");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "j" || Texto.Substring (posicaoProvisoria + 1, 1) == "k" || Texto.Substring (posicaoProvisoria + 1, 1) == "l") {
                        textoretorno.Add ("_");

                    }
                }

                //     ***** TODAS VERIFICACOES DE LETRAS DO J - L
                //     ***** TODAS VERIFICACOES DE LETRAS DO M - O

                posicaoProvisoria = Texto.IndexOf ("m");
                posicaoFinal = Texto.LastIndexOf ("m");

                if (letra.ToLower () == "m") {

                    textoretorno.Add ("6");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }
                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "m" || Texto.Substring (posicaoProvisoria + 1, 1) == "n" || Texto.Substring (posicaoProvisoria + 1, 1) == "o") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("n");
                posicaoFinal = Texto.LastIndexOf ("n");

                if (letra.ToLower () == "n") {
                    textoretorno.Add ("66");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "m" || Texto.Substring (posicaoProvisoria + 1, 1) == "n" || Texto.Substring (posicaoProvisoria + 1, 1) == "o") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("o");
                posicaoFinal = Texto.LastIndexOf ("o");

                if (letra.ToLower () == "o") {
                    textoretorno.Add ("666");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "m" || Texto.Substring (posicaoProvisoria + 1, 1) == "n" || Texto.Substring (posicaoProvisoria + 1, 1) == "o") {
                        textoretorno.Add ("_");

                    }
                }

                //     ***** TODAS VERIFICACOES DE LETRAS DO M - O
                //     ***** TODAS VERIFICACOES DE LETRAS DO P - S

                posicaoProvisoria = Texto.IndexOf ("p");
                posicaoFinal = Texto.LastIndexOf ("p");

                if (letra.ToLower () == "p") {

                    textoretorno.Add ("7");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "p" || Texto.Substring (posicaoProvisoria + 1, 1) == "q" || Texto.Substring (posicaoProvisoria + 1, 1) == "r" || Texto.Substring (posicaoProvisoria + 1, 1) == "s") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("q");
                posicaoFinal = Texto.LastIndexOf ("q");

                if (letra.ToLower () == "q") {
                    textoretorno.Add ("77");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "p" || Texto.Substring (posicaoProvisoria + 1, 1) == "q" || Texto.Substring (posicaoProvisoria + 1, 1) == "r" || Texto.Substring (posicaoProvisoria + 1, 1) == "s") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("r");
                posicaoFinal = Texto.LastIndexOf ("r");

                if (letra.ToLower () == "r") {
                    textoretorno.Add ("777");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "p" || Texto.Substring (posicaoProvisoria + 1, 1) == "q" || Texto.Substring (posicaoProvisoria + 1, 1) == "r" || Texto.Substring (posicaoProvisoria + 1, 1) == "s") {
                        textoretorno.Add ("_");

                    }

                }

                posicaoProvisoria = Texto.IndexOf ("s");
                posicaoFinal = Texto.LastIndexOf ("s");

                if (letra.ToLower () == "s") {
                    textoretorno.Add ("7777");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "p" || Texto.Substring (posicaoProvisoria + 1, 1) == "q" || Texto.Substring (posicaoProvisoria + 1, 1) == "r" || Texto.Substring (posicaoProvisoria + 1, 1) == "s") {
                        textoretorno.Add ("_");

                    }
                }

                //     ***** TODAS VERIFICACOES DE LETRAS DO P - S
                //     ***** TODAS VERIFICACOES DE LETRAS DO T - V

                posicaoProvisoria = Texto.IndexOf ("t");
                posicaoFinal = Texto.LastIndexOf ("t");

                if (letra.ToLower () == "t") {
                    textoretorno.Add ("8");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "t" || Texto.Substring (posicaoProvisoria + 1, 1) == "u" || Texto.Substring (posicaoProvisoria + 1, 1) == "v") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("u");
                posicaoFinal = Texto.LastIndexOf ("u");

                if (letra.ToLower () == "u") {
                    textoretorno.Add ("88");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "t" || Texto.Substring (posicaoProvisoria + 1, 1) == "u" || Texto.Substring (posicaoProvisoria + 1, 1) == "v") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("v");
                posicaoFinal = Texto.LastIndexOf ("v");

                if (letra.ToLower () == "v") {
                    textoretorno.Add ("888");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "t" || Texto.Substring (posicaoProvisoria + 1, 1) == "u" || Texto.Substring (posicaoProvisoria + 1, 1) == "v") {
                        textoretorno.Add ("_");

                    }

                }

                //     ***** TODAS VERIFICACOES DE LETRAS DO T - V
                //     ***** TODAS VERIFICACOES DE LETRAS DO W - Z

                posicaoProvisoria = Texto.IndexOf ("w");
                posicaoFinal = Texto.LastIndexOf ("w");

                if (letra.ToLower () == "w") {
                    textoretorno.Add ("9");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "w" || Texto.Substring (posicaoProvisoria + 1, 1) == "x" || Texto.Substring (posicaoProvisoria + 1, 1) == "y" || Texto.Substring (posicaoProvisoria + 1, 1) == "z") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("x");
                posicaoFinal = Texto.LastIndexOf ("x");

                if (letra.ToLower () == "x") {
                    textoretorno.Add ("99");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "w" || Texto.Substring (posicaoProvisoria + 1, 1) == "x" || Texto.Substring (posicaoProvisoria + 1, 1) == "y" || Texto.Substring (posicaoProvisoria + 1, 1) == "z") {
                        textoretorno.Add ("_");

                    }

                }

                posicaoProvisoria = Texto.IndexOf ("y");
                posicaoFinal = Texto.LastIndexOf ("y");

                if (letra.ToLower () == "y") {
                    textoretorno.Add ("999");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "w" || Texto.Substring (posicaoProvisoria + 1, 1) == "x" || Texto.Substring (posicaoProvisoria + 1, 1) == "y" || Texto.Substring (posicaoProvisoria + 1, 1) == "z") {
                        textoretorno.Add ("_");

                    }
                }

                posicaoProvisoria = Texto.IndexOf ("z");
                posicaoFinal = Texto.LastIndexOf ("z");

                if (letra.ToLower () == "z") {
                    textoretorno.Add ("9999");

                    if (i == posicaoFinal) {

                        if (posicaoFinal + 1 == tamanho) {
                            Console.WriteLine ("\nNumeros Convertidos ! :" + string.Join ("", textoretorno));
                            break;
                        }
                    }

                    if (Texto.Substring (posicaoProvisoria + 1, 1) == "w" || Texto.Substring (posicaoProvisoria + 1, 1) == "x" || Texto.Substring (posicaoProvisoria + 1, 1) == "y" || Texto.Substring (posicaoProvisoria + 1, 1) == "z") {
                        textoretorno.Add ("_");

                    }

                }

                // * * * * * TODAS VERIFICACOES DE LETRAS DO W - Z 
                //     VERIFICACOES DE ESPAÇO

                if (letra.ToLower () == " ") {
                    textoretorno.Add ("0");
                }

            }
        }
    }
}