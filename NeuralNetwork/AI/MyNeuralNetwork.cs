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
            inputLayer = new Layer(this);

            hiddenLayers = new List<Layer>();
            hiddenLayers[0] = new Layer(this);

            outputLayer = new Layer(this);
        }

        public List<Double> feedforward(List <Double> inputs) {
            return null;
        }
    }
}
