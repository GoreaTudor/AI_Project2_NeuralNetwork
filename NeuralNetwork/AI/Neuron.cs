using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    class Neuron {
        Layer parent;
        private List <Double> weights;

        public Neuron() {}

        public Neuron(int nrOfWeights) {
            this.weights = new List <Double>(nrOfWeights);
            for (int i = 0; i < nrOfWeights; i++) {
                this.weights[i] = 0;
            }
        }

        public void setWeights(List<Double> weights) {
            this.weights = weights;
        }

        public Double getOutputValue(List <Double> inputs) {
            Function<List <Double>, Double> inputFunction = parent.getInputFunction();
            Function<Double, Double> activationFunction = parent.getActivationFunction();
            Function<Double, Double> outputFunction = parent.getOutputFunction();

            Double generalInput = inputFunction(inputs);
            Double activationValue = activationFunction(generalInput);
            Double outputValue = outputFunction(activationValue);

            return outputValue;
        }
    }
}
