using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets
{
    public class WinGame : MonoBehaviour
    {
        [SerializeField] private GameObject winPanel;
        private bool canFunctionWork = true;
        private void Update()
        {
            if (Information.CurrentGameState == Information.GameState.Win && canFunctionWork)
            {
                winPanel.SetActive(true);
                Information.CurrentGameState = Information.GameState.Lose;
                canFunctionWork = false;
                PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, 1);
            }
        }
    }
}
