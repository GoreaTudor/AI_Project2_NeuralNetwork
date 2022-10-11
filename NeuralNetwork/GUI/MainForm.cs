using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetwork.GUI;
using NeuralNetwork.AI;

namespace NeuralNetwork {
    public partial class MainForm : Form {
        /// <summary>
        /// The neural network is generated when the app opens and the MainForm saves a reference to the network.
        /// </summary>
        private MyNeuralNetwork network = new MyNeuralNetwork(); 

        private int numberOfHiddenLayers = 0;
        

        public MainForm() {
            InitializeComponent();
            GlobalStuff.mainForm = this;
            GlobalStuff.changeStatus ("Initialized");

            UserControlLayer inputLayer = new UserControlLayer(network, -1);
            IL_flowLayoutPanel.Controls.Add(inputLayer);

            UserControlLayer outputLayer = new UserControlLayer(network, 0);
            OL_flowLayoutPanel.Controls.Add(outputLayer);

            addHiddenLayer();
        }


        private void btn_add_Click (object sender, EventArgs e) {
            network.increaseNumberOfHiddenLayers();
            addHiddenLayer();
        }

        private void btn_delete_Click (object sender, EventArgs e) {
            if (numberOfHiddenLayers > 1) {
                network.decreaseNumberOfHiddenLayers ();
            }
            deleteHiddenLayer();
        }

        private void btn_feedforward_Click (object sender, EventArgs e) {
            ;
        }


        private void addHiddenLayer () {
            numberOfHiddenLayers++;
            UserControlLayer control = new UserControlLayer(network, numberOfHiddenLayers);
            hiddenFlowLayoutPanel.Controls.Add(control);
            GlobalStuff.changeStatus ("Added new hidden layer");
        }

        private void deleteHiddenLayer () {
            if (numberOfHiddenLayers > 1) {
                numberOfHiddenLayers--;
                hiddenFlowLayoutPanel.Controls.RemoveAt(numberOfHiddenLayers);
                GlobalStuff.changeStatus ("Deleted hidden layer");

            } else {
                GlobalStuff.changeStatus ("First layer cannot be deleted");
            }
        }

        public void changeStatus (String text) {
            this.statusLabel.Text = DateTime.Now.ToString() + ":  " + text + ".";
        }
    }
}
