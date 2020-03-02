using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour {
	public QuestionLeafs questionleafs;
	// Use this for initialization
	void Start () {
		int value1 = questionleafs.nums[0];
		this.GetComponent<Text>().text = (value1).ToString() ;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
