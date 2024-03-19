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
        ChangePose(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangePose();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChangePose(1);
        }
    }
    private void ChangePose(int posNum = 0)
    {
        if (posNum == 1)
        {
            transform.position = FirstPose.position;
        }
        else
        {
            transform.position = SecondPose.position;
        }
    }
}
