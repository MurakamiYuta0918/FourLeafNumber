using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Free : MonoBehaviour,IPointerClickHandler  {

	public void OnPointerClick(PointerEventData eventData) {
		SceneManager.LoadScene ("free0");
	}
}
