using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NeuralNetwork {
    class GlobalStuff {
        public static readonly Font font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular);
        public static readonly Double initialWeightValue = 0.0;

        public static MainForm mainForm { get; set; }
        public static void changeStatus (String text) {
            mainForm.changeStatus (text);
        }
    }
}
