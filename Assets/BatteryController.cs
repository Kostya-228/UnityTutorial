using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryController : MonoBehaviour
{
    [SerializeField]
    Battery[] batteries;


    private void Start()
    {
        for (int i = 0; i < batteries.Length; i++)
        {
            int loc_i = i;
            batteries[i].OnCollect += () => B_OnCollect(loc_i);
        }
    }

    private void B_OnCollect(int index)
    {
        if (index + 1 < batteries.Length)
            batteries[index + 1].gameObject.SetActive(true);
    }
}
