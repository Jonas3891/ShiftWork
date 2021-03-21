using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public IEnumerator SmoothLerp(float time, GameObject startPos, GameObject endPos)
    {

        Vector3 startingPos = startPos.transform.position;
        Vector3 finalPos = endPos.transform.position;

        float elapsedTime = 0;

        while (elapsedTime < time)
        {
            elapsedTime += Time.deltaTime;
            transform.position = Vector3.Lerp(startingPos, finalPos, (elapsedTime / time));
            yield return null;
        }
    }
}