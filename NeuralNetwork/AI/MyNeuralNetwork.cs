using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    public class MyNeuralNetwork {
        private Layer inputLayer;
        private List <Layer> hiddenLayers;
        private Layer outputLayer;

        public MyNeuralNetwork () {
            inputLayer = new Layer(this, -1);

            hiddenLayers = new List<Layer>();
            hiddenLayers.Add(new Layer(this, 1));

            outputLayer = new Layer(this, 0);
        }


        public List <Double> feedforward (List <Double> inputs) {
            // Input Layer
            List <Double> layerOutput = inputLayer.feedThroughLayer(inputs);

            // all Hidden Layers
            foreach (Layer layer in hiddenLayers) {
                layerOutput = layer.feedThroughLayer(layerOutput);
            }

            // Output Layer
            List <Double> output = outputLayer.feedThroughLayer(layerOutput);
            return output;
        }


        public void increaseNumberOfNeurons (int layerNumber) {
            switch (layerNumber) {
                case -1: { // IL
                    inputLayer.increaseNumberOfWeights(); // first increase the number of weights
                    inputLayer.increaseNumberOfNeurons(); // then the number of neurons
                    hiddenLayers[0].increaseNumberOfWeights(); // next layer of input layer is the first hidden layer
                } break;

                case 0: { // OL
                    outputLayer.increaseNumberOfNeurons(); // there is no next layer for the output layer
                } break;

                default: { // HL
                    int index = layerNumber - 1; // the index of the current layer (the one that changes the number of neurons)
                    hiddenLayers[index].increaseNumberOfNeurons(); 

                    if (layerNumber == hiddenLayers.Count) { // next layer of last hidden layer is output layer
                        outputLayer.increaseNumberOfWeights();

                    } else { // if it's not the last HL, then next is the next HL from the list
                        hiddenLayers[index + 1].increaseNumberOfWeights();
                    }
                } break;
            }
        }

        public void decreaseNumberOfNeurons (int layerNumber) {
            switch (layerNumber) {
                case -1: { // IL
                    inputLayer.decreaseNumberOfNeurons();
                    hiddenLayers[0].decreaseNumberOfWeights(); // next layer of input layer is the first hidden layer
                }
                break;

                case 0: { // OL
                    outputLayer.decreaseNumberOfNeurons(); // there is no next layer for the output layer
                }
                break;

                default: { // HL
                    int index = layerNumber - 1; // the index of the current layer (the one that changes the number of neurons)
                    hiddenLayers[index].decreaseNumberOfNeurons();

                    if (layerNumber == hiddenLayers.Count) { // next layer of last hidden layer is output layer
                        outputLayer.decreaseNumberOfWeights();

                    } else { // if it's not the last HL, then next is the next HL from the list
                        hiddenLayers[index + 1].decreaseNumberOfWeights();
                    }
                }
                break;
            }
        }

        /// <summary>
        /// Adds a new layer <b>at the end</b> of the list of hidden layers
        /// </summary>
        public void increaseNumberOfHiddenLayers () {
            Layer newLayer = new Layer(this, this.hiddenLayers.Count);
            newLayer.setNumberOfWeights(this.outputLayer.getNumberOfWeights()); // new layer nr of weights := output layer nr of weights

            this.outputLayer.setNumberOfWeights(1); // set the number of weights on OL to 1

            this.hiddenLayers.Add(newLayer); // add the new layer at the end of HL list
        }

        /// <summary>
        /// Deletes <b>the last</b> layer from the list of hidden layers
        /// </summary>
        public void decreaseNumberOfHiddenLayers () {
            int lastPosition = this.hiddenLayers.Count - 1;
            this.outputLayer.setNumberOfWeights(this.hiddenLayers[lastPosition].getNumberOfWeights()); // nr of weights on OL := nr of weights on last HL

            this.hiddenLayers.RemoveAt(lastPosition); // delete the last layer from HL list
        }

        public void updateFunctions (
            int layerNumber, 
            InputFunction inputf, ActivationFunction activationf, OutputFunction outputf, 
            Double theta, Double g
        ) {
            Layer layer;

            if (layerNumber == 0) { // update the output layer
                layer = this.outputLayer;

            } else { // update the hidden layer
                int position = layerNumber - 1;
                layer = this.hiddenLayers[position];
            }

            layer.setInputFunction(inputf);
            layer.setActivationFunction(activationf, theta, g);
            layer.setOutputFunction(outputf);
        }
    }
}
