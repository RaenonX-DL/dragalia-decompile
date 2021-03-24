/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OmoteImpl : MonoBehaviour
	{
		// Fields
		private static bool isInited;
		private static OmotePlugin _omotePlugin;
		public static string DeviceToken;
		public static Action<int, string> onReceivedAction;
	
		// Properties
		public static OmotePlugin omotePlugin { get; }
	
		// Nested types
		[Serializable]
		public class ExtraJson
		{
			// Fields
			public string message;
	
			// Constructors
			public ExtraJson();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static OmotePlugin.OmoteEventHandler<OmotePlugin.PushNotificationEventArgs> __9__11_0;
			public static OmotePlugin.OnRegistrationTokenReceivedEventHandler __9__11_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Start_b__11_0(object sender, OmotePlugin.PushNotificationEventArgs e);
			internal void _Start_b__11_1(object sender, OmotePlugin.RegistrationTokenEventArgs e);
		}
	
		// Constructors
		public OmoteImpl();
		static OmoteImpl();
	
		// Methods
		private static void CreateObject();
		public static void Initialize();
		public static string GetCountryFromLanguage(Localize.Language lang);
		public void UpdateCountry(string countryCode);
		private void Start();
		public static void RegisterReceivedAction(Action<int, string> action);
		public static void ClearReceivedAction();
	}
}
