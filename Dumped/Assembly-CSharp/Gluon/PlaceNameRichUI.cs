/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlaceNameRichUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text placeName;
		[SerializeField]
		private Image bg;
		[SerializeField]
		private UnityEngine.UI.Text floorText;
		[SerializeField]
		private UnityEngine.UI.Text floorPlace;
		[SerializeField]
		private Image lineImage;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exConditionText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exCondition2Text;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exCondition3Text;
		[SerializeField]
		[Tooltip]
		private RectTransform exConditionRt;
		[SerializeField]
		[Tooltip]
		private RectTransform exCondition2Rt;
		[SerializeField]
		[Tooltip]
		private RectTransform exCondition3Rt;
		[Header]
		[SerializeField]
		private float fadeInTime;
		[SerializeField]
		private float fadeOutTime;
		[SerializeField]
		private float bgAlpha;
		private RectTransform rootRt;
		private Tweener tweenerFade;
		private Coroutine coroutine;
		private PlayFTU ftu;
		private PlayFTU.Type ftuType;
		private string ftuCloseLabel;
		private bool isActive;
		private bool isRaedy;
		private bool isFloor;
		private readonly Color REBORN_CONDITION_COLOR;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlayFlash_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaceNameRichUI __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayFlash_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayCloseFlash_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlaceNameRichUI __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayCloseFlash_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PlaceNameRichUI();
	
		// Methods
		public static PlaceNameRichUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public void SetFTU(PlayFTU ftu, PlayFTU.Type ftuType, string ftuCloseLabel);
		public void Ready(string placeName, int floor);
		private void OnReady(PlayFTU sender);
		private void SetupLayout();
		public void Open();
		[IteratorStateMachine]
		private IEnumerator PlayFlash();
		public void Close();
		[IteratorStateMachine]
		private IEnumerator PlayCloseFlash();
		private void OnUpdateFadeIn(float value);
		private void OnUpdateFadeOut(float value);
		private void OnCompleteFadeIn();
		private void OnCompleteFadeOut();
		public void Release();
		private void SetActive(bool active);
	}
}
