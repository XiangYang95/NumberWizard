using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int min;
	int max;
	int guess;

	public Text text;

	public int maxGuessesAllowed = 10;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	public void GuessHigher(){
		min = guess;
		NextGuess ();
	}

	public void GuessLower(){
		max = guess;
		NextGuess ();
	}
	void StartGame(){
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
		max = max + 1;
		text.text = guess.ToString();
	}

	void NextGuess(){
		guess = Random.Range(min,max);
		text.text = guess.ToString ();
		maxGuessesAllowed -= 1;
		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene ("Win");
		}
	}

}
