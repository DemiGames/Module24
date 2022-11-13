using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoSomeActions : MonoBehaviour
{
    public Rigidbody rb;
    public void RaiseCube()
    {
        gameObject.transform.localScale = new Vector3(2, 2, 2);
    }
    public void PushCube()
    {
        Vector3 dir = new Vector3(0, 5, 0);
        rb.AddForce(dir, ForceMode.Impulse);
    }
    public void DestroyCube()
    {
        Destroy(gameObject);
    }
}
