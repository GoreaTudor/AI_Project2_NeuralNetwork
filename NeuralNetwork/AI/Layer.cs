using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    class Layer {
        public Function <List<Double>, Double> InputFunction { get; set; }
        public Function <Double, Double> ActivationFunction { get; set; }
        public Function <Double, Double> OutputFunction { get; set; }

        public InputFunction InputFunctionType { get; set; }
        public ActivationFunction ActivationFunctionType { get; set; }
        public OutputFunction OutputFunctionType { get; set; }

        public Double theta { get; set; }
        public Double g { get; set; }

        private MyNeuralNetwork parent;
        private List<Neuron> neurons;
        private int layerNumber;     


    public Layer (MyNeuralNetwork parent, int layerNumber) {
            this.parent = parent;
            this.layerNumber = layerNumber;
            this.neurons = new List<Neuron>();

            // TODO  -  add first neuron
            Neuron firstNeuron = new Neuron(this, layerNumber, 0, 1);
            this.neurons.Add(firstNeuron);

            /// Default functions ///
            setInputFunction(AI.InputFunction.Sum);
            if (layerNumber < 0) {
                setActivationFunction(AI.ActivationFunction.Identity, 0.0, 1.0);
            } else {
                setActivationFunction(AI.ActivationFunction.Sigmoid, 0.0, 1.0);
            }
            setOutputFunction(AI.OutputFunction.Real);
        }


        public List <Double> feedThroughLayer (List <Double> inputs) {
            List <Double> output = new List <Double> ();

            foreach (Neuron neuron in neurons) {
                output.Add(neuron.getOutputValue(inputs));
            }

            return output;
        }


        public void increaseNumberOfNeurons () {
            Neuron neuron = new Neuron(this, layerNumber, this.neurons.Count, this.neurons[0].weights.Count);
            this.neurons.Add(neuron);
        }

        public void decreaseNumberOfNeurons () {
            int lastPosition = this.neurons.Count - 1;
            this.neurons.RemoveAt(lastPosition);
        }

        public void increaseNumberOfWeights () {
            for (int i = 0; i < this.neurons.Count; i++) {
                neurons[i].increaseNumberOfWeights();
            }
        }

        public void decreaseNumberOfWeights () {
            for (int i = 0; i < this.neurons.Count; i++) {
                neurons[i].decreaseNumberOfWeights();
            }
        }


        public void setNumberOfWeights (int nrOfWeights) {
            for (int i = 0; i < this.neurons.Count; i++) {
                neurons[i].setNumberOfWeights(nrOfWeights);
            }
        }

        public int getNumberOfWeights () {
            return neurons[0].getNumberOfWeights();
        }


        public void setInputFunction (InputFunction function) {
            this.InputFunctionType = function;

            switch (function) {
                case AI.InputFunction.Sum: {
                    InputFunction = weightedInputs => {
                        Double sum = 0.0;
                        foreach (Double item in weightedInputs) {
                            sum += item;
                        }
                        return sum;
                    };
                } break;

                case AI.InputFunction.Prod: {
                    InputFunction = weightedInputs => {
                        Double prod = 1.0;
                        foreach (Double item in weightedInputs) {
                            prod *= item;
                        }
                        return prod;
                    };
                }
                break;

                case AI.InputFunction.Min: {
                    InputFunction = weightedInputs => {
                        Double min = weightedInputs[0];
                        foreach (Double item in weightedInputs) {
                            if (item < min) {
                                min = item;
                            }
                        }
                        return min;
                    };
                }
                break;

                case AI.InputFunction.Max: {
                    InputFunction = weightedInputs => {
                        Double max = weightedInputs[0];
                        foreach (Double item in weightedInputs) {
                            if (item > max) {
                                max = item;
                            }
                        }
                        return max;
                    };
                }
                break;

            }
        }

        public void setActivationFunction (ActivationFunction function, Double theta, Double g) {
            this.ActivationFunctionType = function;
            this.theta = theta;
            this.g = g;

            switch(function) {
                case AI.ActivationFunction.Step: {
                    ActivationFunction = (x => { 
                        return ((x < theta) ? 0.0 : 1.0); 
                    });
                } break;

                case AI.ActivationFunction.Sign: {
                    ActivationFunction = (x => { 
                        return ((x < theta) ? -1.0 : 1.0); 
                    });
                } break;

                case AI.ActivationFunction.Sigmoid: {
                    // sigmoid(x) = 1 / (1 + e ^ (-g * (x - theta)))
                    ActivationFunction = (x => {
                        return (1.0 / (1 + Math.Exp(-g * (x - theta))));
                    });
                } break;

                case AI.ActivationFunction.TanH: {
                    ActivationFunction = (x => {
                        // tanh(x) = (e^(g*(x-theta) - e^(-g*(x-theta))) / (e^(g*(x-theta) + e^(-g*(x-theta))
                        Double x1 = Math.Exp(g * (x - theta)); // e^(g*(x-theta))
                        Double x2 = Math.Exp(-g * (x - theta)); // e^(-g*(x-theta))
                        return (x1 - x2) / (x1 + x2);
                    });
                } break;

                case AI.ActivationFunction.Linear: {
                    ActivationFunction = (x => {
                        if (x < -1 / g) return -1.0;
                        if (x > 1 / g) return 1.0;
                        return g * x;
                    });
                } break;

                case AI.ActivationFunction.Identity: {
                    ActivationFunction = (x => {
                        return x;
                    });
                }
                break;
            }
        }

        public void setOutputFunction (OutputFunction function) {
            this.OutputFunctionType = function;

            if (function == AI.OutputFunction.Real 
                || ActivationFunctionType == AI.ActivationFunction.Step 
                || ActivationFunctionType == AI.ActivationFunction.Sign
            ) {
                OutputFunction = (x => x);

            } else {
                if (ActivationFunctionType == AI.ActivationFunction.Sigmoid) {
                    OutputFunction = (x => ((x < 0.5) ? 0.0 : 1.0));

                } else { // Linear & TanH
                    OutputFunction = (x => ((x < 0.0) ? -1.0 : 1.0));
                }
            }
        }


        public List <Double> getWeights (int neuronNumber) {
            return neurons[neuronNumber].weights;
        }

        public void setWeights (int neuronNumber, List <Double> weights) {
            neurons[neuronNumber].weights = weights;
        }

        public int getNumberOfNeurons () {
            return this.neurons.Count;
        }
    }
}
