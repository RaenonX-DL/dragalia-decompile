/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonAnimPage : EventQuestPageBase
	{
		// Fields
		[SerializeField]
		private BoxSummonResult boxSummonResult;
		[SerializeField]
		private Image whiteOutImage;
		[SerializeField]
		private GameObject screenTapObj;
		[SerializeField]
		private Button skipButton;
		[SerializeField]
		private GameObject nowLoading;
		[SerializeField]
		private RectTransform itemsParentRectTransform;
		[SerializeField]
		private RectTransform edgeToEdgeRectTransform;
		[SerializeField]
		private RectTransform resultItemsRectTransform;
		public RawImage bg3dRenderTextureImage;
		private GameObject renderTextureCameraObj;
		private Sequence whiteOutSeq;
		private BoxSummonAnimScene animScene;
		private Canvas uiCanvas;
		private const string boxSummonAnimBGM = "BGM_SUMMON_0002_01";
		private bool is3DSceneLoaded;
		[CompilerGenerated]
		private AudioPlayback _bgmAudioPlayer_k__BackingField;
		public Vector2 _canvasSize;
		private Vector2 basePos;
	
		// Properties
		public Canvas UiCanvas { get; }
		public AudioPlayback bgmAudioPlayer { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector2 canvasSize { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public BoxSummonAnimPage __4__this;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _Load3DScene_b__0(GameObject prefab);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public TouchGuardObject touchGuard1;
			public BoxSummonAnimPage __4__this;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _StartLoadingResources_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _ChangeToResultPage_d__40 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float waitingTime;
			public BoxSummonAnimPage __4__this;
			public bool isFadingOut;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeToResultPage_d__40(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BoxSummonAnimPage();
	
		// Methods
		private void Start();
		public override void OnPageBecomeActive(object data);
		public override void OnPageBecomeInActive();
		public override void ResetSummonData();
		public void ResetFlashCameraSize();
		public void StartSummonAnimation();
		public void StartNextSummonAnimation();
		private void Load3DScene(Action callback);
		private void StartLoadingResources();
		public void StartWhiteOutEffect(float inTime, float outTime);
		private void SkipAnimation(bool needFadeOut);
		public void OnSkipButtonPressed();
		public void Show(bool isResult);
		public void ShowResultUIs(bool toShow);
		public void ShowSkipButton(bool isShown);
		[IteratorStateMachine]
		public IEnumerator ChangeToResultPage(bool isFadingOut, float waitingTime);
		public void OnScreenTapped();
		public void CreateBgRenderTexture();
		public Vector2 GetIconPosition(Vector2 pos);
		public Vector3 GetFlashPositionFromLayoutPosition(Vector2 pos);
		protected override int GetMaxExecCount();
		public void Release3DObjects();
		[CompilerGenerated]
		private void _OnPageBecomeActive_b__26_0();
		[CompilerGenerated]
		private void _OnPageBecomeActive_b__26_1();
		[CompilerGenerated]
		private void _StartNextSummonAnimation_b__31_0();
		[CompilerGenerated]
		private Color _StartWhiteOutEffect_b__34_0();
		[CompilerGenerated]
		private void _StartWhiteOutEffect_b__34_1(Color Color);
		[CompilerGenerated]
		private Color _StartWhiteOutEffect_b__34_2();
		[CompilerGenerated]
		private void _StartWhiteOutEffect_b__34_3(Color Color);
	}
}
