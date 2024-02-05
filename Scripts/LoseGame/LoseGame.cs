using UnityEngine;

namespace Assets
{

    public class LoseGame : MonoBehaviour
    {
        public int NumberOfBallsOnScene { get; set; }
        [SerializeField] private CollectBalls collectBalls;
        [SerializeField] private GameObject lostPanel;
        private bool canFunctionWork = true;
        private void Update()
        {
            if(NumberOfBallsOnScene == 0 && collectBalls.NumberOfCollectBalls < collectBalls.RequestBalls && canFunctionWork)
            {
                lostPanel.SetActive(true);
                Information.CurrentGameState = Information.GameState.Lose;
                canFunctionWork = false;
            }
        }
    }
}
