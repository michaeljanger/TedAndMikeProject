using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsManager : MonoBehaviour {
	public static float sizecounter; 
	public static float objectcounter;
	public static float speedcounter;
	public static float timecounter;
	public static float objectivecounter;
	public bool win;
	public bool lost; 
	public Text sizetext;
	public Text objecttext;
	public Text objectcurrenttext;
	public Text objectivetext;
	public Text speedtext;
	public Text timetext;
	public Text gamestate;
	public Image gamestatepanel;
	public GameObject player;

	// Use this for initialization
	void Start () {
		//declaring initial values
		sizecounter = 0;
		objectcounter = 0;
		speedcounter = 0;
		timecounter = 10;
		objectivecounter = 100;
		win = false;
		lost = false;
		gamestatepanel.CrossFadeAlpha(0f, 0f, false);

	}
	
	// Update is called once per frame
	void Update () {
		if(timecounter>0)
		{
			timecounter -= Time.deltaTime; // minus time by 1 second
		}
		else
		{
			timecounter=0;
			gamestate.text = "You Lose!";
			if(lost==false)
			{
				gamestatepanel.CrossFadeAlpha(1f, 2f, false);
				lost=true;
			}
		}
		if(objectcounter>=objectivecounter)
		{
			timecounter=999;
			gamestate.text = "You Win!";
			if(win==false)
			{
				gamestatepanel.CrossFadeAlpha(1f, 2f, false);
				win=true;
			}
		}
		speedcounter = PlayMovement.verticalforce;
		sizecounter = player.transform.localScale.x;
		sizetext.text = sizecounter.ToString();
		objecttext.text = objectcounter.ToString();
		speedtext.text = speedcounter.ToString();
		timetext.text = timecounter.ToString("f1");
		objecttext.text = objectcounter.ToString();
		objectcurrenttext.text = objectcounter.ToString();
		objectivetext.text = objectivecounter.ToString();
	
	}
}
