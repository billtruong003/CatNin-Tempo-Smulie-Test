using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public void GamePlayLoad(int num)
    {
        SoundManager.Instance.PlayMusic(num);
        SceneLoad.Instance.LoadGameplayScene();
    }

}
