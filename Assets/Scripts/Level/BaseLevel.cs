using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseLevel : MonoBehaviour
{
    public List<SpawnableObject> spawnObjects = new List<SpawnableObject>();
    public bool done = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnLevel()
    {
        foreach (SpawnableObject sp in spawnObjects)
        {
            sp.SpawnObjects();
        }
    }
}
