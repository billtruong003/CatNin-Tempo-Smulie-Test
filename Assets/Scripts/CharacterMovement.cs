using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Transform FirstPose;
    [SerializeField] private Transform SecondPose;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = FirstPose.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
