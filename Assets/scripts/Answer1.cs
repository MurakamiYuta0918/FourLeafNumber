using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Answer1 : MonoBehaviour {
	public AnswerLeafs answerleafs;

	void Update () {
		int AnswerValue1 = answerleafs.answernums[0];
		this.GetComponent<Text>().text = (AnswerValue1).ToString() ;
	}
}
