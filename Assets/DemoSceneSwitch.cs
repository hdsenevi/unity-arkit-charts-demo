using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoSceneSwitch : MonoBehaviour {

	public void SwitchScene(int scene) {

		switch (scene) {
		case 0:
			SceneManager.LoadScene ("UnityARBallz");
			break;
		case 1:
			SceneManager.LoadScene ("UnityARKitScene");
			break;
		case 2:
			SceneManager.LoadScene ("UnityARShadows");
			break;
		default:
			SceneManager.LoadScene ("UnityParticlePainter");
			break;
		}
	}
}
