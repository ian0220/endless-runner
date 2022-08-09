using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolItem : MonoBehaviour
{
    private ObjectPool m_myPool;

    public ObjectPool pool { set { m_myPool = value; } }

    public void Init(Vector3 _postion, Quaternion _rotation, Transform _parent)
    {  // zo zet je dat postie de postie is die je mee hebt gegeven
        transform.position = _postion;
        transform.rotation = _rotation;
        transform.parent = _parent;

        Activate();
    }

    protected virtual void Activate()
    {

    }

    protected virtual void DeActivate()
    {

    }

    public void ReturnToPool()
    {
        m_myPool.ReturnPooledObject(this);
    }
}
