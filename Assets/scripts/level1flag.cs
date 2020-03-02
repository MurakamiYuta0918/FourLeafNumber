using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1flag : MonoBehaviour {

	public GameObject level1button;
	public GameObject level2button;
	public GameObject level3button;
	public GameObject freebutton;
	void Update() {
		if (QuestionLeafsl1.level1flag == true) {
			level1button.SetActive (true);
		}
		if (QuestionLeafsl2.level2flag == true) {
			level2button.SetActive (true);
		}
		if (QuestionLeafsl3.level3flag == true) {
			level3button.SetActive (true);
		}
		if (QuestionLeafs4.freeflag == true) {
			freebutton.SetActive (true);
		}
	}
}
