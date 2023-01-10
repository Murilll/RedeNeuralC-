namespace NeuralNetworkLib.ActivationFunctions;

public class ReLu : ActivationFunction
{
    public override float Compute(float input)
    {
        if (input < 0f)
            return 0f;
        return input;
    }

    public override float Derivative(float input)
    {
        if (input < 0f)
            return 0f;
        return input;
    }
}