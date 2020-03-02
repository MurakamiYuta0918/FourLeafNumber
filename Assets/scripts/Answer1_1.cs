using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer1_1 : MonoBehaviour {
	public AnswerLeafs answerleafs;

	void Update () {
		int AnswerValue1_1 = answerleafs.answernums[1];
		this.GetComponent<Text>().text = (AnswerValue1_1).ToString() ;
	}
}

