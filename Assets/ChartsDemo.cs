using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartsDemo : MonoBehaviour {

	public GameObject barChartGo;
	private BarElement[] mList;

	// Use this for initialization
	void Start () {
		if (barChartGo != null)
			mList = barChartGo.GetComponentsInChildren<BarElement>() as BarElement[];
		else 
			mList = GameObject.FindObjectsOfType<BarElement>() as BarElement[];
		Debug.Log (mList.Length);
	}
	
	public void AnimateBarChart() {
		foreach (BarElement element in mList) {
			element.Reanimate ();
		}
	}

	public void ChangeSize(bool scaleUp) {
		if (barChartGo == null)
			return;
			
		Vector3 chartScale = barChartGo.transform.localScale;
		Vector3 newScale = chartScale;
		if (scaleUp) {
			newScale *= 1.1f;
		} else {
			newScale *= 0.9f;
		}

		LeanTween.scale (barChartGo, newScale, 0.33f).setEase (LeanTweenType.easeOutQuad);
	}
}
