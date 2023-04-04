/*using UnityEngine;
using UnityEngine.UI;

public class CloseMenu : MonoBehaviour
{
    
    public GameObject Panel;

    /*private void Start()
    {
        if (ResumeButton == null)
        {
            Debug.LogError("Resume button reference not set in CloseMenu script.");
            return;
        }

        ResumeButton.onClick.AddListener(CloseMenuPanel);
    }

    private void Update()
    {
        if (Input.GetButtonDown("js2"))
        {
            Panel.SetActive(false);
        }
    }

   
        
    
}*/
using UnityEngine;
using UnityEngine.UI;

public class CloseMenu : MonoBehaviour
{
    public Button ExitButton;
    public GameObject Panel;
    public GameObject objon;

    private void Start()
    {
        if (ExitButton == null)
        {
            Debug.LogError("Exit button reference not set in Exit script.");
            return;
        }

        ExitButton.onClick.AddListener(CloseMenuPanel);
    }
     public void CloseMenuPanel()
    {
        Panel.SetActive(false); // Disable the game object of the panel
    }

    public void GrabObje() 
    {
        GameObject.Find("Plane").GetComponent<GrabO>().grabOb = objon;
        GameObject.Find("Plane").GetComponent<GrabO>().grab = true;
        Panel.SetActive(false);

    }

    public void Store() 
    {
        Destroy(objon);
        Panel.SetActive(false);
    }

    /*public void QuitApplication()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }*/
}

