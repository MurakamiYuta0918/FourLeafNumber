using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionLeafs : Leafs {
	[SerializeField]
	HiddenNumber rightBite, leftBite, flower;

	public void SetData(StageData stageData) {
		rightBite.gameObject.SetActive(stageData.CrossHint);
		leftBite.gameObject.SetActive(stageData.CrossHint);
		flower.gameObject.SetActive(stageData.TotalHint);
		
		if (stageData.CrossHint){
			rightBite.HintNum = stageData.RightBiteNum;
			leftBite.HintNum = stageData.LeftBiteNum;
		}
		if (stageData.TotalHint){
			flower.HintNum = stageData.CenterFlowerNum;
		}
	}

}
