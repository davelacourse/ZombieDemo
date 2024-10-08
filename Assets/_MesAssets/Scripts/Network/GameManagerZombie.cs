using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerZombie : MonoBehaviour
{
    public static GameManagerZombie Instance;
    
    private float _timer = 0f;
    public float Timer => _timer;
    
    private int _zombieTues = 0;
    public int ZombieTues => _zombieTues;

    private float _vitesseZombie = 1f;
    public float VitesseZombie => _vitesseZombie;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    private void Start()
    {

    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Destroy(gameObject);
        }

    }

    public void AugmenterZombies()
    {
        _zombieTues++;
        UIManager.Instance.UpdateTextZombie();
        if (_zombieTues % 10 == 0) 
        {
            Spawner.Instance.ReduireSpawnTime();
            _vitesseZombie += 0.1f;
        }
    }
}
