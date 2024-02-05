using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class OpenSettings : MonoBehaviour
    {
        [SerializeField] private GameObject settingsPanel;
        private void Start()
        {
            var button = GetComponent<Button>();
            button.onClick.AddListener(Open);
        }
        private void Open()
        {
            settingsPanel.SetActive(true);
        }
    }
}
