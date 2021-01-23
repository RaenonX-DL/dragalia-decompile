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
	public class MyPageMoveMap : MonoBehaviour
	{
		// Fields
		public static int maxWindmills;
		public GameObject bgNode;
		public GameObject playerNode;
		public GameObject groundBase;
		public GameObject walkBase;
		public GameObject groundNode;
		public GameObject buildingTavernNode;
		public GameObject buildingInnNode;
		public GameObject buildingShopNode;
		public GameObject runningBuildingNode1;
		public GameObject runningBuildingNode2;
		public GameObject runningBuildingNode3;
		public GameObject[] windmillNodes;
		public GameObject charaNodesParent;
		public GameObject talkingPairCharaNode1;
		public GameObject talkingPairCharaNode2;
		public GameObject byeCharaNode;
		public GameObject walkingCharaNode;
		public GameObject runMapCharaNode1;
		public GameObject runMapCharaNode2;
		public GameObject runMapCharaNode3;
		public GameObject runMapCharaNode4;
		public GameObject windmillWatchPoint;
		public GameObject windmillWatchPoint2;
		public GameObject windmillWatchPoint3;
		public GameObject windmillWatchPoint4;
		public GameObject birdEffectWatchPoint;
		public GameObject buildingWatchPoint;
		public GameObject runningBuildingWatchPoint1;
		public GameObject runningBuildingWatchPoint2;
		public GameObject runningBuildingWatchPoint3;
		public GameObject birdEffectNode;
		public MyPageScene scene;
		public MyPageTransitionController transition;
		public GameObject playerObject;
		public GameObject nhaamObject;
		public GameObject ExtraCharaObject;
		public GameObject[] characterObjects;
		public string[] characterNames;
		public int[] characterIds;
		public List<MyPageMapCharacters.CharacterData> characterDataList;
		[HideInInspector]
		public MyPageMoveMapWindmill[] windmills;
		[HideInInspector]
		public EffectObject birdEffectObject;
		[HideInInspector]
		public MyPageMoveMapBgContent bgContent;
		[HideInInspector]
		public MyPageMoveMapGround currentGround;
		[HideInInspector]
		public MyPageMoveMapGround nextGround;
		[HideInInspector]
		public List<MyPageMoveMapBuilding> currentBuilding;
		[HideInInspector]
		public List<MyPageMoveMapBuilding> nextBuilding;
		[HideInInspector]
		public List<MyPageMoveMapWindmill> nextWindmills;
		[CompilerGenerated]
		private bool _isGroundSceneLoadCompleted_k__BackingField;
		[CompilerGenerated]
		private int _buildingSceneLoadCompletedCount_k__BackingField;
		[CompilerGenerated]
		private int _windmillSceneLoadCompletedCount_k__BackingField;
		[CompilerGenerated]
		private bool _hasBuilding_k__BackingField;
		[CompilerGenerated]
		private bool _hasWindmill_k__BackingField;
		[CompilerGenerated]
		private bool _existsBirdEffect_k__BackingField;
		[CompilerGenerated]
		private bool _existsWindmill_k__BackingField;
		[CompilerGenerated]
		private int _numOfWindmills_k__BackingField;
		private const int loadWindmillWaitCount = 10;
		private string lastGroundSceneName;
		private List<string> lastBuildingSceneNames;
		private List<string> loadingBuildingSceneNames;
		private string lastWindmillSceneName;
		private int loadedCharacterCount;
		private int targetCharacterCount;
	
		// Properties
		public bool isGroundSceneLoadCompleted { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int buildingSceneLoadCompletedCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int windmillSceneLoadCompletedCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool hasBuilding { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool hasWindmill { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool existsBirdEffect { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool existsWindmill { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int numOfWindmills { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass89_0
		{
			// Fields
			public MyPageMoveMap __4__this;
			public Action<MyPageMoveMapBgContent> onCompleted;
	
			// Constructors
			public __c__DisplayClass89_0();
	
			// Methods
			internal void _LoadBG_b__0(UnityEngine.Object asset);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass91_0
		{
			// Fields
			public MyPageMoveMap __4__this;
			public Action<GameObject> onCompletedAction;
	
			// Constructors
			public __c__DisplayClass91_0();
	
			// Methods
			internal void _LoadPlayer_b__0(GameObject obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass93_0
		{
			// Fields
			public MyPageMoveMap __4__this;
			public Action<GameObject> onCompletedAction;
	
			// Constructors
			public __c__DisplayClass93_0();
	
			// Methods
			internal void _LoadNhaam_b__0(GameObject obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass95_0
		{
			// Fields
			public EffectObject effect;
	
			// Constructors
			public __c__DisplayClass95_0();
	
			// Methods
			internal bool _AddNhaamEffectCoroutine_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__95_0;
			public static Func<bool> __9__123_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _AddNhaamEffectCoroutine_b__95_0();
			internal bool _LoadBirdEffectCoroutine_b__123_0();
		}
	
		[CompilerGenerated]
		private sealed class _AddNhaamEffectCoroutine_d__95 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageMoveMap __4__this;
			private __c__DisplayClass95_0 __8__1;
			private string _modelName_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AddNhaamEffectCoroutine_d__95(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass96_0
		{
			// Fields
			public MyPageMoveMap __4__this;
			public Action<GameObject> onCompletedAction;
			public Action<UnityEngine.Object> onLoaded;
	
			// Constructors
			public __c__DisplayClass96_0();
	
			// Methods
			internal void _LoadExtraChara_b__0(UnityEngine.Object asset);
			internal void _LoadExtraChara_b__1(UnityEngine.Object asset);
		}
	
		[CompilerGenerated]
		private sealed class _UnLoadLastGroundSceneWaitCoroutine_d__100 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageMoveMap __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnLoadLastGroundSceneWaitCoroutine_d__100(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass101_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass101_0();
	
			// Methods
			internal void _LoadGroundCoroutine_b__0();
			internal bool _LoadGroundCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadGroundCoroutine_d__101 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageMoveMap __4__this;
			public string filename;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadGroundCoroutine_d__101(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UnLoadLastBuildingSceneWaitCoroutine_d__104 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageMoveMap __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnLoadLastBuildingSceneWaitCoroutine_d__104(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass105_0();
	
			// Methods
			internal void _LoadBuildingCoroutine_b__0();
			internal bool _LoadBuildingCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBuildingCoroutine_d__105 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isAdditive;
			public MyPageMoveMap __4__this;
			public string filename;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBuildingCoroutine_d__105(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass107_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass107_0();
	
			// Methods
			internal void _LoadWindmillCoroutine_b__0();
			internal bool _LoadWindmillCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadWindmillCoroutine_d__107 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string filename;
			public MyPageMoveMap __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadWindmillCoroutine_d__107(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CreateWindmillCoroutine_d__109 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageMoveMap __4__this;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CreateWindmillCoroutine_d__109(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass113_0
		{
			// Fields
			public MyPageMoveMap __4__this;
			public int index;
			public GameObject[] parentNodes;
			public MyPageTransitionController.DayTimeType dayTimeType;
			public bool isRunning;
	
			// Constructors
			public __c__DisplayClass113_0();
	
			// Methods
			internal void _SetupCharater_b__0(GameObject character);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass114_0
		{
			// Fields
			public MyPageMoveMap __4__this;
			public GameObject character;
			public int index;
			public MyPageTransitionController.DayTimeType dayTimeType;
			public bool isRunning;
	
			// Constructors
			public __c__DisplayClass114_0();
	
			// Methods
			internal void _SetupCharaterCoroutine_b__0(UnityEngine.Object controller);
			internal void _SetupCharaterCoroutine_b__1(UnityEngine.Object controller);
		}
	
		[CompilerGenerated]
		private sealed class _SetupCharaterCoroutine_d__114 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageMoveMap __4__this;
			public GameObject character;
			public int index;
			public MyPageTransitionController.DayTimeType dayTimeType;
			public bool isRunning;
			public GameObject[] parentNodes;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupCharaterCoroutine_d__114(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetCharacterDefaultFacialAnimation_d__116 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageMoveMap __4__this;
			public GameObject character;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetCharacterDefaultFacialAnimation_d__116(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBirdEffectCoroutine_d__123 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageMoveMap __4__this;
			public MyPageTransitionController.DayTimeType dayTimeType;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBirdEffectCoroutine_d__123(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MyPageMoveMap();
		static MyPageMoveMap();
	
		// Methods
		public void DestroyMyResources();
		public void LoadBG(string filename, Action<MyPageMoveMapBgContent> onCompleted);
		private void LoadBgOnCompleted(UnityEngine.Object asset, Action<MyPageMoveMapBgContent> onCompleted);
		public void LoadPlayer(int charaId, string filename, Action<GameObject> onCompletedAction);
		private void LoadPlayerOnCompleted(GameObject obj, Action<GameObject> onCompletedAction);
		public void LoadNhaam(Action<GameObject> onCompletedAction);
		private void LoadNhaamOnCompleted(GameObject obj, Action<GameObject> onCompletedAction);
		[IteratorStateMachine]
		private IEnumerator AddNhaamEffectCoroutine();
		public void LoadExtraChara(Action<GameObject> onCompletedAction);
		private void LoadExtraCharaOnCompleted(GameObject obj, Action<GameObject> onCompletedAction);
		public void LoadGroundScene(string filename);
		public AsyncOperation UnLoadLastGroundScene();
		[IteratorStateMachine]
		public IEnumerator UnLoadLastGroundSceneWaitCoroutine();
		[IteratorStateMachine]
		private IEnumerator LoadGroundCoroutine(string filename);
		public void LoadBuildingScene(string filename, bool isAdditive);
		public void UnLoadLastBuildingScene();
		[IteratorStateMachine]
		public IEnumerator UnLoadLastBuildingSceneWaitCoroutine();
		[IteratorStateMachine]
		private IEnumerator LoadBuildingCoroutine(string filename, bool isAdditive);
		public void LoadWindmillScene(string filename);
		[IteratorStateMachine]
		private IEnumerator LoadWindmillCoroutine(string filename);
		public void CreateWindmill();
		[IteratorStateMachine]
		private IEnumerator CreateWindmillCoroutine();
		public void UnLoadWindmillScene();
		public void LoadCharacters(MyPageTransitionController.MoveMapType currentMapType, MyPageTransitionController.DayTimeType dayTimeType, MyPageMapCharacters characters, bool isRunning);
		public bool IsAllCharacterLoaded();
		private void SetupCharater(int index, GameObject[] parentNodes, MyPageTransitionController.DayTimeType dayTimeType, bool isRunning);
		[IteratorStateMachine]
		private IEnumerator SetupCharaterCoroutine(int index, GameObject character, GameObject[] parentNodes, MyPageTransitionController.DayTimeType dayTimeType, bool isRunning);
		private void SetupCharacterAnimationCompleted(GameObject character, UnityEngine.Object controller, int index, MyPageTransitionController.DayTimeType dayTimeType, bool isRunning);
		[IteratorStateMachine]
		private IEnumerator SetCharacterDefaultFacialAnimation(GameObject character);
		public void SyncCharacterMotionWithBgm(int animationCount);
		public static MyPageMapAnimations.Motion GetMotion(MyPageMoveMapCharaPosSettings moveMapCharaPosSettings, int index, int personMotionType, bool isRunning);
		public MyPageBalloon.TextType GetWindowType(int index, bool isRunning);
		public void SetCharacterAnimationEnable(bool arg);
		public void ResetBirdEffect();
		public void LoadBirdEffect(MyPageTransitionController.DayTimeType dayTimeType);
		[IteratorStateMachine]
		private IEnumerator LoadBirdEffectCoroutine(MyPageTransitionController.DayTimeType dayTimeType);
		public void SetCharacterBlinkEnable(bool enabled);
	}
}
