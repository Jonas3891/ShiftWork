using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastController : MonoBehaviour
{
    public float rayRange = 4;

    void Update()
    {
        CastRay();
    }

    void CastRay()
    {
        RaycastHit hitInfo = new RaycastHit();
        bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo, rayRange);
        if (hit)
        {
            GameObject hitObject = hitInfo.transform.gameObject;
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hitObject.GetComponent<IInteractable>() != null)
                {
                    hitObject.GetComponent<IInteractable>().interact();
                }
            }
        }
    }
}