/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ServerSettings : ScriptableObject
	{
		// Fields
		[SerializeField]
		private List<SettingItem> settings;
		private static ServerSettings _instance;
	
		// Properties
		public static ServerSettings instance { get; }
	
		// Nested types
		[Serializable]
		private class SettingItem
		{
			// Fields
			public string key;
			public string server;
			public string multi;
			public string baas;
			public string appId;
	
			// Constructors
			public SettingItem();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<SettingItem, string> __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal string _GetServerList_b__13_0(SettingItem s);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal bool _GetSettingItem_b__0(SettingItem s);
		}
	
		// Constructors
		public ServerSettings();
		static ServerSettings();
	
		// Methods
		public string GetServerId();
		public string GetNPFBaaSServer();
		public string GetNPFBaaSServer(string name);
		public string GetBundleIdentifier(string name);
		public string GetAppSecret();
		public string GetAppId();
		public string GetServerAddress();
		private string GetServerAddress(string name);
		public string[] GetServerList();
		public string GetMultiServerAddress();
		private string GetMultiServerAddress(string name);
		public string GetPhotonAppId();
		private string GetPhotonAppId(string name);
		private SettingItem GetSettingItem(string name);
	}
}
