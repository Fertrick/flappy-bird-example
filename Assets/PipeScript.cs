using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float speedPipe = 10;
    public float deadZone = -12;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.localPosition + (Vector3.left * speedPipe) * Time.deltaTime;

        if(transform.position.x <= deadZone)
        {
            Destroy(gameObject);
        }
    }
}
