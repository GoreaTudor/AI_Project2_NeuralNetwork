using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    public delegate TResult Function <Tparam, TResult> (Tparam param);

    enum InputFunction {
        Sum, Prod, Min, Max
    }

    enum ActivationFunction {
        Step, Sign, Sigmoid, TanH, Linear, 
        Identity // for input layer
    }

    enum OutputFunction {
        Real, Binary
    }
}
