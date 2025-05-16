using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffset;
    public Vector3 FPcameraOffset;
    private bool isFirstPerson;

    private void LateUpdate()
    {
        //Method 2, using a variable for the offset
        transform.position = player.position + cameraOffset;

        if(Input.GetKeyDown(KeyCode.P))
        {
            if(isFirstPerson == false)
            {
                cameraOffset = FPcameraOffset;
                isFirstPerson = true;
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else
            {
                cameraOffset = new Vector3(0, 11.5f, -12);
                isFirstPerson = false;
                transform.rotation = Quaternion.Euler(30, 0, 0);
            }
            
        }

    }
}
