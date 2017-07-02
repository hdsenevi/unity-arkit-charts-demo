using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarElement : MonoBehaviour {

	private Renderer mChildRenderer;

	// Use this for initialization
	void Start () {
		mChildRenderer = GetComponentInChildren<Renderer> ();
		mChildRenderer.material = new Material (Shader.Find ("Diffuse"));
		mChildRenderer.material.color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f)); 
		Animate ();
	}

	public void Reanimate() {
		Animate();
	}

	private void Animate () {
		LeanTween.scaleY (gameObject, Random.Range(1f, 10f), 1.33f).setEase(LeanTweenType.easeOutQuad);
		LeanTween.color (gameObject, new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f)), 1.33f).setEase (LeanTweenType.easeOutQuad);
	}
}
