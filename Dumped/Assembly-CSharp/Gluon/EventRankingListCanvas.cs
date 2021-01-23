/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventRankingListCanvas : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private EventRankingListPage _eventRankingPage_k__BackingField;
		public EventRankingListBase eventRankingListBase;
		public EventRankingListController eventRankingListController;
		public UnityAction cellButtonCallBack;
		public UnityAction backButtonCallBack;
		[SerializeField]
		private GameObject sliderObjRoot;
		[Header]
		[SerializeField]
		private Vector3 openDelayTime;
		[SerializeField]
		private UnityEngine.UI.Text rankRangeText;
		[SerializeField]
		private int rankingRangeFromTarget;
		private SceneUICanvas _sceneUiCanvas;
		private int currentDrumTopIndex;
		private int curTargetRank;
		private bool waitingForLoadingRankingUserAdditionalList;
		private int[,] sortRankRangeTable;
	
		// Properties
		public EventRankingListPage eventRankingPage { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SceneUICanvas sceneUiCanvas { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForLoadingRankingUserAdditionalListCoroutine_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventRankingListCanvas __4__this;
			public Vector2 scrollPos;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForLoadingRankingUserAdditionalListCoroutine_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__28_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnError_b__28_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public EventRankingListCanvas __4__this;
			public DrumScrollPopup popup;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _OnSortButtonPressed_b__0(int index, GameObject obj);
			internal void _OnSortButtonPressed_b__1();
		}
	
		// Constructors
		public EventRankingListCanvas();
	
		// Methods
		private void Start();
		private void CellButtonPressed(EventRankingListCellData selectData);
		public void InitFortEnteringAnim();
		public void LoadRankingUserList();
		public void LoadRankingUserAdditionalList(bool isHigher = true);
		[IteratorStateMachine]
		private IEnumerator WaitForLoadingRankingUserAdditionalListCoroutine(Vector2 scrollPos);
		private void GetRankingList();
		private void GetDataOnSuccess(QuestGetSupportUserListResponse res);
		public void OnError(ErrorType errorType, int resultCode);
		private void GetCurRankingRange(out int startRank, out int endRank);
		private int GetCurTargetRank();
		private List<EventRankingListController.UserRanking> GetEventRankingList(int startRank, int endRank);
		public void OnSortButtonPressed();
		private string GetRankRangeText(int startRank, int endRank);
		public void CloseButtonPressed();
		public void OnOpen();
		public void OnClose();
		private void StartObjFadeAnim(GameObject obj, Ease easing, float startAlpha, float endAlpha, float duration, float delayTime);
		private void StartObjMoveYAnim(GameObject obj, Ease easing, float startRelativeY, float endRelativeY, float duration, float delayTime);
		[CompilerGenerated]
		private bool _WaitForLoadingRankingUserAdditionalListCoroutine_b__25_0();
	}
}
