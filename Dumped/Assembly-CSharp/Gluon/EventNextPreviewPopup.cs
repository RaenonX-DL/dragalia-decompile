/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventNextPreviewPopup : PopupBase
	{
		// Fields
		public int imageCount;
		[CompilerGenerated]
		private EventDataElement _eventData_k__BackingField;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private PageViewBase pageView;
		[SerializeField]
		private UnityEngine.UI.Text infoText;
		[SerializeField]
		private UnityEngine.UI.Text closeText;
		private AudioPlayback voice;
		private string voiceGroupName;
		private bool isSequelEventPreview;
		public static string popupPrefabPath;
		public static string pagePrefabPath;
		private static readonly string eventNoticeImageName;
		private static readonly string sequelEventNoticeImageName;
	
		// Properties
		public EventDataElement eventData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public EventNextPreviewPopup __4__this;
			public string voiceName1;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal bool _PlayVoiceCoroutine_b__0();
			internal bool _PlayVoiceCoroutine_b__1();
			internal bool _PlayVoiceCoroutine_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _PlayVoiceCoroutine_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventNextPreviewPopup __4__this;
			private __c__DisplayClass19_0 __8__1;
			private string _voiceName2_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayVoiceCoroutine_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EventNextPreviewPopup();
		static EventNextPreviewPopup();
	
		// Methods
		public static EventNextPreviewPopup Create(EventDataElement eventData, bool isSequelEventPreview, Transform parentTransform = null);
		protected override void Start();
		protected override void OnDestroy();
		[IteratorStateMachine]
		private IEnumerator PlayVoiceCoroutine();
		private void OnPageChanged(int pageIndex);
		[CompilerGenerated]
		private void _Start_b__17_0(GameObject page, int index);
	}
}
