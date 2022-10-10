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

            UserControlLayer inputLayer = new UserControlLayer(-1);
            IL_flowLayoutPanel.Controls.Add(inputLayer);

            UserControlLayer outputLayer = new UserControlLayer(0);
            OL_flowLayoutPanel.Controls.Add(outputLayer);

            addHiddenLayer();
        }

        private void btn_add_Click (object sender, EventArgs e) {
            addHiddenLayer();
        }

        private void btn_delete_Click (object sender, EventArgs e) {
            deleteHiddenLayer();
        }

        private void addHiddenLayer () {
            numberOfHiddenLayers++;
            UserControlLayer control = new UserControlLayer(numberOfHiddenLayers);
            hiddenFlowLayoutPanel.Controls.Add(control);
        }

        private void deleteHiddenLayer () {
            if (numberOfHiddenLayers > 1) {
                numberOfHiddenLayers--;
                hiddenFlowLayoutPanel.Controls.RemoveAt(numberOfHiddenLayers);
            }
        }
    }
}
