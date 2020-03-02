using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question1_1 : MonoBehaviour {
	public QuestionLeafs questionleafs;
	// Use this for initialization
	void Start () {
		int value1_1 = questionleafs.nums[1];
		this.GetComponent<Text>().text = (value1_1).ToString() ;
	}
}
