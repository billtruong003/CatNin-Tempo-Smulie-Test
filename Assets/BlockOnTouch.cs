using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockOnTouch : MonoBehaviour
{

    private void OnMouseDown()
    {
        Debug.Log("Click Click");
        ThrownKunai.Instance.kunaiThrown(transform);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
