using System;
using System.Collections.Generic;

namespace Celular.Function {
    public class ConverterNumbers {
        public void Converter () {
            string Texto = "";
            string letra = "";

            List<string> textoretorno = new List<string> ();

            Console.WriteLine ("Escreva o texto");
            Texto = Console.ReadLine ();

            for (int i = 0; i <= Texto.Length; i++) {
                letra = Texto.Substring (i, 1);

                int Verificar1 = i + 1;

                if (Texto.Length > 255) {
                    Console.WriteLine ("Tamanho Invalido, Insira até 255 Caracteres !!! ");
                    break;
                }
                //***** TODAS VERIFICACOES DE LETRAS DO A - C 

                if (letra.ToLower () == "a") {

                    textoretorno.Add ("2");

                }

                    if (letra.ToLower () == "a" && Texto.Substring (Verificar1, 1) == "b") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "a" && Texto.Substring (Verificar1, 1) == "c") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "b") {

                    textoretorno.Add ("22");
                }

                    if (letra.ToLower () == "b" && Texto.Substring (Verificar1, 1) == "a") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "b" && Texto.Substring (Verificar1, 1) == "c") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "c") {
                    textoretorno.Add ("222");

                }

                    if (letra.ToLower () == "c" && Texto.Substring (Verificar1, 1) == "a") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "c" && Texto.Substring (Verificar1, 1) == "b") {
                    textoretorno.Add ("_");
                    }

                //***** TODAS VERIFICACOES DE LETRAS DO A - C 

                //***** TODAS VERIFICACOES DE LETRAS DO D - F 

                if (letra.ToLower () == "d") {
                    textoretorno.Add ("3");
                }

                    if (letra.ToLower () == "d" && Texto.Substring (Verificar1, 1) == "e") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "d" && Texto.Substring (Verificar1, 1) == "f") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "e") {
                    textoretorno.Add ("33");
                }

                    if (letra.ToLower () == "e" && Texto.Substring (Verificar1, 1) == "d") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "e" && Texto.Substring (Verificar1, 1) == "f") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "f") {
                    textoretorno.Add ("333");
                }

                    if (letra.ToLower () == "f" && Texto.Substring (Verificar1, 1) == "d") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "f" && Texto.Substring (Verificar1, 1) == "e") {
                    textoretorno.Add ("_");
                    }

                //***** TODAS VERIFICACOES DE LETRAS DO D - F
                //***** TODAS VERIFICACOES DE LETRAS DO G - I

                if (letra.ToLower () == "g") {
                    textoretorno.Add ("4");
                }

                    if (letra.ToLower () == "g" && Texto.Substring (Verificar1, 1) == "h") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "g" && Texto.Substring (Verificar1, 1) == "i") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "h") {
                    textoretorno.Add ("44");
                }

                    if (letra.ToLower () == "h" && Texto.Substring (Verificar1, 1) == "g") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "h" && Texto.Substring (Verificar1, 1) == "i") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "i") {
                    textoretorno.Add ("444");

                }

                    if (letra.ToLower () == "i" && Texto.Substring (Verificar1, 1) == "g") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "i" && Texto.Substring (Verificar1, 1) == "h") {
                    textoretorno.Add ("_");
                    }
                //***** TODAS VERIFICACOES DE LETRAS DO G - I
                //***** TODAS VERIFICACOES DE LETRAS DO J - L
                if (letra.ToLower () == "j") {
                    textoretorno.Add ("5");
                }

                    if (letra.ToLower () == "j" && Texto.Substring (Verificar1, 1) == "k") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "j" && Texto.Substring (Verificar1, 1) == "l") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "k") {
                    textoretorno.Add ("55");
                }

                    if (letra.ToLower () == "k" && Texto.Substring (Verificar1, 1) == "j") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "k" && Texto.Substring (Verificar1, 1) == "l") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "l") {
                    textoretorno.Add ("555");
                }

                    if (letra.ToLower () == "l" && Texto.Substring (Verificar1, 1) == "j") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "l" && Texto.Substring (Verificar1, 1) == "k") {
                    textoretorno.Add ("_");
                    }

                //***** TODAS VERIFICACOES DE LETRAS DO J - L
                //***** TODAS VERIFICACOES DE LETRAS DO M - O

                if (letra.ToLower () == "m") {
                    textoretorno.Add ("6");
                }

                    if (letra.ToLower () == "m" && Texto.Substring (Verificar1, 1) == "n") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "m" && Texto.Substring (Verificar1, 1) == "o") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "n") {
                    textoretorno.Add ("66");
                }

                    if (letra.ToLower () == "n" && Texto.Substring (Verificar1, 1) == "m") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "n" && Texto.Substring (Verificar1, 1) == "o") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "o") {
                    textoretorno.Add ("666");
                }

                    if (letra.ToLower () == "o" && Texto.Substring (Verificar1, 1) == "m") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "o" && Texto.Substring (Verificar1, 1) == "n") {
                    textoretorno.Add ("_");
                    }

                //***** TODAS VERIFICACOES DE LETRAS DO M - O
                //***** TODAS VERIFICACOES DE LETRAS DO P - S


                if (letra.ToLower () == "p") {
                    textoretorno.Add ("7");
                }

                    if (letra.ToLower () == "p" && Texto.Substring (Verificar1, 1) == "q") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "p" && Texto.Substring (Verificar1, 1) == "r") {
                    textoretorno.Add ("_");
                    }else if (letra.ToLower () == "p" && Texto.Substring (Verificar1, 1) == "s") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "q") {
                    textoretorno.Add ("77");
                }

                    if (letra.ToLower () == "q" && Texto.Substring (Verificar1, 1) == "p") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "q" && Texto.Substring (Verificar1, 1) == "r") {
                    textoretorno.Add ("_");
                    }else if (letra.ToLower () == "q" && Texto.Substring (Verificar1, 1) == "s") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "r") {
                    textoretorno.Add ("777");
                }

                    if (letra.ToLower () == "r" && Texto.Substring (Verificar1, 1) == "p") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "r" && Texto.Substring (Verificar1, 1) == "q") {
                    textoretorno.Add ("_");
                    }else if (letra.ToLower () == "r" && Texto.Substring (Verificar1, 1) == "s") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "s") {
                    textoretorno.Add ("7777");
                }

                    if (letra.ToLower () == "s" && Texto.Substring (Verificar1, 1) == "p") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "s" && Texto.Substring (Verificar1, 1) == "q") {
                    textoretorno.Add ("_");
                    }else if (letra.ToLower () == "s" && Texto.Substring (Verificar1, 1) == "r") {
                    textoretorno.Add ("_");
                    }
                

                //***** TODAS VERIFICACOES DE LETRAS DO P - S
                //***** TODAS VERIFICACOES DE LETRAS DO T - V


                if (letra.ToLower () == "t") {
                    textoretorno.Add ("8");
                }

                    if (letra.ToLower () == "t" && Texto.Substring (Verificar1, 1) == "u") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "t" && Texto.Substring (Verificar1, 1) == "v") {
                    textoretorno.Add ("_");
                    }
 
                if (letra.ToLower () == "u") {
                    textoretorno.Add ("88");
                }

                    if (letra.ToLower () == "u" && Texto.Substring (Verificar1, 1) == "t") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "u" && Texto.Substring (Verificar1, 1) == "v") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "v") {
                    textoretorno.Add ("888");

                    if (letra.ToLower () == "v" && Texto.Substring (Verificar1, 1) == "t") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "v" && Texto.Substring (Verificar1, 1) == "u") {
                    textoretorno.Add ("_");
                    }
                }

                //***** TODAS VERIFICACOES DE LETRAS DO T - V
                //***** TODAS VERIFICACOES DE LETRAS DO W - Z


                if (letra.ToLower () == "w") {
                    textoretorno.Add ("9");
                }


                    if (letra.ToLower () == "w" && Texto.Substring (Verificar1, 1) == "x") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "w" && Texto.Substring (Verificar1, 1) == "y") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "w" && Texto.Substring (Verificar1, 1) == "z") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "x") {
                    textoretorno.Add ("99");
                }

                    if (letra.ToLower () == "x" && Texto.Substring (Verificar1, 1) == "w") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "x" && Texto.Substring (Verificar1, 1) == "y") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "x" && Texto.Substring (Verificar1, 1) == "z") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "y") {
                    textoretorno.Add ("999");
                }

                    if (letra.ToLower () == "y" && Texto.Substring (Verificar1, 1) == "w") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "y" && Texto.Substring (Verificar1, 1) == "x") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "y" && Texto.Substring (Verificar1, 1) == "z") {
                    textoretorno.Add ("_");
                    }

                if (letra.ToLower () == "z") {
                    textoretorno.Add ("9999");

                    if (letra.ToLower () == "z" && Texto.Substring (Verificar1, 1) == "w") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "z" && Texto.Substring (Verificar1, 1) == "x") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "z" && Texto.Substring (Verificar1, 1) == "y") {
                    textoretorno.Add ("_");
                    } else if (letra.ToLower () == "z" && Texto.Substring (Verificar1, 1) == "z") {
                    textoretorno.Add ("_");
                    }
                    

                }

                //***** TODAS VERIFICACOES DE LETRAS DO W - Z


                if (letra.ToLower () == " ") {
                    textoretorno.Add ("0");
                }

                Console.WriteLine ("\nNumeros Convertidos ! :"+ string.Join ("", textoretorno));

            }
        }
    }
}