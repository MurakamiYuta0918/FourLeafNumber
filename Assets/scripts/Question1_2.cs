using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question1_2 : MonoBehaviour {
	public QuestionLeafs questionleafs;
	// Use this for initialization
	void Start () {
		int value1_2 = questionleafs.nums[2];
		this.GetComponent<Text>().text = (value1_2).ToString() ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
