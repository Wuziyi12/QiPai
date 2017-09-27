using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace GameFriend {
	public class LoginManager : MonoBehaviour {

		[SerializeField] private Toggle agreeToggle;

		private bool _agree = true;
		private bool agree { 
			get { return _agree; } 
			set { _agree = value; } 
		}

		public void toggleDo() {
			agree = !agree;
		}

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}

		public void login(){
			if (agree == false) {
				// showToast
			}
			#if UNITY_EDITOR
			testLogin();
			return;
			#endif

		}

		void testLogin () {
			SceneManager.LoadScene ("MainScene");
		}
	}
}