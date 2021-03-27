using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("kek");
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerLogic>().CollectBattery();
            gameObject.SetActive(false);
            Destroy(this);
        }
    }
}
