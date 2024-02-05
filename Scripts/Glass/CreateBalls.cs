using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class CreateBalls : MonoBehaviour
    {
        [SerializeField] private GameObject balls;
        [SerializeField] private Vector3 offSet;
        [SerializeField] private int ballsAvailable;
        [SerializeField] private Text ballsAvailableText;
        [SerializeField] private LoseGame loseGame;
        private float startTime = 0.3f;
        private float timeCreateBalls = 0.3f;
        private float timer;
        private CheckRaycast checkRaycast;
        private void Start()
        {
            checkRaycast = new CheckRaycast();
            loseGame.NumberOfBallsOnScene = ballsAvailable;
            ballsAvailableText.text = ballsAvailable.ToString();
            timer = startTime;
        }
        private void Update()
        {
            Create();
        }
        private void Create()
        {
            if (ballsAvailable <= 0 || Information.CurrentGameState != Information.GameState.Playing) return;
            var canCreateBalls = checkRaycast.Check();
            if (canCreateBalls)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    Instantiate(balls, transform.position + offSet, balls.transform.rotation);
                    ballsAvailable--;
                    ballsAvailableText.text = ballsAvailable.ToString();
                    timer = timeCreateBalls;
                }
            }
            else if (canCreateBalls)
                timer = startTime;
        }
    }
}