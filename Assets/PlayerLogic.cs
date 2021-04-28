using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField]
    UI ui;

    int battery_count = 0;
    int battery_max = 4;
    bool is_target_counted = false;

    public void CollectBattery()
    {
        if (battery_count < battery_max)
        {
            battery_count++;
            ui.ShowProgress((float)battery_count / battery_max);
            if (battery_count != battery_max)
                ui.ShowHint($"не хватает {battery_max - battery_count} батарейки для открытия двери");
            else
                ui.ShowHint($"батарейки собраны!");
        }
    }

    public bool IsFullBattery()
    {
        return battery_count == battery_max;
    }

    public void Target()
    {
        if (!is_target_counted)
        {
            CollectBattery();
            is_target_counted = true;
        }
    }
}
