using System.Collections;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }
     IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);

        for (int i = 0; i < 3; i++)
        {
            Instantiate(balloons[1], spawnPoints[i].position, Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
}
