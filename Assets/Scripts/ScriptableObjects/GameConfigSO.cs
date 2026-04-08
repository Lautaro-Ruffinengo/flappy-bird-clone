using UnityEngine;

[CreateAssetMenu (fileName = "NewGameConfig", menuName = "GameConfig")]
public class GameConfigSO : ScriptableObject
{
    [Header("Player Attributes")]
    public float jumpForce;

    [Header("Obstacle Attributes")]
    public float tubesMovementSpeed;

    [Header("Obstacle Spawner Attributes")]
    public float spawningSpeed;
    public float minSpawnY;
    public float maxSpawnY;
}
