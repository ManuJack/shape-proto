using UnityEngine;
using System.Collections;

public class ShapeSpawnerManager : MonoBehaviour 
{
    public GameObject[] prefabs;

	void Start () {
	
	}
	
	void Update () {
	
	}

    public void SpawnShape()
    {
        GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
        GameObject.Instantiate(prefab);
    }
    
}
