using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance;
    [SerializeField]
    private int m_deathScreenSceneNumber;
    private int m_cureny;
    //[SerializeField]
    //private ObjectPool m_enemyPool;
    private void Awake()
    {
        if(Instance == null)   // singelton
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
 
    public void UpdateCurency(int _cureny)
    {
        m_cureny += _cureny;                                                   // je cureny om hoog 
    }

    public void ToDeathScreen()
    {
        SceneManager.LoadScene(m_deathScreenSceneNumber);                   // hier mee kan je naar een andere scene en je voegt zelf toe welke dat is met het nummer
    }

    public void ToPowerUp()
    {  // moet hier nog een script maken voor dat de power up kan zijn
    }

    public void ObjectpoolUse() // roept object aan om actief te worden zo kan je het laten spawen
    {
    }
}
