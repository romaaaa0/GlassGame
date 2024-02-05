using UnityEngine;

namespace Assets
{
    public class UnlockLevels : MonoBehaviour
    {
        [SerializeField] private GameObject nextLock;
        private void Start()
        {
            if (PlayerPrefs.GetInt(gameObject.name) == 1)
                nextLock.SetActive(false);
        }
    }
}
