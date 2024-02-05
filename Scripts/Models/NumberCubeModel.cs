using UnityEngine;

namespace Assets
{
    public class NumberCubeModel : MonoBehaviour, IModels
    {
        public int CodeSelect { get; set; } = 1;
        public string CodeBuy { get; set; } = "NumberCube";
    }
}