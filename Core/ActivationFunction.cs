namespace  NeuralNetworkLib.Core.ActivationFunctions;

public abstract class ActivationFunction
{
    public abstract float Compute(float input);
    public virtual void Compute(float[] input)
    {
        for (int i = 0; i < input.Length; i++)
            input[i] = this.Compute(input[i]);
    }

    public abstract float Derivative(float input);
    public virtual void Derivative(float[] input)
    {
        for (int i = 0; i < input.Length; i++)
            input[i] = this.Derivative(input[i]);
    }

}