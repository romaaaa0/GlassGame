using UnityEngine;

namespace Assets
{
    public class Multiplier : MonoBehaviour
    {
        public int Code;
        public int MultiplicationFactor { get { return multiplicationFactor; } }
        [SerializeField] private int multiplicationFactor;
    }
}
