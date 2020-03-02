using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class HiddenNumber : MonoBehaviour, IPointerClickHandler {
	public Sprite hideSprite, showSprite;

	[SerializeField]
	Text hintText;
	[SerializeField]
	Image image;

	bool isHidden = true;

	public void OnPointerClick(PointerEventData eventData) {
		isHidden = !isHidden;
		ChangeSprite();
	}

	public void ChangeSprite() {
		if(isHidden){
			image.sprite = hideSprite;
		} else {
			image.sprite = showSprite;
		}
		hintText.enabled = !isHidden;
	}


    public int HintNum {
        set  {
			hintText.text = value.ToString();
			isHidden = true;
			ChangeSprite();
		}
    }

}
