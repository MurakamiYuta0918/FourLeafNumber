using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour,IPointerClickHandler {

	public void OnPointerClick(PointerEventData eventData) {
		string sceneName = SceneManager.GetActiveScene ().name;
		SceneManager.LoadScene (sceneName);
	}
}
