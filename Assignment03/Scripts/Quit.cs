using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public Button QuitButton;

    private void Start()
    {
        if (QuitButton == null)
        {
            Debug.LogError("Quit button reference not set in Quit script.");
            return;
        }

        QuitButton.onClick.AddListener(QuitApplication);
    }

    public void QuitApplication()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
