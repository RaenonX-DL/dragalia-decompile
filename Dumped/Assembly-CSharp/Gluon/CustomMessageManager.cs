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
	public class CustomMessageManager
	{
		// Fields
		private static CustomMessageManager _instance;
		private Dictionary<int, List<CustomMessageInfo>> messageListeners;
	
		// Properties
		public static CustomMessageManager instance { get; }
	
		// Nested types
		private class CustomMessageInfo
		{
			// Fields
			public ICustomMessage messageReceiver;
			public GameObject target;
	
			// Constructors
			public CustomMessageInfo(ICustomMessage messageReceiver, GameObject target);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public ICustomMessage messageReceiver;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal bool _RemoveListener_b__0(CustomMessageInfo item);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public GameObject targetObj;
			public Predicate<CustomMessageInfo> __9__0;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _RemoveListener_b__0(CustomMessageInfo item);
		}
	
		// Constructors
		private CustomMessageManager();
		static CustomMessageManager();
	
		// Methods
		public void RegisterListener(CustomMessageType messageType, ICustomMessage messageReceiver, GameObject target);
		public void RemoveListener(CustomMessageType messageType, ICustomMessage messageReceiver);
		public void RemoveListener(GameObject targetObj);
		public void RemoveAllListeners(CustomMessageType messageType);
		public void Clear();
		public void PostMessage(CustomMessageType messageType, object data);
		public void CheckTargets();
	}
}
