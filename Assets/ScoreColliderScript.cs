using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreColliderScript : MonoBehaviour
{
    public LogicScript logicScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicScript = GameObject.FindGameObjectWithTag("ScoreTag").GetComponent<LogicScript>();

        logicScript.addScore();
    }
}
