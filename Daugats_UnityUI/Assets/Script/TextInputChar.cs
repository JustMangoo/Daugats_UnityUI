using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInputChar : MonoBehaviour {

	public string Name, Age;
	public GameObject inputName, inputAge, outputBox;

	public void AgeAndNAme(){
		Name = inputName.GetComponent<Text> ().text;
		Age = inputAge.GetComponent<Text> ().text;
		outputBox.GetComponent<Text> ().text = Name + " is " + Age + " years old";
	}
}
