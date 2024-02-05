using UnityEngine;

namespace Assets
{
    public class RubiksCubeModel : MonoBehaviour, IModels
    {
        public int CodeSelect { get; set; } = 2;
        public string CodeBuy { get; set; } = "RubiksCube";
    }
}