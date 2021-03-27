using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cocount : MonoBehaviour
{
    [SerializeField]
    int liveTime = 10;
    void Start()
    {
        StartCoroutine(Life(liveTime));
    }

    IEnumerator Life(float delay)
    {
        yield return new WaitForSeconds(delay);
        this.gameObject.SetActive(false);
        Destroy(this);
    }
}
