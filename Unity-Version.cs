    public class Neuron
    {
        public List<float> weights = new List<float>();
        public float bias = 1.0f;

        public Neuron(int NeuronsInLastLayer)
        {
            for (int i = 0; i < NeuronsInLastLayer; i++)
            {
                weights.Add(UnityEngine.Random.Range(-1, 1));
            }
        }
        public float GetOutput(List<float> inputs)
        {
            float total = 0;
            for (int i = 0; i < inputs.Count; i++)
            {
                total += inputs[i] * weights[i];
            }
            total += bias;
            return Sigmoid(total);
        }
    }
    public static float Sigmoid(double value)
    {
        return 1.0f / (1.0f + (float)Math.Exp(-value));
    }
