using System;
using System.Collections.Generic;
using Celular.Function;
using Celular.ShowOptionsPanel;

namespace Celular {
    class Program {
        static void Main (string[] args) {

            PanelOptions listar = new PanelOptions ();

            ConverterNumbers converter = new ConverterNumbers ();

            listar.OptionPanel ();

            converter.Converter ();

        }

    }
}