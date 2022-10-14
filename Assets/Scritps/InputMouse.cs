using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMouse : MonoBehaviour
{
    private float speed = 2.5f;
    private string mouseY = "Mouse Y";
    private string mouseX = "Mouse X";
    private void Update()
    {
        float inputMouseX = Input.GetAxis(mouseX);
        float inputMouseY = Input.GetAxis(mouseY);

        transform.Translate(new Vector3(inputMouseX * speed * Time.deltaTime,
                                        inputMouseY * speed * Time.deltaTime, 0));
    }
}
