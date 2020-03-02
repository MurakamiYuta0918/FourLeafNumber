using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour,IPointerClickHandler {



	public void OnPointerClick(PointerEventData eventData) {
		SceneManager.LoadScene ("level1_0");
	}
}
