using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class AnimationWinPanel : MonoBehaviour
    {
        [SerializeField] private List<GameObject> stars;
        [SerializeField] private Text textPercent;
        private float percent;
        private bool canFunctionWork = true;
        private void Update()
        {
            PlayAnimation();
        }
        private void PlayAnimation()
        {
            if (percent < 100)
            {
                percent += Time.deltaTime * 70;
                textPercent.text = Mathf.Round(percent).ToString() + "%";
            }
            if(canFunctionWork)
            {
                StartCoroutine(Animation());
                canFunctionWork = false;
            }
        }
        private IEnumerator Animation()
        {
            for (var i = 0; i < stars.Count; i++)
            {
                stars[i].SetActive(true);
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}
