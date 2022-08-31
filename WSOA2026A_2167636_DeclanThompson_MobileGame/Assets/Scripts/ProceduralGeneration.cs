using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnList;
    public Vector2 spawnPosition;

    private void Awake()
    {
        StartCoroutine(Generate());
    }

    private Transform Spawn()
    {
        Transform spawnIndex = spawnList[Random.Range(0, spawnList.Count)];
        Transform spawnTransform = Instantiate(spawnIndex, spawnPosition, Quaternion.identity);
        return spawnTransform;
    }

    IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Spawn();
        }
        
    }
}
