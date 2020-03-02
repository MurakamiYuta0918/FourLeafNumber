using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionLeaf4_1 : MonoBehaviour {

	public QuestionLeafs4 questionleafs4;
	// Use this for initialization
	void Start () {
		int value = questionleafs4.nums[1];
		this.GetComponent<Text>().text = (value).ToString() ;
	}
}
