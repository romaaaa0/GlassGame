using System;
using UnityEngine;

namespace Assets
{
    public class CheckRaycast
    {
        private bool check;
        public bool Check()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (Input.GetMouseButtonDown(0) && hit.collider.gameObject.GetComponent<GlassMove>())
                {
                    check = true;
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                check = false;
            }
            if (Input.GetMouseButton(0) && check)
                return true;
            return false;
        }
    }
}
