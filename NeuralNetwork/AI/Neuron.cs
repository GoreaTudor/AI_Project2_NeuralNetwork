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

            setNumberOfWeights(nrOfWeights);
        }

        public Double getOutputValue(List <Double> inputs) {
            Double generalInput = parent.InputFunction(getWeightedInputs(inputs));
            Double activationValue = parent.ActivationFunction(generalInput);
            Double outputValue = parent.OutputFunction(activationValue);

            return outputValue;
        }

        private List <Double> getWeightedInputs (List <Double> inputs) {
            List <Double> weightedInputs = new List <Double> ();
            for (int i = 0; i < inputs.Count; i++) {
                weightedInputs.Add(inputs[i] * weights[i]);
            }
            return weightedInputs;
        }


        public void increaseNumberOfWeights () {
            if (layerNumber < 0) { // IL
                if (neuronNumber == weights.Count) {
                    this.weights.Add(1.0);
                } else {
                    this.weights.Add(0.0);
                }
            } else { // HL or OL
                this.weights.Add(GlobalStuff.initialWeightValue);
            }
        }

        public void decreaseNumberOfWeights () {
            int lastPosition = this.weights.Count - 1;
            this.weights.RemoveAt(lastPosition);
        }


        public void setNumberOfWeights (int nrOfWeights) {
            this.weights = new List <Double> ();
            
            if (this.layerNumber < 0) { // IL
                for (int i = 0; i < nrOfWeights; i++) {
                    if (i == neuronNumber) {
                        this.weights.Add(1.0);
                    } else {
                        this.weights.Add(0.0);
                    }
                }

            } else { // HL or OL
                for (int i = 0; i < nrOfWeights; i++) {
                    this.weights.Add(GlobalStuff.initialWeightValue);
                }
            }
        }

        public int getNumberOfWeights () {
            return this.weights.Count;
        }
    }
}
