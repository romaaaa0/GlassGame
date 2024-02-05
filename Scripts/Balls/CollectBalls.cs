using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class CollectBalls : MonoBehaviour
    {
        public int NumberOfCollectBalls { get; set; }
        public int RequestBalls { get { return requestBalls; } }
        [SerializeField] private int requestBalls;
        [SerializeField] private Text numberOfBallsText;
        [SerializeField] private WinGame winGame;
        [SerializeField] private LoseGame loseGame;
        [SerializeField] private Text coinsText;
        private void OnCollisionEnter(Collision collision)
        {
            NumberOfCollectBalls++;
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            coinsText.text = PlayerPrefs.GetInt("Coins").ToString();
            numberOfBallsText.text = NumberOfCollectBalls.ToString() + "/" + requestBalls;
            Destroy(collision.gameObject);
            loseGame.NumberOfBallsOnScene--;
            if (NumberOfCollectBalls >= requestBalls)
                Information.CurrentGameState = Information.GameState.Win;
        }
    }
}
