using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float SpawnTime = 1;
    public Renderer rend;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0, SpawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemies()
    {

        var Min_X = transform.position.x - rend.bounds.size.x / 2;

        var Max_X = transform.position.x + rend.bounds.size.x / 2;

        var spawnPoint = new Vector2(Random.Range(Min_X, Max_X), transform.position.y);

        Instantiate(EnemyPrefab, spawnPoint, Quaternion.identity);
    }
}
