using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

    public void SwitchToSecondCamera()
    {
        cam1.enabled = false;
        cam2.enabled = true;
        Debug.Log("Button Pressed - Switching Camera");

    }

    public void SwitchToFirstCamera()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }
}
