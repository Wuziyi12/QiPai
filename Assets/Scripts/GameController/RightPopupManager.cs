using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace GameFriend {
	public class RightPopupManager : MonoBehaviour {

		[SerializeField] private Button ShowPopup;
		[SerializeField] private Button HidePopup;
		[SerializeField] private Button ExitRoom;
		[SerializeField] private Button DismissRoom;

		private Animator animator;

		// Use this for initialization
		void Start () {
			animator = this.GetComponent<Animator> ();
		}

		// Update is called once per frame
		void Update () {

		}

		#region
		// 显示popup
		public void PopupDo(bool canShow) {
			if (animator != null) {
				animator.SetBool ("popup", canShow);
			}
			ShowPopup.gameObject.SetActive (!canShow);
			HidePopup.gameObject.SetActive (canShow);
		}
		#endregion

		#region
		// 设置
		public void SetDo() {

		}
		#endregion

		#region
		// 玩法
		public void PlayRuleDo() {

		}
		#endregion

		#region
		// 返回
		public void ExitRoomDo() {
			SceneManager.LoadScene ("MainScene");
		}
		#endregion

		#region
		// 解散房间
		public void DimissRoomDo() {

		}
		#endregion
	}
}