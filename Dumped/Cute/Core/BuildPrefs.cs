using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cute.Core
{
	public class BuildPrefs : ScriptableObject
	{
		[Serializable]
		private class KeyValuePair
		{
			public string key;

			public string value;
		}

		private static BuildPrefs instance;

		public const string buildKey = "-buildKey";

		public const string buildValue = "-buildValue";

		[SerializeField]
		private List<KeyValuePair> prefs;

		private static BuildPrefs Instance => null;

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
