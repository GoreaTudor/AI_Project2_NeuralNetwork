using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    class Neuron {
        private Layer parent;
        public int layerNumber { get; set; }    // layer ID 
        public int neuronNumber { get; set; }   // neuron ID
        public List <Double> weights { get; set; }

        public Neuron(Layer parent, int layerNumber, int neuronNumber, int nrOfWeights) {
            this.parent = parent;
            this.layerNumber = layerNumber;
            this.neuronNumber = neuronNumber;

            this.weights = new List <Double> (nrOfWeights);
            for (int i = 0; i < nrOfWeights; i++) {
                this.weights[i] = GlobalStuff.initialWeightValue;
            }
        }

        public Double getOutputValue(List <Double> inputs) {
            Double generalInput = parent.InputFunction(inputs);
            Double activationValue = parent.ActivationFunction(generalInput);
            Double outputValue = parent.OutputFunction(activationValue);

            return outputValue;
        }

        public void increaseNumberOfWeights () {
            this.weights.Add(GlobalStuff.initialWeightValue);
        }

        public void decreaseNumberOfWeights () {
            int lastPosition = this.weights.Count - 1;
            this.weights.RemoveAt(lastPosition);
        }
    }
}
