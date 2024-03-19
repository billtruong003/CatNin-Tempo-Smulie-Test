using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFloating : MonoBehaviour
{

    public float floatSpeed = 1f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.down * floatSpeed * Time.deltaTime);
    }
}
