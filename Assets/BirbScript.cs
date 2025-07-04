using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birbIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birbIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birbIsAlive = false;
    }
}
