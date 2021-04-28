using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public delegate void BatteryCollect();

public class Battery : MonoBehaviour
{

    public event BatteryCollect OnCollect;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("kek");
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerLogic>().CollectBattery();
            gameObject.SetActive(false);
            OnCollect?.Invoke();
            Destroy(this);
        }
    }
}
