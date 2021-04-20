using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField]
    UI ui;
    [SerializeField]
    AudioClip collect_sound;
    [SerializeField]
    AudioSource source;

    int battery_count = 0;
    int battery_max = 4;
    bool is_target_counted = false;
    

    public void CollectBattery()
    {
        if (battery_count < battery_max)
        {
            source.clip = collect_sound;
            source.Play();
            battery_count++;
            ui.ShowProgress((float)battery_count / battery_max);
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
