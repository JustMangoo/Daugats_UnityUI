using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragging : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler{
	private RectTransform transformacijasLogs;
	public Canvas kanva;

	void Start (){
		transformacijasLogs = GetComponent<RectTransform> ();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais klikskis uz objekta!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzakta vilksana!");
	}

	public void OnDrag(PointerEventData notikums){
		transformacijasLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Beigta vilksana!");
	}
}

