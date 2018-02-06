using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	[SerializeField] 
	private Stats food;

	[SerializeField]
	private Stats hygiene;

	[SerializeField] 
	private Stats sleep;

	[SerializeField]
	private Stats fun;

	[SerializeField]
	private GameObject PanelDie;

	[SerializeField]
	private Text valueText;

	private bool die = false;

	// Use this for initialization
	private void start(){

		
	}
	private void Awake () {
		
		food.Initialize();
		hygiene.Initialize();
		sleep.Initialize();
		fun.Initialize();
	}
	
	// Update is called once per frame
	void Update () {


		dieLow ();
		dieHigh ();

		if (!die){
		food.CurrentValue -= 0.30f * Time.deltaTime;
		hygiene.CurrentValue -= 0.30f * Time.deltaTime;
		sleep.CurrentValue -= 0.30f * Time.deltaTime;
		fun.CurrentValue -= 0.30f * Time.deltaTime;

		}

		
	}


	public void dieHigh(){

		if (food.CurrentValue == 100) {

			valueText.text = "Do not eat too much, overweight! - and die can not breathe";
			PanelDie.gameObject.SetActive (true);
			die = true;

		}

		else if (hygiene.CurrentValue== 100){

			valueText.text = "You are too clean, and now you become transparent";
			PanelDie.gameObject.SetActive (true);
			die = true;
		}

		else if (sleep.CurrentValue== 100){

			valueText.text = "You sleep a lot, and you are now sleeping in agrave";
			PanelDie.gameObject.SetActive (true);
			die = true;
		}

		else if (fun.CurrentValue== 100){

			valueText.text = "You die happy, maybe that's good";
			PanelDie.gameObject.SetActive (true);
			die = true;
		}

	}


	public void dieLow(){

		if (food.CurrentValue == 0) {

			valueText.text = "died of starvation";
			PanelDie.gameObject.SetActive (true);
			die = true;
			Debug.Log ("Food zero");

		}

		else if (hygiene.CurrentValue == 0){

			valueText.text = "You rarely bathe, you get skin diseases";
			PanelDie.gameObject.SetActive (true);
			die = true;
		}

		else if (sleep.CurrentValue == 0){

			valueText.text = "Die for never sleeping";
			PanelDie.gameObject.SetActive (true);
			die = true;
		}

		else if (fun.CurrentValue == 0){

			valueText.text = "Dead unhappy";
			PanelDie.gameObject.SetActive (true);
			die = true;
		}
			
	}


	public void Botton_Click_AddFood(){
		if (die == false){
		food.CurrentValue += 10;
		fun.CurrentValue += 2;
		hygiene.CurrentValue -= 13;

		}

	}

	public void Botton_Click_AddBath(){
		if (die == false) {
			
			hygiene.CurrentValue += 10;
			food.CurrentValue -= 4;
			sleep.CurrentValue += 6;
			fun.CurrentValue -= 10;
		}

	}

	public void Botton_Click_AddSleep(){
		if (die == false) {
			
			sleep.CurrentValue += 10;
			fun.CurrentValue += 7;
			food.CurrentValue -= 20;

		}
	}

	public void Botton_Click_MiniGame(){

		if (die == false) {
			fun.CurrentValue += 15;
			sleep.CurrentValue -= 18;
			hygiene.CurrentValue -= 12;
		}
	}


}
