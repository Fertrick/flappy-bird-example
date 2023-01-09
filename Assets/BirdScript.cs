using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float velocityUp = 10f;
    public LogicScript logicScript;
    private bool birdDead = false;

    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("ScoreTag").GetComponent<LogicScript>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdDead = true;
        logicScript.gameOver();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !birdDead) {
            myRigidBody.velocity = Vector2.up * velocityUp;
        }

        if(transform.position.y >= 5.6 || transform.position.y <= -5.6)
        {
            birdDead = true;
            logicScript.gameOver();
        }
    }
}
