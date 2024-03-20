using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LoadingScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Cor_LoadingScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Cor_LoadingScene()
    {
        yield return new WaitForSeconds(5);
        SceneLoad.Instance.LoadMenuScene();
    }    
}
