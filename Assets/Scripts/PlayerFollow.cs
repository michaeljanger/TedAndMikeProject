using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {
    public GameObject GameCamera;
    public GameObject Player;

    public float turnSpeed = 4.0f;
    public Transform player;
    public float distance;

    public Vector3 offset;
	public Vector3 offsetZ = new Vector3(0,0,-4f);

    // Use this for initialization
    void Start () {
		    offset = new Vector3(player.position.x, player.position.y - 1.0f, player.position.z - 10.0f); 
        
        }
	
	// Update is called once per frame
	void Update () {
          // GameCamera.transform.position = Player.transform.position+offset;
		    offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.forward) * offset;
            transform.position = player.position + offset/10;
		    transform.LookAt(player.position);

        }
  
}

