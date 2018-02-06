using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarFillScript : MonoBehaviour {

	private float fillAmount;

	[SerializeField]
	private Image content;

	[SerializeField]
	private Text valueText;

	[SerializeField]
	private float lerpSpeed;

	[SerializeField]
	private Color fullColor;
	[SerializeField]
	private Color lowColor;

	[SerializeField]
	private bool lerpColor;

	public float maxValue { get; set; }
	public float Value{

		set {
			string[] temp = valueText.text.Split (':');
			valueText.text = temp[0] + ": " + Mathf.Round(value);
			fillAmount = map (value, 0, maxValue, 0, 1);
		}

	}

	// Use this for initialization
	void Start () {

		if (lerpColor) {

			content.color = fullColor;

		}
		
	}
	
	// Update is called once per frame
	void Update () {

		handleBar ();
	}

	private void handleBar(){

		if (fillAmount != content.fillAmount) {

			content.fillAmount = Mathf.Lerp(content.fillAmount,fillAmount,Time.deltaTime * lerpSpeed);
		}
		if (lerpColor) {

			content.color = Color.Lerp (lowColor, fullColor, fillAmount);
		}

	}


	private float map(float value, float inMin, float inMax, float outMin, float outMax){

		return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;

	}
}
