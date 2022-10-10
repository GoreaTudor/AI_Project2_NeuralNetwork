using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    public delegate TResult Function <Tparam, TResult> (Tparam param);

    public enum InputFunction {
        Sum, Prod, Min, Max
    }

    public enum ActivationFunction {
        Step, Sign, Sigmoid, TanH, Linear, 
        Identity // for input layer
    }

    public enum OutputFunction {
        Real, Binary
    }
}
