using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    int battery_count = 0;
    int battery_max = 4;

    [SerializeField]
    UI ui;

    public void CollectBattery()
    {
        if (battery_count < battery_max)
        {
            battery_count++;
            ui.ShowProgress((float)battery_count / battery_max);
        }
    }

    public bool IsFullBattery()
    {
        return battery_count == battery_max;
       
    }
}
