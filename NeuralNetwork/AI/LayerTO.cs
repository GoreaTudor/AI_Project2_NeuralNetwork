using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    public class LayerTO {
        public InputFunction inputFunctionType { get; set; }
        public ActivationFunction activationFunctionType { get; set; }
        public OutputFunction outputFunctionType { get; set; }
        public Double theta { get; set; }
        public Double g { get; set; }

        public LayerTO () {}
    }
}
