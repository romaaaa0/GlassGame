using UnityEngine;

namespace Assets
{
    public class MinusBalls : MonoBehaviour
    {
        private LoseGame loseGame;
        private void Start()
        {
            loseGame = GameObject.FindObjectOfType<LoseGame>();
        }
        private void OnTriggerEnter(Collider other)
        {
            Minus(other);
        }
        private void Minus(Collider other)
        {
            if (other.gameObject.GetComponent<Minus>())
            {
                var minus = other.gameObject.GetComponent<Minus>();
                minus.NumberOfBallsTakeAway++;
                Destroy(gameObject);
                loseGame.NumberOfBallsOnScene--;
            }
        }
    }
}
