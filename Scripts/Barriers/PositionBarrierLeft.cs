using UnityEngine;

namespace Assets
{
    public class PositionBarrierLeft : MonoBehaviour
    {
        private void Start()
        {
            var screen = new Vector3(-70, Screen.height / 2, 10);
            transform.position = Camera.main.ScreenToWorldPoint(screen);
        }
    }
}
