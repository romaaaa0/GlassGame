using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class PauseGame : MonoBehaviour
    {
        [SerializeField] private GameObject pausePanel;
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(Pause);
        }
        private void Pause()
        {
            pausePanel.SetActive(true);
            Information.CurrentGameState = Information.GameState.Pause;
            Time.timeScale = 0;
        }
    }
}
