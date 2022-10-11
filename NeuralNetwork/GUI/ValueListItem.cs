using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetwork.GUI {
    public partial class ValueListItem : UserControl {
        public ValueListItem (String text) {
            InitializeComponent ();
            this.lbl_value.Text = text;
        }

        public Double getValue () {
            return (Double) this.numericUpDown_value.Value;
        }

        public void setValue (Double value) {
            this.numericUpDown_value.Value = (Decimal) value;
        }

        public void makeOutput () {
            this.numericUpDown_value.Enabled = false;
            this.numericUpDown_value.DecimalPlaces = 5;
        }

        public void makeInput () {
            this.numericUpDown_value.Minimum = -100;
            this.numericUpDown_value.Maximum = 100;
        }
    }
}
