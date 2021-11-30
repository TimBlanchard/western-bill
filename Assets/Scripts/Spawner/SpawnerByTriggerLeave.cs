using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerByTriggerLeave : MonoBehaviour
{
    public GameObject[] ObjPrefabs;

    public int Min = -1;
    public int Max = 2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sisi");
        SpawnPrefab();
    }

    public void SpawnPrefab() {
        int index = Random.Range(0, ObjPrefabs.Length);

        GameObject spawnee = GameObject.Instantiate(ObjPrefabs[index]);

        Vector3 spawnerPos = transform.position;

        spawnerPos.x += Random.Range(Min, Max);

        spawnee.transform.position = spawnerPos;

    }
}
