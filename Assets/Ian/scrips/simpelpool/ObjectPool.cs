using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject PooledObject;
    public int PoolSize = 5;

    private Stack<PoolItem> m_objectPool;

    private void Start()
    {
        m_objectPool = new Stack<PoolItem>(PoolSize);
        Expend(PoolSize);
    }

    private void Expend(int _expensionSize)
    { // als de pool te klein is moet die groter maar dat gebeurd nog niet
        for (int i = 0; i < _expensionSize; i++)
        {
            GameObject _newobject = Instantiate(PooledObject);
            PoolItem _item = _newobject.GetComponent<PoolItem>();
            _item.pool = this;
            ReturnPooledObject(_item);

        }
    }

    public GameObject GetPooledObject(Vector3 _postion, Quaternion _rotation,Transform _parent=null)
    {
        if (m_objectPool.Count == 0)    // conroleerd of er iets in de pool zit
        {
            Debug.Log($"{name}: pool is empty");
            return null;
        }
          // als het er iets in zit dan haalt die er wat uit
        PoolItem _item = m_objectPool.Pop();  
        _item.Init(_postion, _rotation, _parent != null ? _parent : transform);
        _item.gameObject.SetActive(true);
        return _item.gameObject;    
    }
    public void ReturnPooledObject(PoolItem _item)
    { // hier gaat die terug naar de pool
        if (!_item.gameObject.activeSelf)
        {
            return;
        }
        _item.transform.parent = transform;
        _item.gameObject.SetActive(false);
        m_objectPool.Push(_item);
    }
}
