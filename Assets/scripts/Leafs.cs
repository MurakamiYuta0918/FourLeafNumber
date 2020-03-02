using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Leafs : MonoBehaviour {
	protected virtual int[] nums { get; set; }

	[SerializeField]
	protected Leaf[] leafs;
	
	protected void DisplayNumbers() {	
		for(int i=0; i<leafs.Length; i++) {
			leafs[i].Display(nums[i]);
		}
	}

	public static bool CompareLeafs(Leafs aLeafs, Leafs bLeafs) {
		
		for (int i=0; i<4; i++) {
			if (aLeafs.nums[i] != bLeafs.nums[i]) {
				return false;
			}
		}
		return true; 
	}

	public static void AddLeafs(AnswerLeafs answerLeafs, ValueLeafs valueLeafs) {
		for (int i=0; i<4; i++) {
			answerLeafs.nums[i] += valueLeafs.nums[i];
		}
	}
	public static void SubLeafs(AnswerLeafs answerLeafs, ValueLeafs valueLeafs) {
		for (int i=0; i<4; i++) {
			answerLeafs.nums[i] -= valueLeafs.nums[i];
		}
	}
	private void OnValidate() {
		// leafs = GetComponentsInChildren<Leaf> ();
	}

	[System.Serializable]
	public class LeafData {
		public int[] leafValue = new int[4];
		public void ApplyToLeafs(Leafs leafs) {
			leafs.nums = (int[]) leafValue.Clone();
			leafs.DisplayNumbers();
		}
	}
}
