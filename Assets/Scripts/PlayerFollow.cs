using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {
    public GameObject GameCamera;
    public GameObject Player;
    public Vector3 offset = new Vector3(0f, 5f, 15f);
    float speed = 10.0f;

    public float turnSpeed = 4.0f;
    public Transform player;

    public float height = 1f;
    public float distance = 10f;

    private Vector3 offsetX;
    private Vector3 offsetY;

    // Use this for initialization
    void Start () {
        offset = new Vector3(0f, 5f, -25f);
        offsetX = new Vector3(0, height, distance);
        offsetY = new Vector3(0, 0, distance);
        }
	
	// Update is called once per frame
	void Update () {
        GameCamera.transform.position = Player.transform.position+offset;
        offsetX = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.right) * offsetX;
        offsetY = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.up) * offsetY;
       // transform.position = player.position + offsetX;
        transform.LookAt(player.position);

        }
  
}

