using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question3_2 : MonoBehaviour {

	public QuestionLeafsl3 questionleafsl3;
	// Use this for initialization
	void Start () {
		int value1_2 = questionleafsl3.nums[2];
		this.GetComponent<Text>().text = (value1_2).ToString() ;
	}
}
