using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    [SerializeField] GameObject pipe;
    public float timer = 0;
    public float spawnTimer = 1;
    public float heightOffSet = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnTimer) {
            timer += Time.deltaTime;
        } else {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestHeight = pipe.transform.position.y - heightOffSet;
        float highestPoint = pipe.transform.position.y + heightOffSet;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(highestPoint, lowestHeight), 0), transform.rotation);
    }
}
