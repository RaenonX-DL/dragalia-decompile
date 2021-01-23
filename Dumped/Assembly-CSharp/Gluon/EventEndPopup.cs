/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventEndPopup : CommonPopup
	{
		// Fields
		public static string playerPrefsKey;
		public static string playerPrefsKeyForPeriod;
		public Image logoImage;
		[NonSerialized]
		public EventDataElement data;
		private const int useMasterTextEventId = 20802;
	
		// Nested types
		public enum EventPeriod
		{
			NoChecked = 0,
			In = 1,
			Out = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public bool isReceived;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _CreateIfNeededAsync_b__1(EventDataElement x);
			internal bool _CreateIfNeededAsync_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_1
		{
			// Fields
			public bool isPopupClose;
			public bool isGoEvent;
	
			// Constructors
			public __c__DisplayClass6_1();
	
			// Methods
			internal void _CreateIfNeededAsync_b__3(bool toEvent);
			internal bool _CreateIfNeededAsync_b__4();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<EventDataElement> __9__6_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _CreateIfNeededAsync_b__6_0(EventDataElement a, EventDataElement b);
		}
	
		[CompilerGenerated]
		private sealed class _CreateIfNeededAsync_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Action<bool> onProcessEnd;
			private __c__DisplayClass6_1 __8__1;
			private List<EventDataElement> __7__wrap1;
			private EventDataElement _eventData_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateIfNeededAsync_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public EventEndPopup popup;
			public Action<bool> onProcessEnd;
			public EventDataElement data;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _CreatePopup_b__0();
			internal void _CreatePopup_b__1();
		}
	
		// Constructors
		public EventEndPopup();
		static EventEndPopup();
	
		// Methods
		[IteratorStateMachine]
		public static IEnumerator CreateIfNeededAsync(Action<bool> onProcessEnd);
		private static void CreatePopup(EventDataElement data, Action<bool> onProcessEnd);
	}
}
