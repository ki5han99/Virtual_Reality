using UnityEngine;

public class Store : MonoBehaviour
{
    public GameObject objectToDestroy;
    public KeyCode destroyKey = KeyCode.Space;

    // Update is called once per frame
    void Update()
    {
        // Check if the player has pressed the destroyKey
        if (Input.GetKeyDown(destroyKey))
        {
            // Destroy the objectToDestroy game object
            Destroy(objectToDestroy);
        }
    }
}
