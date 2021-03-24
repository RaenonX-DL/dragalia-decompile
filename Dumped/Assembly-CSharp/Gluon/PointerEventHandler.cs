/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class PointerEventHandler : FastUpdateMonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Fields
		public static WeakReference globalTouchingHandler;
		public UnityEvent onClick;
		public UnityEvent onLongClick;
		public Toggle.ToggleEvent onToggleClicked;
		private TouchEvent _onPointerEnter;
		private TouchEvent _onPointerExit;
		private TouchEvent _onPointerDown;
		private TouchEvent _onPointerUp;
		[HideInInspector]
		public UnityEvent onDelayPressReleased;
		[Header]
		[SerializeField]
		public bool canLongTouch;
		[Header]
		[SerializeField]
		public bool canKeepLongTouch;
		[Header]
		[SerializeField]
		public bool needHandleMultiTouch;
		public float longTouchThreshold;
		public float keepLongTouchDuration;
		public float doubleTouchThreshold;
		private bool isCanceled;
		public static DateTime lastTouchDownDateTime;
		private float touchTime;
		private Vector3 startTouchPos;
		private float lastKeepLongTouchCalledTime;
		private bool isRepeatClick;
		private StandaloneInputModuleCustom inputModule;
		private Selectable targetSelectable;
		private bool isOn;
		private bool isToggle;
		private Coroutine watchTouchCoroutine;
		[HideInInspector]
		public bool isBlockingByUIAnimation;
		public static bool suppressBigEffect;
		public Action onClickAnimation;
		public UnityAction<float> onFlickVertical;
		public float shrinkTouchGap;
		public bool isMultiSelect;
		private bool isPointerDownChecked;
		[CompilerGenerated]
		private float _touchGap_k__BackingField;
		[CompilerGenerated]
		private float _realShrinkTouchGap_k__BackingField;
		[Header]
		[SerializeField]
		public bool isShowTapEffect;
		[Header]
		[SerializeField]
		private bool checkExitOnPointerUp;
	
		// Properties
		public TouchEvent onPointerEnter { get; set; }
		public TouchEvent onPointerExit { get; set; }
		public TouchEvent onPointerDown { get; set; }
		public TouchEvent onPointerUp { get; set; }
		private float touchGap { [CompilerGenerated] get; [CompilerGenerated] set; }
		private float realShrinkTouchGap { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		public class TouchEvent : UnityEvent<PointerEventData>
		{
			// Constructors
			public TouchEvent();
		}
	
		[CompilerGenerated]
		private sealed class _WatchTouch_d__68 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PointerEventHandler __4__this;
			public PointerEventData eventData;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WatchTouch_d__68(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PointerEventHandler();
		static PointerEventHandler();
	
		// Methods
		private void Awake();
		private void Start();
		private void OnApplicationPause(bool pause);
		public void OnPointerClick(PointerEventData eventData);
		private void StopWatchTouchCoroutine();
		public void OnPointerDown(PointerEventData eventData);
		private void RemoveGlobalTouch();
		public void OnPointerUp(PointerEventData eventData);
		private void PreventFortCursol();
		public void OnPointerEnter(PointerEventData eventData);
		public void OnPointerExit(PointerEventData eventData);
		public void PlaySE();
		[IteratorStateMachine]
		private IEnumerator WatchTouch(PointerEventData eventData);
		private bool IsMoved(Vector3 curTouchPos);
		private float FlickVertical(Vector3 curTouchPos);
		private bool IsValidClick(PointerEventData pointEventData);
		private bool IsTargetValid();
		protected override void OnDisable();
		private void ResetToggleState();
		public void ResetFlagWhenIsOnChangedByScript();
		public void ForceReleaseTargetSelectable();
		public void ReplaceCallback(UnityAction callback);
	}
}
