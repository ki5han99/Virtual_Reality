using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OutlineController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called before the first frame update
    public Outline outline;
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        eventData.pointerCurrentRaycast.gameObject.GetComponent<Outline>().enabled = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        outline.GetComponent<Outline>().enabled = false;
    }
    
}
