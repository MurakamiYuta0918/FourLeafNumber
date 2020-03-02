using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeafValue1 : MonoBehaviour {
	public Leafs leafs;

	void Start () {
		int value1 = leafs.nums[0];
		this.GetComponent<Text>().text = (value1).ToString() ;
	}
}
