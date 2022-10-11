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
    public partial class UserControlLayer : UserControl {
        private MyNeuralNetwork network;

        private int layerNumber;
        private int numberOfNeurons = 0;

        public UserControlLayer (MyNeuralNetwork network, int layerNumber) {
            InitializeComponent();

            this.network = network;
            this.layerNumber = layerNumber;
            this.lbl_layerName.Text = getName();

            if (layerNumber < 0) {  // or eual to -1
                this.btn_layerOptions.Enabled = false;
            }

            
            addNeuron();
        }

        private String getName() {
            String name;
            switch(layerNumber) {
                case -1: {
                    name = "IL";
                } break;

                case 0: {
                    name = "OL";
                } break;

                default: {
                    name = "HL" + layerNumber;
                } break;
            }
            return name;
        }


        private void btn_add_Click (object sender, EventArgs e) {
            network.increaseNumberOfNeurons(layerNumber);
            addNeuron();
            GlobalStuff.changeStatus ("Neuron added");
        }

        private void btn_delete_Click (object sender, EventArgs e) {
            if (numberOfNeurons > 1) {
                network.decreaseNumberOfNeurons(layerNumber);
            }
            
            deleteNeuron(); 
        }

        private void btn_layerOptions_Click (object sender, EventArgs e) { 
            options(); 
        }


        private void addNeuron() {
            int neuronNumber = numberOfNeurons;
            MyButton button = new MyButton(layerNumber, neuronNumber);

            button.Click += (sender, e) => {
                ChangeWeightsForm form = new ChangeWeightsForm (network, layerNumber, neuronNumber);
                form.ShowDialog ();
            };

            if (layerNumber < 0) {
                button.Enabled = false;
            }

            layerFlowLayoutPanel.Controls.Add(button);
            numberOfNeurons++;
        }

        private void deleteNeuron () {
            if (numberOfNeurons > 1) {
                numberOfNeurons--;
                layerFlowLayoutPanel.Controls.RemoveAt(numberOfNeurons);
                GlobalStuff.changeStatus ("Deleted neuron");

            } else {
                GlobalStuff.changeStatus ("Cannot delete the first neuron");
            }
        }

        private void options () {
            LayerOptionsForm form = new LayerOptionsForm (this.network, this.layerNumber);
            form.ShowDialog ();
        }
    }
}
