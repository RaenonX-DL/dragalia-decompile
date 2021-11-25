using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class ServerSettings : ScriptableObject
	{
		[Serializable]
		private class SettingItem
		{
			public string key;

			public string server;

			public string multi;

			public string baas;

			public string appId;
		}

		[SerializeField]
		private List<SettingItem> settings;

		private static ServerSettings _instance;

		public static ServerSettings instance => null;

		public string GetServerId()
		{
			return null;
		}

		public string GetNPFBaaSServer()
		{
			return null;
		}

		public string GetNPFBaaSServer(string name)
		{
			return null;
		}

		public string GetBundleIdentifier(string name)
		{
			return null;
		}

		public string GetAppSecret()
		{
			return null;
		}

		public string GetAppId()
		{
			return null;
		}

		public string GetServerAddress()
		{
			return null;
		}

		private string GetServerAddress(string name)
		{
			return null;
		}

		public string[] GetServerList()
		{
			return null;
		}

		public string GetMultiServerAddress()
		{
			return null;
		}

		private string GetMultiServerAddress(string name)
		{
			return null;
		}

		public string GetPhotonAppId()
		{
			return null;
		}

		private string GetPhotonAppId(string name)
		{
			return null;
		}

		private SettingItem GetSettingItem(string name)
		{
			return null;
		}
	}
}
