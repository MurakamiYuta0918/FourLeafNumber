using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AnswerLeafs : MonoBehaviour {
	public int[] answernums;
	public Leafs leafs;
	public Leafs leafs1;
	public Leafs leafs2;
	public Leafs leafs3;
	public Arrow arrow;
	public Arrow arrow1;
	public Arrow arrow2;
	public Arrow arrow3;


	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "leafs") {
			if (leafs.dragflag == true) {
				answernums [0] += leafs.nums [0];
				answernums [1] += leafs.nums [1];
				answernums [2] += leafs.nums [2];
				answernums [3] += leafs.nums [3];
				leafs.dragflag = false;
				for (int i = 0; i < arrow.count; i++) {
					foreach (GameObject leafObj in leafs.leafObjs) {
						leafObj.transform.Rotate (new Vector3 (0, 0, 1), -90);
					}
				}
				leafs.transform.rotation = leafs.startRotation;
				arrow.transform.rotation = leafs.startRotation;
				leafs.transform.position = leafs.startPosition;
				leafs.moveflag = false;
			}
		}
		if (other.tag == "leafs1") {
			if (leafs1.dragflag == true) {
				answernums [0] += leafs1.nums [0];
				answernums [1] += leafs1.nums [1];
				answernums [2] += leafs1.nums [2];
				answernums [3] += leafs1.nums [3];
				leafs1.dragflag = false;
				for (int i = 0; i < arrow1.count; i++) {
					foreach (GameObject leafObj in leafs1.leafObjs) {
						leafObj.transform.Rotate (new Vector3 (0, 0, 1), -90);
					}
				}
				leafs1.transform.rotation = leafs1.startRotation;
				arrow1.transform.rotation = leafs1.startRotation;
				leafs1.transform.position = leafs1.startPosition;
				leafs1.moveflag = false;
			}
		}
		if (other.tag == "leafs2") {
			if (leafs2.dragflag == true) {
				answernums [0] += leafs2.nums [0];
				answernums [1] += leafs2.nums [1];
				answernums [2] += leafs2.nums [2];
				answernums [3] += leafs2.nums [3];
				leafs2.dragflag = false;
				for (int i = 0; i < arrow2.count; i++) {
					foreach (GameObject leafObj in leafs2.leafObjs) {
						leafObj.transform.Rotate (new Vector3 (0, 0, 1), -90);
					}
				}
				leafs2.transform.rotation = leafs2.startRotation;
				arrow2.transform.rotation = leafs2.startRotation;
				leafs2.transform.position = leafs2.startPosition;
				leafs2.moveflag = false;
			}
		}
		if (other.tag == "leafs3") {
			if (leafs3.dragflag == true) {
				answernums [0] += leafs3.nums [0];
				answernums [1] += leafs3.nums [1];
				answernums [2] += leafs3.nums [2];
				answernums [3] += leafs3.nums [3];
				leafs3.dragflag = false;
				for (int i = 0; i < arrow3.count; i++) {
					foreach (GameObject leafObj in leafs3.leafObjs) {
						leafObj.transform.Rotate (new Vector3 (0, 0, 1), -90);
					}
				}
				leafs3.transform.rotation = leafs3.startRotation;
				arrow3.transform.rotation = leafs3.startRotation;
				leafs3.transform.position = leafs3.startPosition;
				leafs3.moveflag = false;
			}
		}
	}
}