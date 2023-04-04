using UnityEngine;
using UnityEngine.EventSystems;

public class Translation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;

    private bool isPointerOverCube1;
    private bool isXButtonPressed;

    private void Update()
    {
        // Check if the X button is pressed
        isXButtonPressed = Input.GetButton("js2");

        // Check if the pointer is over Cube1
        if (isPointerOverCube1 && isXButtonPressed)
        {
            // Move Cube1 in the direction of the y-axis
            cube1.transform.position += Vector3.up * Time.deltaTime;
        }
        else
        {
            // Stop moving Cube1
            cube1.transform.position = cube1.transform.position;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Check which object the pointer is over and set a flag accordingly
        if (eventData.pointerCurrentRaycast.gameObject == cube1)
        {
            isPointerOverCube1 = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Reset the flag when the pointer exits the object
        isPointerOverCube1 = false;
    }
}
