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
    public partial class LayerOptionsForm : Form {
        private MyNeuralNetwork network;
        private int layerNumber;

        public LayerOptionsForm (MyNeuralNetwork network, int layerNumber) {
            InitializeComponent();

            this.network = network;
            this.layerNumber = layerNumber;

            this.getAndDisplayFunctions ();
        }


        private void btn_save_Click (object sender, EventArgs e) {
            setFunctions();
            this.Close();
            GlobalStuff.changeStatus ("Functions updated");
        }

        private void btn_cancel_Click (object sender, EventArgs e) {
            this.Close();
        }


        private void setFunctions () {
            InputFunction inputFunction;
            switch (this.comboBox_inputFunction.SelectedIndex) {
                case 1: { inputFunction = InputFunction.Prod; } break;

                case 2: { inputFunction = InputFunction.Min; } break;

                case 3: { inputFunction = InputFunction.Max; } break;

                case 0:
                default: { inputFunction = InputFunction.Sum; } break;
            }

            ActivationFunction activationFunction;
            switch(this.comboBox_activationFunction.SelectedIndex) {
                case 0: { activationFunction = ActivationFunction.Step; } break;

                case 1: { activationFunction = ActivationFunction.Sign; } break;

                case 3: { activationFunction = ActivationFunction.TanH; } break;

                case 4: { activationFunction = ActivationFunction.Linear; } break;

                case 2:
                default: { activationFunction = ActivationFunction.Sigmoid; } break;
            }

            OutputFunction outputFunction;
            if (this.checkBox_outputFunction.Checked) {
                outputFunction = OutputFunction.Binary;
            } else {
                outputFunction = OutputFunction.Real;
            }

            Double theta = (Double) this.numericUpDown_theta.Value;
            Double g = (Double) this.numericUpDown_g.Value;

            network.setFunctions (layerNumber, inputFunction, activationFunction, outputFunction, theta, g);
        }

        private void getAndDisplayFunctions () {
            LayerTO layerTO = network.getFunctions (layerNumber);

            switch (layerTO.inputFunctionType) {
                case InputFunction.Prod: {
                    this.comboBox_inputFunction.SelectedIndex = 1;
                } break;

                case InputFunction.Min: {
                    this.comboBox_inputFunction.SelectedIndex = 2;
                } break;

                case InputFunction.Max: {
                    this.comboBox_inputFunction.SelectedIndex = 3;
                } break;

                case InputFunction.Sum:
                default: {
                    this.comboBox_inputFunction.SelectedIndex = 0;
                }
                break;
            }

            switch (layerTO.activationFunctionType) {
                case ActivationFunction.Step: {
                    this.comboBox_activationFunction.SelectedIndex = 0;
                } break;

                case ActivationFunction.Sign: {
                    this.comboBox_activationFunction.SelectedIndex = 1;
                } break;

                case ActivationFunction.TanH: {
                    this.comboBox_activationFunction.SelectedIndex = 3;
                } break;

                case ActivationFunction.Linear: {
                    this.comboBox_activationFunction.SelectedIndex = 4;
                } break;

                case ActivationFunction.Sigmoid:
                default: {
                    this.comboBox_activationFunction.SelectedIndex = 2;
                } break;
            }

            switch (layerTO.outputFunctionType) {
                case OutputFunction.Binary: {
                    this.checkBox_outputFunction.Checked = true;
                } break;

                case OutputFunction.Real:
                default: {
                    this.checkBox_outputFunction.Checked = false;
                } break;
            }

            this.numericUpDown_theta.Value = (Decimal) layerTO.theta;
            this.numericUpDown_g.Value = (Decimal) layerTO.g;
        }
    }
}
