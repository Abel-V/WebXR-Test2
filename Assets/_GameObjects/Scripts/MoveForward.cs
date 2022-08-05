using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public TextMesh textMesh;

    void FixedUpdate()
    {

        if (Input.touchCount == 2)
        {
            textMesh.text = "Two fingers detected";
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;
            textMesh.text = "Two fingers detected. Difference: " + difference.ToString();

            transform.position += transform.forward * difference;
        }
    
    }
}
