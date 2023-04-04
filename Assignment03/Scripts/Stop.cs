using UnityEngine;

public class Stop : MonoBehaviour
{
    public GameObject panel1; // Reference to the first panel object
    public GameObject panel2; // Reference to the second panel object

    private CharacterController controller; // Reference to the character controller component

    void Start()
    {
        controller = GetComponent<CharacterController>(); // Get the character controller component from the object this script is attached to
    }

    void Update()
    {
        // Check if either of the panels is active
        if (panel1.activeSelf || panel2.activeSelf)
        {
            // Stop the character's movement by setting the character controller's movement speed to zero
            controller.Move(Vector3.zero);
        }
    }
}
