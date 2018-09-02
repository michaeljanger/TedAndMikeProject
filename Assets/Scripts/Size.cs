using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour {
	public static float sizevalue = 1f; // set initial size for score
	public GameObject player; //call player obj
    public GameObject innerplayer;

	private void onCollision (Collision other) {
		Debug.Log("collision");
		if (other.gameObject.CompareTag("Object"))
		{
			player.transform.localScale += new Vector3(1F, 1f, 1f); //make player object grow
			sizevalue++; //increase size 
           // innerplayer.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f); //make player object grow
        }
	}
}
