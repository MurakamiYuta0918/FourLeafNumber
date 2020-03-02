using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level0 : MonoBehaviour,IPointerClickHandler {
	[SerializeField]
	string nextSceneName;
	public void OnPointerClick(PointerEventData eventData) {
		SceneManager.LoadScene (nextSceneName);
	}
}
