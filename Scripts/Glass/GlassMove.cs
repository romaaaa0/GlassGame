using UnityEngine;

namespace Assets
{
    public class GlassMove : MonoBehaviour
    {
        private float screenWith;
        private float maxPositionGlass;
        private float minPositionGlass;
        private CheckRaycast checkRaycast;
        private void Start()
        {
            checkRaycast = new CheckRaycast();
            screenWith = Screen.width;
            maxPositionGlass = screenWith - 70;
            minPositionGlass = 70;
        }
        private void Update()
        {
            Move();
        }
        private void Move()
        {
            if (Information.CurrentGameState != Information.GameState.Playing) return;
            var canGlassMove = checkRaycast.Check();
            if (canGlassMove)
            {
                var positionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (Input.mousePosition.x < minPositionGlass || Input.mousePosition.x > maxPositionGlass) return;
                transform.position = new Vector2(positionMouse.x, 4);
            }
        }
    }
}
