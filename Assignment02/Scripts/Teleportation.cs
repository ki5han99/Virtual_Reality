using UnityEngine;
using UnityEngine.EventSystems;

public class Teleportation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;

    private bool isPointerOverSphere;
    private bool isYButtonPressed;

    private void Update()
    {
        // Check if the Y button is pressed
        isYButtonPressed = Input.GetButton("js1");

        // Check if the pointer is over a sphere and the Y button is pressed
        if (isPointerOverSphere && isYButtonPressed)
        {
            // Get the position of the current sphere
            Vector3 spherePosition = transform.position;

            // Swap positions with the sphere
            transform.position = spherePosition;
            if (gameObject == sphere1) {
                sphere1.transform.position = transform.parent.position;
            } else if (gameObject == sphere2) {
                sphere2.transform.position = transform.parent.position;
            } else if (gameObject == sphere3) {
                sphere3.transform.position = transform.parent.position;
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Check which object the pointer is over and set a flag accordingly
        if (eventData.pointerCurrentRaycast.gameObject == sphere1 ||
            eventData.pointerCurrentRaycast.gameObject == sphere2 ||
            eventData.pointerCurrentRaycast.gameObject == sphere3)
        {
            isPointerOverSphere = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Reset the flag when the pointer exits the object
        isPointerOverSphere = false;
    }
    
}
