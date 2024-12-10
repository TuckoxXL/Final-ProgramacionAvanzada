using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] private Dictionary factory;
    [SerializeField] private List<string> powerUpList;
    [SerializeField] private Vector4 PowerUpPosition;

    private void Start()
    {
        InvokeRepeating("PowerUpManager", 1f, Random.Range(5f, 10f));
    }

    private void PowerUpManager()
    {
        transform.position = new Vector2(Random.Range(PowerUpPosition.x, PowerUpPosition.y), Random.Range(PowerUpPosition.z, PowerUpPosition.w));
        factory.PowerUpSpawn(powerUpList[Random.Range(0, powerUpList.Count)], transform);
    }
}
