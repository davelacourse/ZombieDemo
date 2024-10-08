using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIFinPartie : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private TMP_Text _txtZombies = default;

    private void Start()
    {
        _txtTemps.text = "Temps : " + TimeSpan.FromSeconds(GameManagerZombie.Instance.Timer).ToString("mm\\:ss\\.ff");
        _txtZombies.text = "Zombies : " + GameManagerZombie.Instance.ZombieTues.ToString();
    }

    public void OnQuitterClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void onRetourClick()
    {
        SceneManager.LoadScene(0);
    }
}
