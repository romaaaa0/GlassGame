using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Minus : MonoBehaviour
    {
        public int NumberOfBallsTakeAway { get { return numberOfBallsTakeAway; } set { numberOfBallsTakeAway = value; } }
        [SerializeField] private int numberOfBallsTakeAway;
        [SerializeField] private Text numberOfBallsTakeAwayText;
        private void Update()
        {
            numberOfBallsTakeAwayText.text = NumberOfBallsTakeAway.ToString();
            if (NumberOfBallsTakeAway >= 0)
            {
                numberOfBallsTakeAwayText.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
