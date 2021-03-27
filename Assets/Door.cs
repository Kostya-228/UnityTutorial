using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    Animation animation;
    [SerializeField]
    UI ui;
    [SerializeField]
    float trigger_distanse = 3;

    bool in_zone = false;
    

    //private void Update()
    //{
    //    RaycastHit hit;
    //    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, Mathf.Infinity))
    //    {
    //        Control(hit);
    //    }
    //    else
    //        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
    //        {
    //            Control(hit);
    //        }
    //}

    //private void Control(RaycastHit hit)
    //{
    //    if (hit.transform.gameObject.tag == "Player")
    //        if (hit.distance < trigger_distanse)
    //        {
    //            if (!in_zone)
    //            {
    //                in_zone = true;
    //                animation.Play("open");
    //            }
    //        }
    //        else
    //        {
    //            if (in_zone)
    //            {
    //                in_zone = false;
    //                animation.Play("close");
    //            }
    //        }
        
    //}




    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
            return;
        var player = other.GetComponent<PlayerLogic>();
        if (player.IsFullBattery())
            animation.Play("open");
        else
            ui.ShowHint("Не достаточно заряда батареи. Соберите батарейки, чтобы открыть дверь");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
            return;
        var player = other.GetComponent<PlayerLogic>();
        if (player.IsFullBattery())
            animation.Play("close");
    }
}
