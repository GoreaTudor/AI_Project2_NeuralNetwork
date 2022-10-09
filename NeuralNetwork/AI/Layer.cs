using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    class Layer {
        private Function <List<Double>, Double> InputFunction;
        private Function <Double, Double> ActivationFunction;
        private ActivationFunction ActivationFunctionType;
        private Function <Double, Double> OutputFunction;

        private MyNeuralNetwork parent;
        private Neuron[] neurons;
        private Double theta;
        private Double g;
        

        public Layer(MyNeuralNetwork parent) {
            this.parent = parent;

            /// Default values ///
            setInputFunction(AI.InputFunction.Sum);
            setActivationFunction(AI.ActivationFunction.Sigmoid, 0.0, 1.0);
            setOutputFunction(AI.OutputFunction.Real);
        }

        public List<Double> feedThroughLayer (List<Double> inputs) {
            return null;
        }


        public void setInputFunction (InputFunction function) {
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
            ActivationFunctionType = function;
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
            }
        }

        public void setOutputFunction (OutputFunction function) {
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


        public Function <List<Double>, Double> getInputFunction () {
            return InputFunction;
        }

        public Function<Double, Double> getActivationFunction () {
            return ActivationFunction;
        }

        public Function<Double, Double> getOutputFunction () {
            return OutputFunction;
        }
    }
}
