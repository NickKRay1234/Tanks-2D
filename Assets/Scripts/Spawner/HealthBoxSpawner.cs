using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBoxSpawner : MonoBehaviour
{
    [SerializeField]private GameObject _healthBox;
    [SerializeField]private float spawnTime = 20f;
    
    
    void Start()
    {
        StartCoroutine(SpawnHealth());
    }

    IEnumerator SpawnHealth()
    {
        while(true)
        {
            Instantiate(_healthBox, new Vector3(Random.Range(-8, 8), Random.Range(-5, 5), 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
