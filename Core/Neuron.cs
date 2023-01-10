namespace NeuralNetworkLib.Core;

public class Neuron
{  
    public float[] Weights { get; private set; }
    public float Bias { get; private set; }
    public ActivationFunction Function { get; set; }

    public float Output(float[] input)
    {
        if (input.Length != this.Weights.Length)
            throw new InvalidParameterSizeException();

        float s = Bias;
        for (int i = 0; i < input.Length; i++)
            s += this.Weights[i] * input[i];

        float z = Function.Compute(s);
        return z;
    }
}