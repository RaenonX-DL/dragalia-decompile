/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPage2dCharacter : MonoBehaviour, IPointerClickHandler
	{
		// Fields
		public Image image;
		private string voiceSheetName;
		private List<string> lastVoiceGroup;
		private int numOfVoice;
		private int lastVoiceIndex;
		private Vector2 initialPosition;
		[NonSerialized]
		public Action overrideAction;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayVoiceCoroutine_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPage2dCharacter __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayVoiceCoroutine_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MyPage2dCharacter();
	
		// Methods
		private void Awake();
		public void SetBgCharacterImage(int charaId);
		public void OnPointerClick(PointerEventData eventData);
		[IteratorStateMachine]
		private IEnumerator PlayVoiceCoroutine();
		private void OnDestroy();
		private void ReleaseAllVoiceGroup();
		[CompilerGenerated]
		private bool _PlayVoiceCoroutine_b__10_0();
	}
}
