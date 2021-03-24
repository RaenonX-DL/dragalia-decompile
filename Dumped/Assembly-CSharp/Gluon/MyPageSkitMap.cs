/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageSkitMap : MonoBehaviour
	{
		// Fields
		public MyPageScene scene;
		public GameObject bgNode;
		public GameObject effectNode;
		public MyPageTransitionController transition;
		public MyPageSkitMapBgContent currentBgContent;
		public MyPageSkitMapBgContent nextBgContent;
		public MyPageSkitMapBgSpeicalEffectHelper specialEffectHelper;
		public GameObject[] characterObjects;
		public GameObject[] touchCubes;
		public string[] characterNames;
		public int[] characterIds;
		public List<GameObject> items;
		public GameObject dragonObject;
		public GameObject enemyObject;
		public List<EffectObject> effectList;
		public List<MyPageMapCharacters.CharacterData> characterDataList;
		public bool isSceneLoadCompleted;
		private GameObject[] specialObjects;
		private string lastMapSceneName;
		private int targetCharacterCount;
		private int loadedCharacterCount;
		private string treasureNpcDragonId;
		private const string spesialObjectNameNewYear = "MO00006";
		private const string spesialObjectNameHunter = "MO00011";
		private const string spesialObjectGoldSnapper = "MO00013";
		private const string spesialObjectRedSnapper = "MO00014";
		private const float goldSnapperDisplayProbability = 0.1f;
		private List<SynchronizeAnimatorSet> synchronizeAnimatorSet;
		public GameObject extraCharacterObject;
		public GameObject extraCharacterTouchCube;
		private int loopCount;
		private const int synchronizeFalame = 10;
	
		// Nested types
		private class SynchronizeAnimatorSet
		{
			// Fields
			private Animator parentCharacterAnimator;
			private Animator specialObjectAnimator;
	
			// Constructors
			public SynchronizeAnimatorSet(Animator parentCharacterAnimator, Animator specialObjectAnimator);
	
			// Methods
			public void Synchronize();
		}
	
		[CompilerGenerated]
		private sealed class _UnLoadLastLigthMapSceneWaitCoroutine_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSkitMap __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnLoadLastLigthMapSceneWaitCoroutine_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _LoadBgSceneCoroutine_b__0();
			internal bool _LoadBgSceneCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBgSceneCoroutine_d__38 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSkitMap __4__this;
			public string filename;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBgSceneCoroutine_d__38(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public MyPageSkitMap __4__this;
			public int charaIndex;
			public int positionIndex;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _SetupCharacterImpl_b__0(GameObject character);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public MyPageSkitMap __4__this;
			public int charaIndex;
			public int positionIndex;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _SetupDragonImpl_b__0(UnityEngine.Object asset);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0
		{
			// Fields
			public MyPageSkitMap __4__this;
			public Action<UnityEngine.Object> onLoaded;
	
			// Constructors
			public __c__DisplayClass45_0();
	
			// Methods
			internal void _SetupExtraCharacter_b__0(UnityEngine.Object asset);
			internal void _SetupExtraCharacter_b__1(UnityEngine.Object asset);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public MyPageSkitMap __4__this;
			public int charaIndex;
			public GameObject character;
			public MyPageMapAnimations.Motion motionId;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _SetupCharacterCoroutine_b__0(UnityEngine.Object obj);
			internal void _SetupCharacterCoroutine_b__1(UnityEngine.Object controller);
			internal void _SetupCharacterCoroutine_b__2(UnityEngine.Object controller);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_1
		{
			// Fields
			public Transform jWeaponR;
			public __c__DisplayClass46_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass46_1();
	
			// Methods
			internal void _SetupCharacterCoroutine_b__3(UnityEngine.Object beerPrefab);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_2
		{
			// Fields
			public Transform attachPoint;
			public __c__DisplayClass46_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass46_2();
	
			// Methods
			internal void _SetupCharacterCoroutine_b__4(UnityEngine.Object itemPrefab);
		}
	
		[CompilerGenerated]
		private sealed class _SetupCharacterCoroutine_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSkitMap __4__this;
			public int charaIndex;
			public GameObject character;
			public int positionIndex;
			private __c__DisplayClass46_0 __8__1;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupCharacterCoroutine_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public MyPageSkitMap __4__this;
			public int charaIndex;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _SetupDragonCoroutine_b__0(UnityEngine.Object obj);
		}
	
		[CompilerGenerated]
		private sealed class _SetupDragonCoroutine_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSkitMap __4__this;
			public int charaIndex;
			public GameObject character;
			public int positionIndex;
			public string animationName;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupDragonCoroutine_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetupExtraCharaCoroutine_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSkitMap __4__this;
			public GameObject character;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupExtraCharaCoroutine_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_0
		{
			// Fields
			public MyPageSkitMap __4__this;
			public int npcIndex;
			public Action<UnityEngine.Object> __9__1;
	
			// Constructors
			public __c__DisplayClass62_0();
	
			// Methods
			internal void _LoadTreasureNpcImpl_b__0(UnityEngine.Object obj);
			internal void _LoadTreasureNpcImpl_b__1(UnityEngine.Object cubeObj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_1
		{
			// Fields
			public GameObject character;
			public __c__DisplayClass62_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass62_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass62_2
		{
			// Fields
			public Animator animator;
			public __c__DisplayClass62_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass62_2();
	
			// Methods
			internal void _LoadTreasureNpcImpl_b__2(UnityEngine.Object controller);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__67_0;
			public static Func<bool> __9__69_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _LoadSpecialEffectCoroutine_b__67_0();
			internal bool _SetupNhaamCoroutine_b__69_2();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSpecialEffectCoroutine_d__67 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSkitMap __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSpecialEffectCoroutine_d__67(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public MyPageSkitMap __4__this;
			public int charaIndex;
			public int positionIndex;
			public string modelName;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal void _SetUpNhaamImpl_b__0(GameObject character);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0
		{
			// Fields
			public MyPageSkitMap __4__this;
			public int charaIndex;
			public Animator nhaamAnimator;
			public GameObject character;
	
			// Constructors
			public __c__DisplayClass69_0();
	
			// Methods
			internal void _SetupNhaamCoroutine_b__0(UnityEngine.Object obj);
			internal void _SetupNhaamCoroutine_b__1(UnityEngine.Object controller);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_1
		{
			// Fields
			public EffectObject effect;
	
			// Constructors
			public __c__DisplayClass69_1();
	
			// Methods
			internal bool _SetupNhaamCoroutine_b__3();
		}
	
		[CompilerGenerated]
		private sealed class _SetupNhaamCoroutine_d__69 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MyPageSkitMap __4__this;
			public int charaIndex;
			public GameObject character;
			public int positionIndex;
			private __c__DisplayClass69_0 __8__1;
			public string modelName;
			private __c__DisplayClass69_1 __8__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupNhaamCoroutine_d__69(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MyPageSkitMap();
	
		// Methods
		private void Update();
		public void DestroyMyResources();
		public void LoadBgScene(string filename);
		public void UnLoadLastLigthMapScene();
		[IteratorStateMachine]
		public IEnumerator UnLoadLastLigthMapSceneWaitCoroutine();
		[IteratorStateMachine]
		private IEnumerator LoadBgSceneCoroutine(string filename);
		private void LoadCharaPosSetting();
		public void LoadCharacters(MyPageMapCharacters characters);
		public bool IsAllCharacterLoaded();
		private void SetupCharacter(int charaIndex, int positionIndex);
		private void SetupCharacterImpl(int charaIndex, int positionIndex);
		private void SetupDragonImpl(int charaIndex, int positionIndex);
		private void SetupExtraCharacter();
		[IteratorStateMachine]
		private IEnumerator SetupCharacterCoroutine(int charaIndex, int positionIndex, GameObject character);
		[IteratorStateMachine]
		private IEnumerator SetupDragonCoroutine(int charaIndex, int positionIndex, GameObject character, string animationName);
		[IteratorStateMachine]
		private IEnumerator SetupExtraCharaCoroutine(GameObject character);
		private void SetupCharacterAnimationCompleted(UnityEngine.Object controller, GameObject character, int index, MyPageMapAnimations.Motion motionId);
		private void SetupCharacterItemCompleted(UnityEngine.Object itemPrefab, Transform jWeaponR, int charaIndex);
		private void TouchCubeLoaded(UnityEngine.Object obj, int charaIndex);
		private void ExtraCharaTouchCubeLoaded(UnityEngine.Object obj, int charaIndex);
		public void SetCanvasTouTouchCubes();
		private void ResetTouchCubes();
		private MyPageMapAnimations.Motion GetMotion(int index, int personMotionType);
		private MyPageMapAnimations.Motion GetMotionImpl(int index);
		private float GetMotionDelay(int index);
		private Vector3 GetCharacterPos(int index);
		private Vector3 GetCharacterRotation(int index);
		public MyPageBalloon.TextType GetWindowType(int index);
		private void LoadTreasureNpc();
		private void LoadTreasureNpcImpl();
		public void SetCharacterAnimationEnable(bool arg);
		public void SetCharacterBlinkEnable(bool enabled);
		public Color GetAmbientColor();
		public void LoadSpecialEffect();
		[IteratorStateMachine]
		private IEnumerator LoadSpecialEffectCoroutine();
		private void SetUpNhaamImpl(int charaIndex, int positionIndex);
		[IteratorStateMachine]
		private IEnumerator SetupNhaamCoroutine(int charaIndex, int positionIndex, GameObject character, string modelName);
		[CompilerGenerated]
		private void _SetupExtraCharaCoroutine_b__48_0(UnityEngine.Object obj);
		[CompilerGenerated]
		private void _ExtraCharaTouchCubeLoaded_b__52_0();
	}
}
