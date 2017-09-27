using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pomelo.DotNetClient;

namespace GameFriend {
	public class NetworkBase : MonoBehaviour {

		private static NetworkBase _instance;
		public static NetworkBase Instance {
			get { return _instance; }
		}

		public static NetworkBase Initialize (string host, string port) {
			if (_instance == null) {
				_instance = new NetworkBase (host, port);
			}
			return _instance;
		}

		public PomeloClient pclient { get; private set;}
		public string host { get; private set; }
		public string port { get; private set; }

		public NetworkBase(string host, string port) {
			this.pclient = new PomeloClient (host, port);
			this.host = host;
		}

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
	}
}