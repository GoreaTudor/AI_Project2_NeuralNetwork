﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork.GUI {
    public partial class UserControlLayer : UserControl {
        private int layerNumber;
        private int numberOfNeurons = 0;

        public UserControlLayer (int layerNumber) {
            InitializeComponent();

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

        private void btn_add_Click (object sender, EventArgs e) { addNeuron(); }
        private void btn_delete_Click (object sender, EventArgs e) { deleteNeuron(); }
        private void btn_layerOptions_Click (object sender, EventArgs e) { options(); }

        private void addNeuron() {
            MyButton button = new MyButton(layerNumber, numberOfNeurons);

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
            }
        }

        private void options () {
            ;
        }
    }
}