using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

namespace GameFriend {
	public class LoadingManager : MonoBehaviour {

		[SerializeField] private Slider progressBar;

		private AsyncOperation async = null;
		private bool isFinishSplashImage = false;
		private int displayProgress = 0;
		private int toProgress = 0;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {
			if (!isFinishSplashImage) {
				if (SplashScreen.isFinished == true) {
					isFinishSplashImage = true;
					Screen.sleepTimeout = SleepTimeout.NeverSleep;
					StartCoroutine (BeginLoadingScene ());
				}
			}

			progressBar.value = (float)displayProgress / 100.0f;
		}

		IEnumerator BeginLoadingScene () {
			displayProgress = 0;
			toProgress = 0;

			async = SceneManager.LoadSceneAsync ("LoginScene");
			async.allowSceneActivation = false;

			while (progressBar.value * 100 < 88) {
				int tempProgress = (int)(async.progress * 100);
				if (tempProgress == toProgress) {
					yield return new WaitForEndOfFrame ();
				} else {
					toProgress = tempProgress;
				}
				while (displayProgress < toProgress) {
					displayProgress += 2;
					yield return new WaitForEndOfFrame ();
				}
			}

			toProgress = 100;
			while (displayProgress < toProgress) {
				displayProgress += 2;
				yield return new WaitForEndOfFrame ();
			}
			async.allowSceneActivation = true;
		}
	}
}