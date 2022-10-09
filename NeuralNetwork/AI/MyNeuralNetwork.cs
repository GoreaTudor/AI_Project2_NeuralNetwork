using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.AI {
    class MyNeuralNetwork {
        private Layer inputLayer;
        private List <Layer> hiddenLayers;
        private Layer outputLayer;

        public MyNeuralNetwork () {
            inputLayer = new Layer(this, -1);

            hiddenLayers = new List<Layer>();
            hiddenLayers[0] = new Layer(this, 1);

            outputLayer = new Layer(this, 0);
        }


        public List <Double> feedforward(List <Double> inputs) {
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
                    inputLayer.increaseNumberOfNeurons();
                    hiddenLayers[0].increaseNumberOfWeights(); // next layer of input layer is the first hidden layer
                } break;

                case 0: { // OL
                    outputLayer.increaseNumberOfNeurons(); // there is no next layer for the output layer
                } break;

                default: { // HL
                    int index = layerNumber - 1; // the index of the current layer (the one that changes the number of neurons)
                    hiddenLayers[index].increaseNumberOfNeurons(); 

                    if (index == hiddenLayers.Count) { // next layer of last hidden layer is output layer
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

                    if (index == hiddenLayers.Count) { // next layer of last hidden layer is output layer
                        outputLayer.decreaseNumberOfWeights();

                    } else { // if it's not the last HL, then next is the next HL from the list
                        hiddenLayers[index + 1].decreaseNumberOfWeights();
                    }
                }
                break;
            }
        }


        public void increaseNumberOfHiddenLayers () {
            // TODO
        }

        public void decreaseNumberOfHiddenLayers () {
            // TODO
        }
    }
}
