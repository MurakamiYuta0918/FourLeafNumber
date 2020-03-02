using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Leafs : MonoBehaviour,  IBeginDragHandler, IDragHandler,IEndDragHandler {
	
	private Vector3 screenPoint;
	private Vector3 offset;
	public GameObject[] leafObjs;
	public GameObject arrow;
	public AnswerLeafs answerleafs;
	public int[] nums;
	public int[] save;
	public bool dragflag = false;
	public bool moveflag;
	public Vector3 startPosition;
	public Quaternion startRotation;


	void Start() {
		startPosition = transform.position;
		startRotation = transform.rotation;
				moveflag = true;
	}

	public void OnBeginDrag(PointerEventData eventData) {
		dragflag = false;
		if (moveflag) {
			screenPoint = Camera.main.WorldToScreenPoint (transform.position);
		}
	}

	public void OnDrag(PointerEventData eventData) {
		if (moveflag) {
			Vector3 currentScreenPoint = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 currentPosition = Camera.main.ScreenToWorldPoint (currentScreenPoint);
			transform.position = currentPosition;
		}
	}

	public void OnEndDrag(PointerEventData eventData) {
		if (moveflag) {
			dragflag = true;
		}
	}

}

