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
    public partial class FeedforwardForm : Form {
        private MyNeuralNetwork network;
        private int nrOfInputs;

        public FeedforwardForm (MyNeuralNetwork network) {
            InitializeComponent ();

            this.network = network;
            this.nrOfInputs = network.getNumberOfInputs();

            /// prepare inputs ///
            for (int i = 0; i < this.nrOfInputs; i++) {
                ValueListItem inputListItem = new ValueListItem ("I" + i);
                this.flowLayoutPanel_inputs.Controls.Add (inputListItem);
            }            
        }

        private void btn_calculate_Click (object sender, EventArgs e) {
            List <Double> inputs = new List <Double> ();

            /// read inputs ///
            foreach (Control control in this.flowLayoutPanel_inputs.Controls) {
                if (control is ValueListItem) {
                    ValueListItem inputListItem = (ValueListItem) control;
                    inputListItem.makeInput ();
                    inputs.Add (inputListItem.getValue ());
                }
            }

            /// The MOST WANTED operation ///
            List <Double> outputs = network.feedforward (inputs);

            this.flowLayoutPanel_outputs.Controls.Clear ();
            for (int i = 0; i < outputs.Count; i++) {
                ValueListItem outputListItem = new ValueListItem ("O" + i);
                outputListItem.setValue (outputs[i]);
                outputListItem.makeOutput();
                this.flowLayoutPanel_outputs.Controls.Add (outputListItem);
            }

        }

        private void btn_done_Click (object sender, EventArgs e) {
            this.Close ();
        }
    }
}
