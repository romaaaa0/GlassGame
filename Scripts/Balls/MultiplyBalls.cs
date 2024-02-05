using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class MultiplyBalls : MonoBehaviour
    {
        public List<int> HashCode { get; set; } = new List<int>();
        private LoseGame loseGame;
        private Vector3 offSet = new Vector3(0f, -0.2f, 0);
        private void Start()
        {
            if (loseGame == null)
                loseGame = GameObject.FindObjectOfType<LoseGame>();
        }
        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(Multiply(other));
        }
        private IEnumerator Multiply(Collider other)
        {
            if (other.gameObject.GetComponent<Multiplier>())
            {
                var multiplier = other.gameObject.GetComponent<Multiplier>();
                if (!HashCode.Contains(multiplier.Code))
                {
                    for (var i = 0; i < multiplier.MultiplicationFactor - 1; i++)
                    {
                        yield return new WaitForSeconds(0.06f);
                        var balls = Instantiate(gameObject, transform.position + offSet, transform.rotation);
                        loseGame.NumberOfBallsOnScene++;
                        HashCode.Add(multiplier.Code);
                        var hashCodeBalls = balls.GetComponent<MultiplyBalls>().HashCode;
                        hashCodeBalls.Add(multiplier.Code);
                    }
                }
            }
        }
    }
}