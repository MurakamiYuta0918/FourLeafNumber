using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeafValue1_3 : MonoBehaviour {
	public Leafs leafs;
	void Start () {
		int value1_3 = leafs.nums[3];
		this.GetComponent<Text>().text = (value1_3).ToString() ;
	}
}
