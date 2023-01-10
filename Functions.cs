namespace NeuralNetworkLib;

using Core;
using Core.ActivationFunctions;

public static class Functions
{
    private static ActivationFunction reLu = new ReLu();
    public static ActivationFunction ReLu => reLu;
}