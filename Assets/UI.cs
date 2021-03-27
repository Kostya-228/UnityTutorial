using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    Image battary_img;
    [SerializeField]
    GameObject hitn;
    [SerializeField]
    Sprite[] sprites_battary;

    public void ShowProgress(float progress)
    {
        Debug.Log(progress);
        var sprite = sprites_battary[(int)((sprites_battary.Length-1) * progress)];
        battary_img.sprite = sprite;
    }

    public void ShowHint(string text)
    {
        hitn.transform.GetChild(0).GetComponent<Text>().text = text;
        hitn.SetActive(true);
        StartCoroutine(hideHint(4));
    }

    IEnumerator hideHint(float delay)
    {
        yield return new WaitForSeconds(delay);
        hitn.SetActive(false);
    }
}
