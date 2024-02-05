using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class SetCoins : MonoBehaviour
    {
        [SerializeField] private Text coinsText;
        private void Start()
        {
            Set();
        }
        private void Set()
        {
            coinsText.text = PlayerPrefs.GetInt("Coins").ToString();
        }
    }
}
