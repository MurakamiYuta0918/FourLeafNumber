using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionLeaf4_3 : MonoBehaviour {

	public QuestionLeafs4 questionleafs4;
	// Use this for initialization
	void Start () {
		int value = questionleafs4.nums[3];
		this.GetComponent<Text>().text = (value).ToString() ;
	}
}
