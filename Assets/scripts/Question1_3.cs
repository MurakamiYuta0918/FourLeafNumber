using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question1_3 : MonoBehaviour {
	public QuestionLeafs questionleafs;
	// Use this for initialization
	void Start () {
		int value1_3 = questionleafs.nums[3];
		this.GetComponent<Text>().text = (value1_3).ToString() ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
