using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question1_1l1 : MonoBehaviour {
	public QuestionLeafsl1 questionleafsl1;
	// Use this for initialization
	void Start () {
		int value1_1 = questionleafsl1.nums[1];
		this.GetComponent<Text>().text = (value1_1).ToString() ;
	}
}

