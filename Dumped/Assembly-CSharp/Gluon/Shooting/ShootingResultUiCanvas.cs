/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class ShootingResultUiCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private GameObject difficultyNormal;
		[SerializeField]
		private GameObject difficultyHard;
		[SerializeField]
		private GameObject difficultyNightmare;
		[Header]
		[SerializeField]
		public Sprite[] numbers;
		public Image[] digits;
		[SerializeField]
		private Animator canvasAnim;
		[SerializeField]
		private Animator scoreBoardAnim;
		[SerializeField]
		private Animator rankingAnim;
		[SerializeField]
		private Animator retryButtonAnim;
		[SerializeField]
		private Animator nextButtonAnim;
		[SerializeField]
		private Animator whiteScreenAnimator;
		[SerializeField]
		private Animator blackScreenAnimator;
		[SerializeField]
		private GameObject scoreBoardNode;
		[SerializeField]
		private List<GameObject> breakDownPosList;
		[SerializeField]
		private UnityEngine.UI.Text bonusText;
		[SerializeField]
		private GameObject rankingNode;
		[SerializeField]
		private List<Transform> platePos;
		[SerializeField]
		private GameObject cloudObject;
		private List<ResultScoreBoardPlate> rankingPlateList;
		private const int hardBreakdownRankNum = 4;
		private const int resultBackKeyEventNum = 0;
	
		// Nested types
		[CompilerGenerated]
		private struct _Start_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ShootingResultUiCanvas __4__this;
			private TaskAwaiter<DreamAdventureClearResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public ShootingResultUiCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _OnNextButtonPressed_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__25_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ReStartShooting_b__25_0();
		}
	
		[CompilerGenerated]
		private sealed class _FadeOut_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShootingResultUiCanvas __4__this;
			public Action onCompletedAction;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _FadeOut_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartUIAnimWithWaight_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float diray;
			public ShootingResultUiCanvas __4__this;
			public Animator animator;
			public bool isIn;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartUIAnimWithWaight_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ShootingResultUiCanvas();
	
		// Methods
		private async void Start();
		private void Appear();
		public void OnBackButtonPressed();
		public void OnNextButtonPressed();
		private void ReStartShooting();
		[IteratorStateMachine]
		private IEnumerator FadeOut(Action onCompletedAction);
		private void SetResultData();
		private void SetDifficulty(STGDataManager.Mode mode);
		private void SetTotalScore(int score);
		private void SetRetryButton(float diry = 0f);
		private void PlayTotalScoreVoice(STGDataManager.CurrentGameData data);
		private void SetBreakdown(STGDataManager.CurrentGameData data);
		private void SetScorePlate(int rank, GameObject parent, STGDataManager.CurrentGameData.EnemyRankBreakdown enemyBreakdown);
		private ScoreBreakDownTextPlate CreateBreakdownPlate(GameObject parent);
		private void setBonusPlate(GameObject parent, int score);
		private void SetRanking();
		private void PlayRankInSe(int rank);
		private void PlayRankInVoice(int rank);
		private ResultScoreBoardPlate CreateScoreBordPlate(GameObject parent);
		private bool IsRankIn();
		private void StartUIAnim(Animator animator, bool isIn);
		private void StartUIAnim(Animator animator, bool isIn, float diray);
		[IteratorStateMachine]
		private IEnumerator StartUIAnimWithWaight(Animator animator, bool isIn, float diray);
		private void SetBuckKeyEvent(int sortingOrder, UnityAction action);
		private void RemoveBuckKeyEvent(int sortingOrder);
		protected override void OnDestroy();
		[CompilerGenerated]
		private void _Appear_b__22_0();
		[CompilerGenerated]
		private void _OnBackButtonPressed_b__23_0();
		[CompilerGenerated]
		private void _OnNextButtonPressed_b__24_0();
	}
}
