using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class GameManager : MonoBehaviour {
	public static GameManager Instance { get; private set; }

 	static int currentLevel =0;

	[SerializeField]
	AnswerLeafs answerLeafs;

	[SerializeField]
	QuestionLeafs questionleafs;
	
	[SerializeField]
	GameObject clearObjs;
	
	[SerializeField]
	ValueLeafs[] leafses;

	[SerializeField]
	GameObject BackTitleConfirmObj;

	[SerializeField]
	Button[] buttons;

	[SerializeField]
	StageData stageData;

	public static List<StageData> stageList;

	[SerializeField]
	GameObject obstaclePanel;

	private void Awake() {
		if (Instance!=null) {
			Destroy(gameObject);
		} else {
			Instance = this;
		}
	}

	void Start () {
		stageData = stageList[0];
		stageList.RemoveAt(0);
		LoadStage();
	}

	public bool IsMoving {
		get {
			return leafses.Any(leafs => leafs.IsMoving);
		}
	}
	public void LoadStage() {
		stageData.QuestionData.ApplyToLeafs(questionleafs);
		questionleafs.SetData(stageData);
		for (int i=0; i<stageData.LeafDatas.Length; i++) {
			stageData.LeafDatas[i].ApplyToLeafs(leafses[i]);
		}
	}

	public void DisplayObstaclePanel() {
		clearObjs.SetActive (true);
		foreach(Button button in buttons){
			button.gameObject.SetActive(false);
		}
	}
	public void Check () {
		if (Leafs.CompareLeafs(questionleafs, answerLeafs)) {
			obstaclePanel.SetActive(true);
			Invoke("DisplayObstaclePanel",3.0f);	
			StartCoroutine(answerLeafs.ClearEffect());
			foreach(ValueLeafs leafs in leafses) {
				leafs.GoBack();
			}
			if(stageList.Count < 1){
				currentLevel = stageData.Level + 1;
				PlayerPrefs.SetInt("Level"+currentLevel, 1);
			}
		}
	}

	public void CheckButton () {
		bool interactable = !IsMoving;
		foreach(Button button in buttons) {
			button.interactable = interactable;
		}
	}

	// 戻るボタンを押したときの処理
	public void DisplayBackTitleConfirm() {
		BackTitleConfirmObj.SetActive(true);
		foreach(ValueLeafs leafobj in leafses) {
			leafobj.GoBack();
		}
	}

	public void GoNextStage() {
		obstaclePanel.SetActive(false);
		if (stageList.Count>0) {
			stageData = stageList[0];
			stageList.RemoveAt(0);
			LoadStage();
			answerLeafs.Restart();
			
		} else {
			GoTitle();
		}
	}

	public void Retry() {
		LoadStage();
		answerLeafs.Restart();
	}
	public void GoTitle() {
		UnityEngine.SceneManagement.SceneManager.LoadScene("title");
	}
	private void OnDestroy() {
		if (Instance==this) {
			Instance = null;
		}
	}
}
