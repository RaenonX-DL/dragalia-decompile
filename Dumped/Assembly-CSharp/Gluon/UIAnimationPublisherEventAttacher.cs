/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UIAnimationPublisherEventAttacher : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public UIAnimationPublisher publisher;
		public UnityEvent onEnterEvent;
		public UnityEvent onExitEvent;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public Action action;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _JoinActions_b__0();
		}
	
		// Constructors
		public UIAnimationPublisherEventAttacher();
	
		// Methods
		private void Start();
		private UnityEvent JoinActions(UnityEvent baseEvent, UnityEvent attachmentEvent);
	}
}
