using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CocountLauncher : MonoBehaviour
{
    public GameObject cocunt;
    [SerializeField]
    int throwForce = 40;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            var obj = Instantiate(cocunt, transform.position, transform.rotation);
            obj.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0, throwForce));
        }
    }
}
