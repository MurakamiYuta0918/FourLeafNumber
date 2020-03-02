using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeafValue1_1 : MonoBehaviour {
	public Leafs leafs;

	void Start () {
		int value1_1 = leafs.nums[1];
		this.GetComponent<Text>().text = (value1_1).ToString() ;
	}
}

