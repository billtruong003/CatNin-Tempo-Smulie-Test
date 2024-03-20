using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public static SceneLoad Instance;
    [SerializeField] private bool isPersistent;
    [SerializeField] private int targetFrameRate = 120;

    private void Start()
    {
        QualitySettings.vSyncCount = 0; 
        Application.targetFrameRate = targetFrameRate;
    }
    private void Awake()
    {
        if (isPersistent)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        Instance = this;
    }
    private void OnDestroy()
    {
        Instance = null;
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
        SoundManager.Instance.StopAllAudio();
    }
    public void LoadGameplayScene()
    {
        SceneManager.LoadScene("GamePlayScene");
    }
}
