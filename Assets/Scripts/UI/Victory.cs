using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public AudioClip musica;

    private void Awake()
    {
        SoundManager.Instance.PlaySFX(musica);
    }

    public void BackToMenu()
    {
        Application.Quit();
    }
}
