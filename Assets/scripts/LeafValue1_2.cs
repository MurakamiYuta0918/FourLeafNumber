using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeafValue1_2 : MonoBehaviour {
	public Leafs leafs;

	void Start () {
		int value1_2 = leafs.nums[2];
		this.GetComponent<Text>().text = (value1_2).ToString() ;
	}
}
