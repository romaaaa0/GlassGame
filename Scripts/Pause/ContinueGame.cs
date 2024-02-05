using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class ContinueGame : MonoBehaviour
    {
        [SerializeField] private GameObject pausePanel;
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(Continue);
        }
        private void Continue()
        {
            pausePanel.SetActive(false);
            Information.CurrentGameState = Information.GameState.Playing;
            Time.timeScale = 1;
        }
    }
}
