using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneLoad.Instance.LoadMenuScene();
    }
}
