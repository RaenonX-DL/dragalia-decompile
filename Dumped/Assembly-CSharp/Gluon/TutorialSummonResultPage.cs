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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialSummonResultPage : TutorialSummonPageBase
	{
		// Fields
		[SerializeField]
		private Image whiteOutImage;
		[SerializeField]
		private Button endButton;
		[SerializeField]
		private Button resetButton;
		[SerializeField]
		private Button unitListButton;
		[SerializeField]
		private Button nextButton;
		[SerializeField]
		private GameObject nowLoading;
		[SerializeField]
		private RectTransform itemsParentRectTransform;
		[SerializeField]
		private RectTransform edgeToEdgeRectTransform;
		[SerializeField]
		private RectTransform resultItemsRectTransform;
		[SerializeField]
		public RawImage bg3dRenderTextureImage;
		[SerializeField]
		public GameObject resultItemTemplate;
		[SerializeField]
		private UnityEngine.UI.Text nextButtonText;
		[SerializeField]
		private Transform[] resultItemParents;
		[SerializeField]
		private UIAnimationPublisher enterPublisher;
		private List<GameObject> resultItems;
		private Vector2 _canvasSize;
		private Vector2 basePos;
		private bool is3DSceneLoaded;
		private TutorialSummonResultScene animScene;
		private Sequence whiteOutSeq;
		private GameObject renderTextureCameraObj;
		private TouchGuardObject resetTouchGuard;
	
		// Properties
		public Vector2 canvasSize { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public TutorialSummonResultPage __4__this;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _Load3DScene_b__0(GameObject prefab);
		}
	
		[CompilerGenerated]
		private sealed class _ChangeToResultPage_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float waitingTime;
			public TutorialSummonResultPage __4__this;
			public bool isFadingOut;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeToResultPage_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public CommonPopup popup;
			public TutorialSummonResultPage __4__this;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _OnTutorialSummonEndButton_b__0();
			internal void _OnTutorialSummonEndButton_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__44_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnTutorialSummonEndButton_b__44_2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public CommonPopup popup;
			public TutorialSummonResultPage __4__this;
			public Action<PageBase> __9__3;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _OnSummonResetButtonPressed_b__0();
			internal void _OnSummonResetButtonPressed_b__2();
			internal void _OnSummonResetButtonPressed_b__3(PageBase nextPage);
			internal void _OnSummonResetButtonPressed_b__1();
		}
	
		// Constructors
		public TutorialSummonResultPage();
	
		// Methods
		private void Start();
		public override void OnPageBecomeInActive();
		public override void OnPageBecomeActive(object data);
		private void Load3DScene(Action callback);
		public void ResetFlashCameraSize();
		public void Show(bool isResult);
		public Vector2 GetIconPosition(Vector2 pos);
		public Vector3 GetFlashPositionFromLayoutPosition(Vector2 pos);
		[IteratorStateMachine]
		public IEnumerator ChangeToResultPage(bool isFadingOut, float waitingTime);
		public void CreateBgRenderTexture();
		public void StartWhiteOutEffect(float inTime, float outTime);
		public void SetContent(bool isFadingOut);
		private void SetupContents();
		private void SetupItemList();
		private void SetupItemListSub(SummonResultItemData drawInfo, int index, int total);
		private void UpdateNextItems();
		private void TeardownContents();
		public void Release3DObjects();
		public void OnNextButton();
		public void ShowNextItems();
		public void OnTutorialSummonEndButton();
		public void OnSummonUnitList();
		public void OnSummonResetButtonPressed();
		public void StartNextSummonAnimation();
		[CompilerGenerated]
		private void _OnPageBecomeActive_b__26_0();
		[CompilerGenerated]
		private void _OnPageBecomeActive_b__26_1();
		[CompilerGenerated]
		private Color _StartWhiteOutEffect_b__34_0();
		[CompilerGenerated]
		private void _StartWhiteOutEffect_b__34_1(Color Color);
		[CompilerGenerated]
		private Color _StartWhiteOutEffect_b__34_2();
		[CompilerGenerated]
		private void _StartWhiteOutEffect_b__34_3(Color Color);
		[CompilerGenerated]
		private void _ShowNextItems_b__43_0();
	}
}
