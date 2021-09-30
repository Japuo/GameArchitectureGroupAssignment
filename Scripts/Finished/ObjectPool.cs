using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool
{
    public static ObjectPool SharedInstance; // Geen static zodat er meerdere pools kunnen zijn? Bijv zombie EN bullet
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int poolMax;

    public ObjectPool()
    {
        // constructor instead of awake
    }

    public GameObject GetPooledObject()
    {
        return objectToPool;
    }
}
