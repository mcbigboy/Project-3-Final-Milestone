using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnableObject : MonoBehaviour
{
    public GameObject prefab;
    private Collider col;

    // spawn by ponits
    public List<Transform> spawnPoints = new List<Transform>();

    // spawn by random point
    public Vector3 minSpawnPoint;
    public Vector3 maxSpawnPoint;
    public int numberToSpawn;

    public int currentSpawnCount;

    private void Awake()
    {
        col = GetComponent<Collider>();
    }

    public abstract void SpawnObjects();

    private void OnCollisionEnter(Collision collision)
    {
        HandleCollision(collision);
    }

    protected abstract void HandleCollision(Collision collision);

    public abstract void DestroyObject();


}
