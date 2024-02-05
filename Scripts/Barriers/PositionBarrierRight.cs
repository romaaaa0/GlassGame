using UnityEngine;

namespace Assets
{
    public class PositionBarrierRight : MonoBehaviour
    {
        private void Start()
        {
            var screen = new Vector3(Screen.width + 70, Screen.height / 2, 10);
            transform.position = Camera.main.ScreenToWorldPoint(screen);
        }
    }
}
