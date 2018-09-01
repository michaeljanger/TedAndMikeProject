using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovement : MonoBehaviour
    {
    
    public GameObject gameobject;
	public GameObject innerplayer;
    public Rigidbody rigidbody;
    public Transform gameobjecttrans;
    public float sidewaysforce = 20f;
    public float verticalforce = 20f;
    public bool jump;

    // Use this for initialization
    void Start()
        {
        gameobjecttrans = gameobject.transform;
        rigidbody = gameobject.GetComponent<Rigidbody>();
        jump = true; 
        
    

        }

    // Update is called once per frame
    void FixedUpdate()
        {


        if (Input.GetKey("w"))
            {
            Debug.Log("W");

             rigidbody.AddForce(Vector3.forward * verticalforce);
       


            }
        if (Input.GetKey("s"))
            {
            Debug.Log("S");
            rigidbody.AddForce(Vector3.back*verticalforce);
    

            }
        if (Input.GetKey("a"))
            {
            Debug.Log("A");
            rigidbody.AddForce(Vector3.left*sidewaysforce);
    

            }
        if (Input.GetKey("d"))
            {
            Debug.Log("D");
            rigidbody.AddForce(Vector3.right * sidewaysforce);


            }
        if (Input.GetKey("space") && jump == true)
            {

            Debug.Log("JUMP");
            rigidbody.AddForce(Vector3.up * (verticalforce * 2));
  

            }
		if (Input.GetKey("e"))
		{

			Debug.Log("HARDEN");
			if(innerplayer.transform.localScale.x<gameobject.transform.localScale.x) //if inner player is smaller than player on x axis? (TBD)
			{
				innerplayer.transform.position = transform.position;
				innerplayer.transform.localScale += new Vector3(0.001F, 0.001f, 0.001f); //make player object grow
			}


		}
        if (gameObject.transform.position.y < 10)

            {
            jump = true;

            }
        else
            jump = false;

        
        }

        }
    
   
            

        

