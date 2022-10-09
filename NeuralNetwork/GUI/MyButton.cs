using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetwork.GUI;

namespace NeuralNetwork.GUI {
    class MyButton : Button {
        /// <summary>
        /// "-1" represents input layer, "0" represents output layer, and ">= 1" represent indexes for hidden layers
        /// </summary>
        public int layerNumber { get; set; }
        public int neuronNumber { get; set; }

        public MyButton(int layerNumber, int neuronNumber) {
            this.layerNumber = layerNumber;
            this.neuronNumber = neuronNumber;
            this.Font = GlobalStuff.font;
            this.Text = getName() + " N" + neuronNumber;
            this.Width = 120;
            this.Height = 40;
        }

        private String getName () {
            String name;
            switch (layerNumber) {
                case -1: {
                    name = "IL";
                }
                break;

                case 0: {
                    name = "OL";
                }
                break;

                default: {
                    name = "HL" + layerNumber;
                }
                break;
            }
            return name;
        }
    }
}
