using UnityEngine;

namespace Assets
{
    public class EmojiCubeModel : MonoBehaviour, IModels
    {
        public int CodeSelect { get; set; } = 3;
        public string CodeBuy { get; set; } = "Emoji";
    }
}