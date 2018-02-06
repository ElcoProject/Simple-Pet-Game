using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PanelButtonEtc : MonoBehaviour {

	public GameObject PanelHelp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CloseInfoPanel(){

		PanelHelp.gameObject.SetActive (false);
	}

	public void OpenInfoPanel(){

		PanelHelp.gameObject.SetActive (true);
	}

	public void RestartScene(){
		SceneManager.LoadScene ("prototypeScene");

	}
}
