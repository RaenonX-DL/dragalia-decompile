using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cute.Core
{
	public class ProjectPrefs : ScriptableObject
	{
		[Serializable]
		private class KeyValuePair
		{
			public string key;

			public string value;
		}

		private static ProjectPrefs instance;

		[SerializeField]
		private List<KeyValuePair> prefs;

		private static ProjectPrefs Instance => null;

		public static bool IsReady => default(bool);

		public static string GetString(string key)
		{
			return null;
		}

		public static string GetString(string key, string defaultValue)
		{
			return null;
		}
	}
}
