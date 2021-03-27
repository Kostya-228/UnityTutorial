using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    Animation animation;
    [SerializeField]
    PlayerLogic playerLogic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cocount")
        {
            animation.Play("down");
            playerLogic.Target();
            StartCoroutine(Delay(2));
        }
    }

    IEnumerator Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
        animation.Play("up");
    }
}
