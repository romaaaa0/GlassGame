using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class ArrowRight : MonoBehaviour
    {
        [SerializeField] private GameObject currentModel;
        [SerializeField] private GameObject nextModel;
        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(Switch);
        }
        private void Switch()
        {
            currentModel.SetActive(false);
            nextModel.SetActive(true);
        }
    }
}
