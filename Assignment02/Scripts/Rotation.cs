using UnityEngine;
using UnityEngine.EventSystems;

public class Rotation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;

    private bool isPointerOverCube2;
    private bool isXButtonPressed;

    private void Update()
    {
        // Check if the X button is pressed
        isXButtonPressed = Input.GetButton("js2");

        // Check if the pointer is over Cube2
        if (isPointerOverCube2 && isXButtonPressed)
        {
            // Rotate Cube2 continuously in the y-axis direction
            cube2.transform.Rotate(Vector3.up, Time.deltaTime * 50.0f);
        }
        else
        {
            // Stop rotating Cube2
            cube2.transform.rotation = cube2.transform.rotation;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Check which object the pointer is over and set a flag accordingly
        if (eventData.pointerCurrentRaycast.gameObject == cube2)
        {
            isPointerOverCube2 = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Reset the flag when the pointer exits the object
        isPointerOverCube2 = false;
    }
}
