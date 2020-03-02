using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer1_3 : MonoBehaviour {
	public AnswerLeafs answerleafs;

	void Update () {
		int AnswerValue1_3 = answerleafs.answernums[3];
		this.GetComponent<Text>().text = (AnswerValue1_3).ToString() ;
	}
}
