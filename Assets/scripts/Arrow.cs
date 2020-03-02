using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Arrow : MonoBehaviour,IPointerClickHandler {
	public Leafs leafs;
	public int count;

	public void OnPointerClick(PointerEventData eventData) {
		if (leafs.moveflag) {
			leafs.transform.Rotate (new Vector3 (0, 0, 1), -90);
			foreach (GameObject leafObj in leafs.leafObjs) {
				leafObj.transform.Rotate (new Vector3 (0, 0, 1), 90);
			}
			leafs.arrow.transform.Rotate (new Vector3 (0, 0, 1), 90);
			leafs.save [0] = leafs.nums [0];
			leafs.save [1] = leafs.nums [1];
			leafs.save [2] = leafs.nums [2];
			leafs.save [3] = leafs.nums [3];
			leafs.nums [0] = leafs.save [3];
			leafs.nums [1] = leafs.save [0];
			leafs.nums [2] = leafs.save [1];
			leafs.nums [3] = leafs.save [2];
			count++;
		}
	}
}
