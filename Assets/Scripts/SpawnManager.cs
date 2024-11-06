using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private int spawnIndex;
    [SerializeField] private bool useRandomSelector;
    [SerializeField] private List<SpawnGroup> spawnGroups;

    void Start()
    {
        SpawnLevel();
    }

    void SpawnLevel()
    {
        if (useRandomSelector)
        {
            spawnIndex=Random.Range(0, spawnGroups.Count);
        }
        int count = 0;
        for(int i=0;i<5;i++)
        {
            for(int j = 0; j < spawnGroups[spawnIndex].spawnObjects.Count; j++)
            {
                GameObject obj = Instantiate(spawnGroups[spawnIndex].spawnObjects[j]);
                obj.transform.position = new Vector3(0, 0, count * 10);
                count++;
            }
        }
    }
}
