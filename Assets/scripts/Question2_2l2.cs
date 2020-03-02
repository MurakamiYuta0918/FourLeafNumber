using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Question2_2l2 : MonoBehaviour {

	public QuestionLeafsl2 questionleafsl2;
	// Use this for initialization
	void Start () {
		int value1_2 = questionleafsl2.nums[2];
		this.GetComponent<Text>().text = (value1_2).ToString() ;
	}
}
