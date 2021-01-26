/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialSummonResultScene : MonoBehaviour, IPlaySummonInterface
	{
		// Fields
		[SerializeField]
		private GameObject stage3dNode;
		[SerializeField]
		private GameObject postEffectCameraGO;
		[SerializeField]
		private Transform camera3DParent;
		public Camera mainCamera;
		private List<SummonResultItemData> resultItems;
		private FlashPlayer[] itemFallFlashPlayers;
		private Vector3 resultFlashCameraInitPosition;
		private TutorialSummonPlayPhase playPhase;
		private Camera storedMainCamera;
		private Coroutine _execCoroutine;
		private TutorialSummonResultPage parentPage;
		private const float originalCameraFov = 60f;
		[HideInInspector]
		public Transform node3d;
		private static readonly string SE_ITEM_FALL;
		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;
		[HideInInspector]
		public RenderTexture charaWeaponRenderTexture;
		[HideInInspector]
		public CameraClearFlags oldFlashCameraClearFlags;
		private static readonly Vector2[] iconPosition1;
		private static readonly Vector2[] iconPosition2;
		private static readonly Vector2[] iconPosition3;
		private static readonly Vector2[] iconPosition4;
		private static readonly Vector2[] iconPosition5;
		private static readonly Vector2[] iconPosition6;
		private static readonly Vector2[] iconPosition7;
		private static readonly Vector2[] iconPosition8;
		private static readonly Vector2[] iconPosition9;
		public static readonly Vector2[] iconPosition10;
		public static readonly Vector2[][] iconPositions;
	
		// Properties
		public Camera OverlayUICamera { get; }
		Transform IPlaySummonInterface.node3d { get; }
		FlashPlayerManager IPlaySummonInterface.flashPlayerManager { get; }
		RenderTexture IPlaySummonInterface.charaWeaponRenderTexture { get; }
		CameraClearFlags IPlaySummonInterface.oldFlashCameraClearFlags { get; set; }
		public bool IsBoxSummon { get; }
	
		// Nested types
		public enum TutorialSummonPlayPhase
		{
			None = 0,
			Loading = 1,
			ReadFinish = 2,
			DropItem = 3,
			DropItemEnd = 4,
			ToResult = 5
		}
	
		private enum ItemFallKind
		{
			Normal = 0,
			Ssr = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__47_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _LoadResource_b__47_0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadResource_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialSummonResultScene __4__this;
			public Action loadEndCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadResource_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _LoadSummonBgScene_b__0();
			internal bool _LoadSummonBgScene_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSummonBgScene_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSummonBgScene_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySummonAnimation_d__54 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialSummonResultScene __4__this;
			public Action animEndCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySummonAnimation_d__54(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public int startIndex;
			public Vector2[] positionArray;
			public TutorialSummonResultScene __4__this;
			public int itemCount;
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal bool _ItemFallCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_1
		{
			// Fields
			public FlashPlayer flashPlayer;
			public __c__DisplayClass61_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass61_1();
	
			// Methods
			internal void _ItemFallCoroutine_b__1(int index);
		}
	
		[CompilerGenerated]
		private sealed class _ItemFallCoroutine_d__61 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialSummonResultScene __4__this;
			private __c__DisplayClass61_0 __8__1;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ItemFallCoroutine_d__61(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SkipCoroutine_d__68 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public TutorialSummonResultScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SkipCoroutine_d__68(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public TutorialSummonResultScene();
		static TutorialSummonResultScene();
	
		// Methods
		public void Start();
		public void OnDestroy();
		public void Init();
		public void StartLoading(TutorialSummonResultPage page, bool show3DModel, Action loadEndCallback);
		[IteratorStateMachine]
		private IEnumerator LoadResource(Action loadEndCallback);
		[IteratorStateMachine]
		public IEnumerator LoadSummonBgScene();
		private void OnAllAsyncLoadPrepared();
		private void ResetCameraPositionInStage();
		void IPlaySummonInterface.StartWhiteOutEffect(float inTime, float outTime);
		public void OnBoxSummonEvent(BoxSummonEventId eid);
		public void StartAnimation(Action animEndCallback);
		[IteratorStateMachine]
		private IEnumerator PlaySummonAnimation(Action animEndCallback);
		public void SkipFirstCut();
		private void Reset();
		public void StartItemFall();
		private void SetupEtoECamera();
		private void GoToResult(bool isFadingOut);
		public void ClearAll();
		[IteratorStateMachine]
		private IEnumerator ItemFallCoroutine();
		private FlashPlayer GetItemFallFlashPlayer(int index);
		private void ResetEtoECamera();
		private void ExitItemFall();
		public void DestroyItemFallFlashPlayers();
		private void ResetCamera(bool bIsDragon = false);
		public void SkipAniamtion();
		[IteratorStateMachine]
		private IEnumerator SkipCoroutine();
		public void DestroyStage3DNodeChildren();
		private void DestroyChildren(Transform t);
		[CompilerGenerated]
		private bool _PlaySummonAnimation_b__54_0();
	}
}
