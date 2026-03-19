using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public GameObject enemyPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn tại vị trí Spawner
            Instantiate(
                enemyPrefab,
                transform.position,
                Quaternion.identity
            );
        }
    }
}
