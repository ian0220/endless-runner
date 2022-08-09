using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    [SerializeField]
    private int m_curenyPickUp;
    [SerializeField]
    private bool m_GODMODE = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<CurencyTag>())
        {
            GameManger.Instance.UpdateCurency(m_curenyPickUp);    // roept in manger script aan om curency te verhogen of te verlagen
            PoolItem bert = other.GetComponent<PoolItem>();   // hier mee zet je het terug naar de object pool
            bert.ReturnToPool();
        }

        if(other.gameObject.GetComponent<PowerUpTag>())
        {
            // zet een power up aan
        }
      
        if (other.gameObject.GetComponent<EnemyTag>() && !m_GODMODE)
        {
            GameManger.Instance.ToDeathScreen(); // je gaat naar gamemanger script en roept aan todeathscreen() dat naar een andere scene gaat
        }
    }
}
