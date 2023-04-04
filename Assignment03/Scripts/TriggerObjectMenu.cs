using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TriggerObjectMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject objectMenu;
    private bool triggerMenu = false;

    public void OnPointerEnter(PointerEventData eventData)
    {
        triggerMenu = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        triggerMenu = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("js2") && triggerMenu) 
        {
            objectMenu.SetActive(true);
            objectMenu.GetComponent<CloseMenu>().objon = this.gameObject;
        }
    }
}
