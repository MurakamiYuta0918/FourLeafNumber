using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaf : MonoBehaviour {
	
	[SerializeField]
	Text numText;

	public void Display(int num) {
		numText.text = (num).ToString() ;
	}

	public void Rotate (Vector3 axis, float angle) {
		numText.transform.Rotate(axis, angle);
	}

}
