using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetwork.AI;

namespace NeuralNetwork.GUI {
    public partial class ChangeWeightsForm : Form {
        private MyNeuralNetwork network;
        private int layerNumber;
        private int neuronNumber;

        public ChangeWeightsForm (MyNeuralNetwork network, int layerNumber, int neuronNumber) {
            InitializeComponent ();

            this.network = network;
            this.layerNumber = layerNumber;
            this.neuronNumber = neuronNumber;

            /// Prepare the list of weights ///
            List <Double> weights = network.getWeights (layerNumber, neuronNumber);

            foreach (Double weight in weights) {
                WeightListItem weightListItem = new WeightListItem ();
                weightListItem.setWeightValue (weight);
                this.flowLayoutPanel_weights.Controls.Add (weightListItem);
            }
        }

        private void btn_save_Click (object sender, EventArgs e) {
            updateWeights ();
            this.Close ();
        }

        private void btn_cancel_Click (object sender, EventArgs e) {
            this.Close ();
        }

        private void updateWeights() {
            List <Double> newWeights = new List <Double> ();
            foreach (Control item in this.flowLayoutPanel_weights.Controls) {
                if (item is WeightListItem) {
                    WeightListItem weightListItem = (WeightListItem) item;
                    newWeights.Add (weightListItem.getWeightValue ());
                }
            }
            network.setWeights (layerNumber, neuronNumber, newWeights);
        }
    }
}
