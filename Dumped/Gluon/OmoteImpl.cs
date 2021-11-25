using System;
using UnityEngine;

namespace Gluon
{
	public class OmoteImpl : MonoBehaviour
	{
		[Serializable]
		public class ExtraJson
		{
			public string message;
		}

		private static bool isInited;

		private static OmotePlugin _omotePlugin;

		public static string DeviceToken;

		public static Action<int, string> onReceivedAction;

		public static OmotePlugin omotePlugin => null;

		private static void CreateObject()
		{
		}

		public static void Initialize()
		{
		}

		public static string GetCountryFromLanguage(Localize.Language lang)
		{
			return null;
		}

		public void UpdateCountry(string countryCode)
		{
		}

		private void Start()
		{
		}

		public static void RegisterReceivedAction(Action<int, string> action)
		{
		}

		public static void ClearReceivedAction()
		{
		}
	}
}
