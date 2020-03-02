using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


[CreateAssetMenu( menuName = "MyGame/Create ParameterTable", fileName = "ParameterTable" )]
public class StageData : ScriptableObject {
	[SerializeField] Leafs.LeafData questionData;

    [SerializeField] bool crossHint;

	[SerializeField] bool totalHint;
	
	[SerializeField]
	Leafs.LeafData[] leafDatas;
	public int Level;

	public bool CrossHint{get{return crossHint;}}
	public bool TotalHint{get{return totalHint;}}
	public Leafs.LeafData QuestionData { get { return questionData; }}

	public Leafs.LeafData[] LeafDatas { get { return leafDatas; }}

	public int LeftBiteNum { 
		get {
			return questionData.leafValue[0] + questionData.leafValue[2];
		}
	}


	public int RightBiteNum {
		get {
			return questionData.leafValue[1] + questionData.leafValue[3];
		}
	}

	public int CenterFlowerNum {
		get {
			return questionData.leafValue.Sum();
		}
	}
}