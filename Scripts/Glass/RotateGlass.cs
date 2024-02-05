using UnityEngine;

namespace Assets
{
    public class RotateGlass : MonoBehaviour
    {
        private void Update()
        {
            Rotate();
        }
        private void Rotate()
        {
            if (Information.CurrentGameState != Information.GameState.Playing) return;
            var canGlassRotate = new CheckRaycast().Check();
            if (Input.GetMouseButtonUp(0))
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            if (canGlassRotate)
            {
                transform.rotation = Quaternion.Euler(0, 0, -80);
            }
        }
    }
}
