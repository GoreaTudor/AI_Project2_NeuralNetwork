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
    public partial class WeightListItem : UserControl {
        public WeightListItem () {
            InitializeComponent ();
        }

        public Double getWeightValue () {
            return (Double) this.numericUpDown_weightValue.Value;
        }

        public void setWeightValue (Double value) {
            this.numericUpDown_weightValue.Value = (Decimal) value;
        }
    }
}
