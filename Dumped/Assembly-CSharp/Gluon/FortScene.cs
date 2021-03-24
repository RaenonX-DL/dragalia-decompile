/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortScene : SceneBase
	{
		// Fields
		[CompilerGenerated]
		private static FortScene _instance_k__BackingField;
		public GameObject uiParent;
		public GameObject fortWorld;
		public Transform cameraFollowTarget;
		public Camera mainCamera;
		[CompilerGenerated]
		private Canvas _uiCanvas_k__BackingField;
		[CompilerGenerated]
		private PopupBase _activePopup_k__BackingField;
		[CompilerGenerated]
		private FortViewController _fortViewCtrl_k__BackingField;
		[CompilerGenerated]
		private FortPutController _fortPutCtrl_k__BackingField;
		[CompilerGenerated]
		private FortCameraController _cameraCtrl_k__BackingField;
		[CompilerGenerated]
		private FortModel _model_k__BackingField;
		[CompilerGenerated]
		private FlashPlayerManager _flashPlayerManager_k__BackingField;
		public FortAssetsManager assetsManager;
		[CompilerGenerated]
		private bool _isGridMode_k__BackingField;
		[Header]
		[SerializeField]
		private float _titleFadeInDuration;
		[SerializeField]
		private float _titleDispDuration;
		[SerializeField]
		private float _titleFadeOutDuration;
		[SerializeField]
		private float characterDispDelay;
		[Header]
		[SerializeField]
		private Vector3 blackSmithTutorialEffectAdjustPos;
		private int _noContactSelectedDradonId;
		private EventSystem _eventSystem;
		private const float FlashCameraDefaultSize = 5f;
		private const string dragonAnimationControllerPath = "Animations/OutGame/DragonContact/d200001_01_mot";
		private const string fortGraphicsDataPath = "Prefabs/OutGame/Fort/Graphics/FortGraphicsData";
	
		// Properties
		public static FortScene instance { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Canvas uiCanvas { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int noContactSelectedDradonId { get; private set; }
		public float titleFadeInDuration { get; }
		public float titleDispDuration { get; }
		public float titleFadeOutDuration { get; }
		public PopupBase activePopup { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FortViewController fortViewCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FortPutController fortPutCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FortCameraController cameraCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FortModel model { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FlashPlayerManager flashPlayerManager { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isGridMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public EventSystem eventSystem { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public UnityEvent toTopEvent;
			public FortScene __4__this;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _Start_b__4();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_1_6_d__73 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_1_6_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public FortScene __4__this;
			public int dragonId;
	
			// Constructors
			public __c__DisplayClass76_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_1
		{
			// Fields
			public string modelPath;
			public __c__DisplayClass76_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass76_1();
	
			// Methods
			internal void _LoadDragon_b__0(GameObject prefab);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<DragonGetContactDataResponse> __9__76_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _LoadDragon_b__76_1(DragonGetContactDataResponse response);
		}
	
		// Constructors
		public FortScene();
	
		// Methods
		private void Awake();
		private void Start();
		public static List<string> GetPreLoadAssetList();
		public static void ClearPreLoadingAsset();
		public static void LoadEffectResources();
		public bool CheckTutorialRequired(bool isSetTutorialStep = true);
		public bool CheckBlackSmithTutorialRequired(bool isSetTutorialStep = true);
		public bool IsTutorialCompleted();
		private void SetFortTutorialStep();
		public void CheckTutorialStatus();
		private bool CheckTutorialBuildComplete();
		[IteratorStateMachine]
		private IEnumerator Tutorial_1_6();
		public void TutorialBuildCompleted();
		private void TutorialDragonContactStart();
		public void LoadDragon(int dragonId);
		public void CheckBadges();
		public void ReturnToFortTop();
		private void OnFooterPressed(string tabName, Footer.MenuTab tabType);
		public void PrepareToClearFortView();
		public void EnableTouchEvent(bool isEnable);
		public override void OnPresentReceived();
		public FortMenuGroupType GetGroupeTypeByTabIndex(int tabIndex);
		public string GetGroupeTypeText(FortMenuGroupType type);
		public void SetFlashCameraSetting();
		public override void OnBeforeLeaving();
		private void OnDestroy();
		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType);
		[CompilerGenerated]
		private void _Start_b__63_0();
		[CompilerGenerated]
		private void _Start_b__63_3();
		[CompilerGenerated]
		private void _Start_b__63_1(GameObject obj);
		[CompilerGenerated]
		private void _Start_b__63_2();
		[CompilerGenerated]
		private void _Tutorial_1_6_b__73_0();
		[CompilerGenerated]
		private void _Tutorial_1_6_b__73_1();
		[CompilerGenerated]
		private void _Tutorial_1_6_b__73_2();
		[CompilerGenerated]
		private void _TutorialBuildCompleted_b__74_0();
		[CompilerGenerated]
		private void _TutorialBuildCompleted_b__74_1();
		[CompilerGenerated]
		private void _TutorialDragonContactStart_b__75_0();
		[CompilerGenerated]
		private void _TutorialDragonContactStart_b__75_1();
		[CompilerGenerated]
		private void _TutorialDragonContactStart_b__75_2();
		[CompilerGenerated]
		private void _OnPresentReceived_b__82_0();
	}
}
