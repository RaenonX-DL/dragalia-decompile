/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class HomeScoreBoardCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private Animator titleAnimator;
		[Header]
		[SerializeField]
		public Sprite[] spliteList;
		public Image[] tabImageList;
		[SerializeField]
		private Animator[] tabAnimatorList;
		[SerializeField]
		private Transform[] platePos;
		[SerializeField]
		private GameObject[] rankingParent;
		private List<HomeScoreBoardPlate>[] rankingPlateList;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlateListInAnim_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public HomeScoreBoardCanvas __4__this;
			public STGDataManager.Mode mode;
			private List<HomeScoreBoardPlate> _plateList_5__2;
			private GameObject _parent_5__3;
			private STGDataManager.RankingData[] _rankingData_5__4;
			private int _i_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlateListInAnim_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartUIAnimWithWaight_d__20 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float diray;
			public Animator animator;
			public bool isIn;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartUIAnimWithWaight_d__20(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public HomeScoreBoardCanvas();
	
		// Methods
		private void Start();
		public void Appear();
		public void Hide();
		public void OnNormalModeButtonPressed();
		public void OnHardMordButtonPressed();
		public void OnNightmareMordButtonPressed();
		private void OnGameMordButtonPressed(STGDataManager.Mode mode, bool isPlaySe = true);
		private void ChangeTabImage(STGDataManager.Mode currentMode, STGDataManager.Mode mode);
		private void PlateListAnimationStart(STGDataManager.Mode currentMode, STGDataManager.Mode mode);
		[IteratorStateMachine]
		private IEnumerator PlateListInAnim(STGDataManager.Mode mode);
		private void PlateListOutAnim(STGDataManager.Mode mode, bool isHide = false);
		private HomeScoreBoardPlate CreateScoreBordPlate(GameObject parent);
		private void StartUIAnim(Animator animator, bool isIn, float diray = 0f);
		[IteratorStateMachine]
		private IEnumerator StartUIAnimWithWaight(Animator animator, bool isIn, float diray);
		private bool IsClearedNormal();
		private bool IsReleaseNightmare();
		protected override void OnDestroy();
	}
}
