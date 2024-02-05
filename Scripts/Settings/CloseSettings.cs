using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class CloseSettings : MonoBehaviour
    {
        [SerializeField] private GameObject settingsPanel;
        private void Start()
        {
            var button = GetComponent<Button>();
            button.onClick.AddListener(Close);
        }
        private void Close()
        {
            settingsPanel.SetActive(false);
        }
    }
}
