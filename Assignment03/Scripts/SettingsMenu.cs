using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu: MonoBehaviour
{
    public GameObject Panel;
    public GameObject player;
    public float speed = 0f;

    public void SetSpeed() 
    {
        if (GameObject.Find("Character").GetComponent<CharacterMovement>().speed == 5f) 
        {
            speed = 10f;
        }
        else if (GameObject.Find("Character").GetComponent<CharacterMovement>().speed == 10f)
        {
            speed = 20f;
        }
        else if (GameObject.Find("Character").GetComponent<CharacterMovement>().speed == 20f)
        {
            speed = 5f;
        }
        GameObject.Find("Character").GetComponent<CharacterMovement>().speed = speed;
    }

    void Update() 
    {

        if (Input.GetButtonDown("js1")) 
        {

            //this.gameObject.transform.position = player.transform.position;
            Panel.SetActive(true);
        }
    }
}


