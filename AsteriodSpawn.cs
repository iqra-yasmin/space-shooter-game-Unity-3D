using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteriodSpawn : MonoBehaviour
{
    public GameObject asteriodsPrefabs;
    //public GameObject asteriods2prefabs;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    
    void Start()
    {
    StartCoroutine(spaceWave());
      }
    IEnumerator spaceWave()
    {
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                yield return new WaitForSeconds(startWait);
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);

                Instantiate(asteriodsPrefabs, spawnPosition, Quaternion.identity);
               // Instantiate(asteriods2prefabs, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            
        }
    }
}