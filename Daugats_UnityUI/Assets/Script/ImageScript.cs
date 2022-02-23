using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour {
	public GameObject Helmets, Chests, Pants, Boots;
	public GameObject attelaTuretajs;
	public Sprite[] attelumasivs;
	public GameObject slaideris;

	public void helmetsAttelosana(bool vertiba){
		Helmets.SetActive (vertiba);
	}

	public void chestsAttelosana(bool vertiba){
		Chests.SetActive (vertiba);
	}

	public void pantsAttelosana(bool vertiba){
		Pants.SetActive (vertiba);
	}

	public void bootsAttelosana(bool vertiba){
		Boots.SetActive (vertiba);
	}

	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [0];
		else if (skaitlis == 1)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [1];
	}

	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1F * pasreizejaVertiba, 1F * pasreizejaVertiba);
	}
}
