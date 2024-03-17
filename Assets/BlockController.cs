using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class BlockController : MonoBehaviour
{
    [SerializeField] private Animator blockAnim;
    // Start is called before the first frame update
    void Start()
    {

    }
    [Button]
    private void GoodActive()
    {
        blockAnim.SetTrigger("Good");
    }

    [Button]
    private void NiceActive()
    {
        blockAnim.SetTrigger("Nice");
    }

    [Button]
    private void PerfectActive()
    {
        blockAnim.SetTrigger("Perfect");
    }

    [Button]
    public void BackToNormal()
    {
        blockAnim.SetTrigger("Idle");
    }
}
