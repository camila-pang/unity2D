using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class SwitchToggle : MonoBehaviour {

	[SerializeField] RectTransform uiHandleRectTransform;
	[SerializeField] Color backgroundActiveColor;
	[SerializeField] Color handleActiveColor;

	Image backgroundImage, handleImage;

	Color backgroundDefaultColor, handleDefaultColor;

	Toggle _toggle;

	Vector2 handlePosition;

	private ControllerGame _ControleGame;

	void Awake()
    {

		_ControleGame = FindObjectOfType(typeof(ControllerGame)) as ControllerGame;

		_toggle = GetComponent<Toggle>();
		handlePosition = uiHandleRectTransform.anchoredPosition;

		backgroundImage = uiHandleRectTransform.parent.GetComponent<Image>();
		handleImage = uiHandleRectTransform.GetComponent<Image>();

		backgroundDefaultColor = backgroundImage.color;
		handleDefaultColor = handleImage.color;

		_toggle.onValueChanged.AddListener(OnSwitch);

		if(_toggle.isOn)
        {
			OnSwitch(true);
		}
	}

	void OnSwitch(bool on)
    {
		uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition;
		backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor;
		handleImage.color = on ? handleActiveColor : handleDefaultColor;

		_ControleGame.fxMusicGame.enabled = on ? true : false;
		
	}

	void OnDestroy()
    {
		_toggle.onValueChanged.RemoveListener(OnSwitch);

	}
}
