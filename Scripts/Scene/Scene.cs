using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets
{
    public class Scene : MonoBehaviour
    {
        public static void Menu()
        {
            SceneManager.LoadScene(0);
        }
        public static void Levels()
        {
            SceneManager.LoadScene(3);
        }
        public static void Game()
        {
            SceneManager.LoadScene(1);
            Information.CurrentGameState = Information.GameState.Playing;
        }
        public static void Game(int index)
        {
            SceneManager.LoadScene(index);
            Information.CurrentGameState = Information.GameState.Playing;
        }
        public static void Reload()
        {
            Information.CurrentGameState = Information.GameState.Playing;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public static void NextLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Information.CurrentGameState = Information.GameState.Playing;
        }
    }
}
