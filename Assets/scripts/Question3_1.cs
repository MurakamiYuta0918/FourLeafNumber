using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question3_1 : MonoBehaviour {

	public QuestionLeafsl3 questionleafsl3;
	// Use this for initialization
	void Start () {
		int value1_1 = questionleafsl3.nums[1];
		this.GetComponent<Text>().text = (value1_1).ToString() ;
	}
}
