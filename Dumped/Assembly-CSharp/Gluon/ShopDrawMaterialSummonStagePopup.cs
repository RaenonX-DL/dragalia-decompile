/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopDrawMaterialSummonStagePopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text priceText;
		public UnityEngine.UI.Text holdingText;
		[Header]
		[SerializeField]
		public GameObject[] iconPosList;
		[Header]
		[SerializeField]
		public GameObject sendToPresentBoxGO;
		[Header]
		[SerializeField]
		public GameObject redrawLayoutGO;
		public GameObject backButtonGO;
		[Header]
		[SerializeField]
		public GameObject firstViewBottomItemNode;
		[Header]
		[SerializeField]
		public UIAnimationPublisher majorEnterPublisher;
		public UIAnimationPublisher exitPubliser;
		public UIAnimationPublisher subExitPubliser;
		[Header]
		[SerializeField]
		public FlashPlayerManager flashPlayerManager;
		[Header]
		[SerializeField]
		public RawImage flashTextureImage;
		public float halfCutoffDuration;
		public float maximumCutoffDuration;
		private int price;
		private Action onDraw;
		private List<EntityData> resultData;
		private Camera flashCamera;
		private Camera oldFlashCamera;
		private FlashPlayer[] itemFallFlashPlayers;
		private FlashPlayer backFlashPlayer;
		private const string backFlashPath = "Prefabs/OutGame/ShopTrade/Flash/MaterialSummon/pf_ShopSummonMaterialBackLight";
		private const string frontFlashPath = "Prefabs/OutGame/ShopTrade/Flash/MaterialSummon/pf_ShopSummonMaterialLightImpact";
		public static readonly Vector2[] iconPositions;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public bool isAllLoadedDone;
			public Vector2[] positionArray;
			public int endedAnimationCount;
			public ShopDrawMaterialSummonStagePopup __4__this;
			public Action proceedLoading;
			public int resultCount;
			public bool frontFlashEnded;
			public Action __9__6;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _ShowResultCoroutine_b__0();
			internal void _ShowResultCoroutine_b__6();
			internal bool _ShowResultCoroutine_b__1();
			internal bool _ShowResultCoroutine_b__2();
			internal void _ShowResultCoroutine_b__7();
			internal bool _ShowResultCoroutine_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_1
		{
			// Fields
			public FlashPlayer flashPlayer;
			public __c__DisplayClass28_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass28_1();
	
			// Methods
			internal void _ShowResultCoroutine_b__5(int index);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__28_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _ShowResultCoroutine_b__28_3();
		}
	
		[CompilerGenerated]
		private sealed class _ShowResultCoroutine_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ShopDrawMaterialSummonStagePopup __4__this;
			private __c__DisplayClass28_0 __8__1;
			private SceneBase _scene_5__2;
			private Canvas _canvas_5__3;
			private int _i_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowResultCoroutine_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public Action onFinished;
			public TouchGuardObject touchGuardObj;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _PlayExitAnimation_b__0();
		}
	
		// Constructors
		public ShopDrawMaterialSummonStagePopup();
		static ShopDrawMaterialSummonStagePopup();
	
		// Methods
		public static ShopDrawMaterialSummonStagePopup Create(Camera flashCamera, List<EntityData> resultData, int price, Action onDraw);
		protected override void Start();
		protected override void OnDestroy();
		public static Vector3 GetFlashPositionFromLayoutPosition(Vector2 pos);
		[IteratorStateMachine]
		private IEnumerator ShowResultCoroutine();
		private void DestroyItemFallFlashPlayers();
		public void OnSummonButtonPressed();
		public void OnBackButtonPressed();
		private void PlayExitAnimation(Action onFinished);
		[CompilerGenerated]
		private void _OnSummonButtonPressed_b__30_0();
	}
}
