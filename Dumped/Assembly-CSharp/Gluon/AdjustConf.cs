/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using com.adjust.sdk;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AdjustConf : ScriptableObject
	{
		// Fields
		[SerializeField]
		public string appToken;
		[SerializeField]
		public List<long> signature;
		[SerializeField]
		public AdjustLogLevel logLevel;
		[SerializeField]
		private List<EventItem> events;
		public const AdjustEnvironment environment = AdjustEnvironment.Production;
		private static string region;
		private static AdjustConf _instance;
	
		// Properties
		public static AdjustConf instance { get; }
	
		// Nested types
		[Serializable]
		private class EventItem
		{
			// Fields
			public string key;
			public string token;
	
			// Constructors
			public EventItem();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal bool _GetEventItem_b__0(EventItem s);
		}
	
		// Constructors
		public AdjustConf();
		static AdjustConf();
	
		// Methods
		public static void SetRegion(string location);
		public string GetAppToken();
		public AdjustLogLevel GetLogLevel();
		public string GetEventToken(string eventName);
		private EventItem GetEventItem(string name);
	}
}
