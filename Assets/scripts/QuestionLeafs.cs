using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionLeafs : MonoBehaviour {
	public int[] nums;
	public AnswerLeafs answerleafs;
	public GameObject clearLabelObject;
	public GameObject nextstagebutton;
	public Leafs leafs;
	public Leafs leafs1;
	public Leafs leafs2;
	public Leafs leafs3;
	void Update () {
		if (nums [0] == answerleafs.answernums [0] && nums [1] == answerleafs.answernums [1] &&
		   nums [2] == answerleafs.answernums [2] && nums [3] == answerleafs.answernums [3]) {
			clearLabelObject.SetActive (true);
			nextstagebutton.SetActive (true);
			leafs.moveflag = false;
			leafs1.moveflag = false;
			leafs2.moveflag = false;
			leafs3.moveflag = false;
		}
	}
}
