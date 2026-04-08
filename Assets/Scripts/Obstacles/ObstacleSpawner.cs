using UnityEditor;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameConfigSO gameConfigSO;

    [SerializeField] GameObject obstaclePrefab;

    [SerializeField] float spawnPosX = 15;

    private void Start()
    {
        InvokeRepeating("ObstacleSpawn", 0, gameConfigSO.spawningSpeed);
    }

    private void ObstacleSpawn()
    {
        float randomRange = Random.Range(gameConfigSO.minSpawnY, gameConfigSO.maxSpawnY);
        GameObject obstacle = Instantiate(obstaclePrefab,new Vector3(spawnPosX, randomRange, 0 ), Quaternion.identity);
    }
}
