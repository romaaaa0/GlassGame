using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Buy : MonoBehaviour
    {
        [SerializeField] private GameObject models;
        [SerializeField] private int price;
        [SerializeField] private Text coinsText;
        private IModels iModels;
        private void Start()
        {
            iModels = models.GetComponent<IModels>();
            if (PlayerPrefs.GetInt(iModels.CodeBuy) == 1)
                gameObject.SetActive(false);
            GetComponent<Button>().onClick.AddListener(Click); 
        }
        private void Click()
        {
            if(PlayerPrefs.GetInt("Coins") >= price)
            {
                gameObject.SetActive(false);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - price);
                PlayerPrefs.SetInt(iModels.CodeBuy, 1);
                coinsText.text = PlayerPrefs.GetInt("Coins").ToString();
            }
        }
    }
}
