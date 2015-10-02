using UnityEngine;
using System.Collections;

public class SpawnOnClick : MonoBehaviour 
{
    public ShapeSpawnerManager Spawner;

    void OnMouseDown()
    {
        Spawner.SpawnShape();
    }
}
