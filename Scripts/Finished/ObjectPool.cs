using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool
{
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int poolMax;

    public ObjectPool(GameObject objectToFillPool, int startingPoolMax)
    {
        // Setting everything up for the objectpool + creating the instances
        poolMax = startingPoolMax;
        objectToPool = objectToFillPool;
        for (int i = 0; i < startingPoolMax; i++)
        {
            // Instantiate objectToPool and set it inactive
            pooledObjects.Add(objectToPool);
        }
    }

    public GameObject GetPooledObject()
    {
        return objectToPool;
    }
}
