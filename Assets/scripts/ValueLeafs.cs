using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ValueLeafs : Leafs, IDragHandler {
	public bool IsMoving { get { return moveCoroutine!=null; }}
	
	[SerializeField]
	Vector3? startPosition;
	[SerializeField]
	Image[] images; 

	[SerializeField]
	EventTrigger eventTrigger;
	
	void Start() {
		startPosition = transform.parent.position;
	}

	public void GoBack() {
		transform.parent.position = startPosition??Vector3.zero;
		transform.parent.SetAsFirstSibling();
	}
	
	public void OnBeginDrag(){
        if (!IsMoving) {
            moveCoroutine = StartCoroutine(Move());
            GameManager.Instance.CheckButton();
            transform.parent.SetAsLastSibling();
        }
    }

	public void OnDrag(PointerEventData eventData) {
		if (IsMoving) {
			Vector3 currentPosition = eventData.position;
			currentPosition.z = 0;
            nextPos = currentPosition;
		}
	}

    Vector2? nextPos;
    Coroutine moveCoroutine;
    IEnumerator Move() {
        while (true) {
            if (nextPos!=null) {
                transform.parent.position = nextPos??transform.parent.position;
                nextPos = null;
            }
            yield return null;
        }
    }


    public void OnEndDrag() {
		if (!IsMoving) {
			return;
        } else {
            StopCoroutine(moveCoroutine);
            moveCoroutine = null;
        }

		if (targetAnswer != null) {
			targetAnswer.AddValue(this);
		}
		GoBack();
		GameManager.Instance.CheckButton();
    }

	[SerializeField]
	AnswerLeafs targetAnswer;
	private void OnTriggerEnter2D(Collider2D other) {
		if (targetAnswer==null) {
			targetAnswer = other.GetComponent<AnswerLeafs> ();
		}
	}
	
	private void OnTriggerExit2D(Collider2D other) {
		if (other.GetComponent<AnswerLeafs> () == targetAnswer) {
			targetAnswer = null;
		}
	}

	public void SetActive(bool isActive){
		Color color = Color.white;
		if (!isActive) {
			color.a = 0.3f;
		}
		eventTrigger.enabled = isActive;

		foreach (Image image in images) {
			image.color = color;
		}
		foreach(Graphic graphic in transform.parent.GetComponentsInChildren<Graphic> ()) {
			graphic.raycastTarget = isActive;
		}
	}

	Coroutine rotate;
	int angle = 0;
	public int count = 0;
	// Arrow ボタンを押したときの処理
	public void OnArrowClick () {
		angle = angle - 90;
		if (rotate == null) {
			rotate = StartCoroutine(MyRotate());

		}
		RotateLeafs();
		ShiftNumbers();
		count++;
	}

	IEnumerator MyRotate() {
		while (Mathf.DeltaAngle(transform.eulerAngles.z, (float) angle) < -0.1f) {
			transform.Rotate (Vector3.forward, -10f);
			yield return null;
		}
		transform.rotation = Quaternion.Euler(0f, 0f, (float) angle);
		rotate= null;
	}

	public void ShiftNumbers() {
		List<int> saveList = new List<int> (nums);
		saveList.Insert(0, saveList[saveList.Count-1]);
		saveList.RemoveAt(saveList.Count-1);
		nums = saveList.ToArray();

		List<Leaf> ls = new List<Leaf> (leafs);
		ls.Insert(0, ls[ls.Count-1]);
		ls.RemoveAt(ls.Count-1);
		leafs = ls.ToArray();

	}

	public void RotateLeafs() {
		for(int i = 0; i < 4; i++){
			leafs[i].Rotate (Vector3.forward, 90f);
		}
	}
	
}

