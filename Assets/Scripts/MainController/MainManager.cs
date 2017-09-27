using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace GameFriend {
	public class MainManager : MonoBehaviour {

		[SerializeField] private GameObject PlayRecordPrefab;
		[SerializeField] private GameObject SharePrefab;
		[SerializeField] private GameObject PlayRulePrefab;
		[SerializeField] private GameObject BuyCardPrefab;
		[SerializeField] private GameObject CreateRoomPrefab;
		[SerializeField] private GameObject JoinRoomPrefab;

		[SerializeField] private Image avatar;
		[SerializeField] private Text username;
		[SerializeField] private Text userNo;
		[SerializeField] private Text hasRoomCard;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}

		#region
		// 战绩
		public void PlayRecordDo() {

		}
		#endregion

		#region
		// 分享
		public void ShareDo() {

		}
		#endregion

		#region
		// 玩法
		public void PlayRuleDo() {

		}
		#endregion

		#region
		// 购卡
		public void BuyCardDo() {

		}
		#endregion

		#region
		// 退出登陆，清除登陆信息
		public void GoBackDo() {
			SceneManager.LoadScene ("LoginScene");
		}
		#endregion

		#region
		// 创建房间
		public void CreateRoomDo() {
			SceneManager.LoadScene ("GameScene");
		}
		#endregion

		#region
		// 加入房间
		public void JoinRoomDo() {
			SceneManager.LoadScene ("GameScene");
		}
		#endregion
	}
}