using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer1_2 : MonoBehaviour {
	public AnswerLeafs answerleafs;

	void Update () {
		int AnswerValue1_2 = answerleafs.answernums[2];
		this.GetComponent<Text>().text = (AnswerValue1_2).ToString() ;
	}
}
