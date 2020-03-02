using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnswerLeafs : Leafs {
	Stack<ValueLeafs> history = new Stack<ValueLeafs>(){};
[SerializeField]Image[] images ;
	private void Start() {
		nums = new int[4];
		DisplayNumbers();
	}

	public void AddValue(ValueLeafs myLeafs) {
		AddLeafs(this, myLeafs);
		myLeafs.SetActive(false);
		GameManager.Instance.Check();
		DisplayNumbers();
		history.Push(myLeafs);
	}

	public void SubValue(){
		if(history.Count > 0){
			ValueLeafs valueleafs = history.Pop();
			SubLeafs(this,valueleafs);
			valueleafs.SetActive(true);
			DisplayNumbers();
		}
	}

	public IEnumerator  ClearEffect() {
		Image[] imagess = GetComponentsInChildren<Image> ();
		foreach(Image image in imagess){
			StartCoroutine(Thin(image));
		}
		yield return null;
	}

	public IEnumerator Thin (Image image) {
		for (int i=0; i<4; i++) {
			Color color = new Color(0,0,0,0.1f);
			while(image.color.a > 0.3f){
				image.color -= color;
				yield return null;
			}
			yield return new WaitForSeconds(0.1f);
			while(image.color.a < 1f){
				image.color += color;
				yield return null;
			}
		}
	}

	public void Restart() {
		while(history.Count > 0){
			ValueLeafs valueleafs = history.Pop();
			valueleafs.SetActive(true);
		}
		for(int i=0; i<4; i++) {
			nums[i] = 0;
		}
		DisplayNumbers();
	}
}
