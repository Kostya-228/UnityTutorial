using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    Animation animation;
    [SerializeField]
    float trigger_distanse = 3;

    bool in_zone = false;
    

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, Mathf.Infinity))
        {
            Control(hit);
        }
        else
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                Control(hit);
            }
    }

    private void Control(RaycastHit hit)
    {
        if (hit.transform.gameObject.tag == "Player")
            if (hit.distance < trigger_distanse)
            {
                if (!in_zone)
                {
                    in_zone = true;
                    animation.Play("open");
                }
            }
            else
            {
                if (in_zone)
                {
                    in_zone = false;
                    animation.Play("close");
                }
            }
        
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    a.Play("open");
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    a.Play("close");
    //}
}
