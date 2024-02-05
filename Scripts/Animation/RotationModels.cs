using UnityEngine;

namespace Assets
{
    public class RotationModels : MonoBehaviour
    {
        [SerializeField] private float speedRotation;
        private void Update()
        {
            transform.Rotate(Vector3.up * speedRotation * Time.deltaTime);
        }
    }
}
