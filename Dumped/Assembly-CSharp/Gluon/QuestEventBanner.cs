/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventBanner : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image bannerImage;
		[SerializeField]
		private GameObject bannerRoot;
		[SerializeField]
		private bool _isInitializeOnStart;
		private TargetEventType _targetEventType;
		private TargetEventPeriod _targetEventPeriod;
		private PointerEventHandler pointerEventHandler;
		private List<EventDataElement> bannerData;
		private EventDataElement nowMainEventData;
		[SerializeField]
		private UnityEngine.UI.Text durationText;
	
		// Properties
		public bool isInitializeOnStart { get; set; }
		public TargetEventType targetEventType { get; set; }
		public TargetEventPeriod targetEventPeriod { get; set; }
	
		// Nested types
		public enum TargetEventType
		{
			ForQuestSelectScene = 0,
			ForFortScene = 1
		}
	
		public enum TargetEventPeriod
		{
			All = 0,
			EnableToPlay = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<EventDataElement> __9__23_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Initialize_b__23_0(EventDataElement a, EventDataElement b);
		}
	
		[CompilerGenerated]
		private sealed class _EventQuestTransition_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestEventBanner __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _EventQuestTransition_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestEventBanner();
	
		// Methods
		private void Start();
		private void SetDisp(bool value);
		public void SetCallback(UnityAction call);
		public void Initialize();
		public static bool IsTargetEventType(QuestEventGroupElement groupElement, TargetEventType targetEventType);
		public static bool IsTargetEventPeriod(EventDataElement eventDataElement, TargetEventPeriod targetEventPeriod);
		public void OnClickBannerIcon();
		[IteratorStateMachine]
		private IEnumerator EventQuestTransition();
		[CompilerGenerated]
		private void _Initialize_b__23_1(Material mat);
		[CompilerGenerated]
		private void _EventQuestTransition_b__27_0();
	}
}
