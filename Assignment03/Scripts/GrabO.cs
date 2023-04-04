using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabO : MonoBehaviour
{
    public GameObject reticle;
    public GameObject grabOb;
    public bool grab = false;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Grab()
    {
        grabOb.transform.position = reticle.transform.position;
    }

    void Update()
    {
        if(grab) 
        {
            Grab();

        }
        if (Input.GetButtonDown("js3"))
        {
            grab = false;
        }
    }
}
