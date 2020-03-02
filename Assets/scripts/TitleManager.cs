using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {
	[SerializeField]
	List<StageData> tutorialStage, level0Stages, level1Stages, level2Stages, level3Stages;

	[SerializeField]
	GameObject level1BtnObj, level2BtnObj, level3BtnObj;
	

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt("Level1", 0)!=0) {
			level1BtnObj.SetActive(true);
		}
		if (PlayerPrefs.GetInt("Level2", 0)!=0) {
			level2BtnObj.SetActive(true);
		}
		if (PlayerPrefs.GetInt("Level3", 0)!=0) {
			level3BtnObj.SetActive(true);
		}
	}
	public void StartTutorial() {
		GameManager.stageList = tutorialStage;
		SceneManager.LoadScene("tutorial");
	}
	public void StartLevel0() {
		GameManager.stageList = level0Stages;
		SceneManager.LoadScene("game");
	}
	public void StartLevel1() {
		GameManager.stageList = level1Stages;
		SceneManager.LoadScene("game");
	}
	public void StartLevel2() {
		GameManager.stageList = level2Stages;
		SceneManager.LoadScene("game");
	}	
	public void StartLevel3() {
		GameManager.stageList = level3Stages;
		SceneManager.LoadScene("game");
	}
	public void SendScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}
}
