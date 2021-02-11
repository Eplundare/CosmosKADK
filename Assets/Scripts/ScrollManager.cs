using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollManager : MonoBehaviour
{
    public Transform textAndMediaObj;

    public float currentY;
    public float incrementAmount;

    public Vector3 vector;

    public void Update()
    {
        textAndMediaObj.transform.localPosition = vector;
    }

    public void MoveUp()
    {
        currentY += incrementAmount;
        vector = new Vector3(0, currentY, 0);

    }

    public void MoveDown()
    {
        currentY -= incrementAmount;
        vector = new Vector3(0, currentY, 0);
    }

    public void RestoreInitialPosition()
    {
        currentY = 0f;
    }
}
