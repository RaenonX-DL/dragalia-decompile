using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NPFServerSettingTable : ScriptableObject
{
	[Serializable]
	public class NPFServerSetting
	{
		public string name;

		public string baas;

		public string appId;

		public string secret;

		public string bundleid;
	}

	public List<NPFServerSetting> settings;

	private static NPFServerSettingTable _instance;

	public static NPFServerSettingTable instance => null;

	public NPFServerSetting GetNPFSetting(string name)
	{
		return null;
	}
}
