/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestCharacterCtrl : MonoBehaviour
	{
		// Fields
		public const string animationStateBeforeIdle = "before idle";
		public const string animationStateIdle = "idle";
		private Animator _animator;
		[CompilerGenerated]
		private GameObject _character_k__BackingField;
		public WeaponType weaponType;
		public int motionType;
		public Vector3 idleCharaRotation;
		private Transform cachedTransform;
		public UnityAction playLandAnimationCallBack;
		public UnityAction runAnimationEndCallBack;
		public UnityAction<int> animationLoadCompleteCallBack;
		public bool isReloadModelComplete;
		public bool isStartLandAnimation;
		public float motionSpeed;
		public int myIndex;
		public SceneShaderSettings charaShaderSettings;
	
		// Properties
		public Animator animator { get; set; }
		public GameObject character { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum State
		{
			Idle = 0,
			Walk = 1,
			Run = 2,
			Jump = 3,
			BeforeIdle = 8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public QuestCharacterCtrl __4__this;
			public int charaId;
			public int weaponSkinId;
			public Action<GameObject> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _LoadCharacterModelAsync_b__0(GameObject obj);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public QuestCharacterCtrl __4__this;
			public bool shouldPlayIdleWhenFinished;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _StartRunAnimation_b__0();
			internal void _StartRunAnimation_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public QuestCharacterCtrl __4__this;
			public bool isQuestAnimation;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _PlayIdleAnimation_b__0(UnityEngine.Object controller);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public QuestCharacterCtrl __4__this;
			public bool isQuestAnimation;
			public AudioPlayback bgmPlayback;
			public int delayIndex;
			public Func<float> getIdleSyncDelayTimePred;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _PlayLandAnimation_b__0(UnityEngine.Object controller);
		}
	
		[CompilerGenerated]
		private sealed class _AnotherCharaLoadCompleteCoroutine_d__34 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestCharacterCtrl __4__this;
			public AudioPlayback bgmPlayback;
			public int delayIndex;
			public Func<float> getIdleSyncDelayTimePred;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AnotherCharaLoadCompleteCoroutine_d__34(int __1__state);
	
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
			public static Func<Renderer, bool> __9__35_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _LandAnimationWaitCoroutine_b__35_0(Renderer p);
		}
	
		[CompilerGenerated]
		private sealed class _LandAnimationWaitCoroutine_d__35 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestCharacterCtrl __4__this;
			public AudioPlayback bgmPlayback;
			public int delayIndex;
			public Animator animator;
			public Func<float> getIdleSyncDelayTimePred;
			private Renderer[] _childRenderers_5__2;
			private bool[] _rendererStates_5__3;
			private AttachEffect[] _effects_5__4;
			private int _hash_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LandAnimationWaitCoroutine_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlayLandSe_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delayTime;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlayLandSe_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestCharacterCtrl();
	
		// Methods
		private void Start();
		private void OnDestroy();
		public void LoadCharacterModelAsync(int charaId, int weaponSkinId, SimpleCharacterModel.ShadowCastMethod shadowCastMethod, float shadowCastMargin, float shadowScale, bool useLightProbe, Action<GameObject> onCompleteAction, int drawLayer);
		public void ReloadCharaWeaponModel(int weaponSkinId, int drawLayer);
		public void ReloadAttachEffect(bool includeInactive = false);
		public void ApplyLightProbe();
		public void StartTakeOffAnimation();
		public void StartRunAnimation(bool isToLeft, float startPosX, float endPosX, float duration, bool shouldPlayIdleWhenFinished);
		public void PlayIdleAnimation();
		public void PlayIdleAnimation(int charaId, bool isQuestAnimation);
		public void PlayLandAnimation(int charaId, AudioPlayback bgmPlayback, int delayIndex, bool isEmptyIndex, bool isQuestAnimation, Func<float> getIdleSyncDelayTimePred);
		[IteratorStateMachine]
		private IEnumerator AnotherCharaLoadCompleteCoroutine(AudioPlayback bgmPlayback, int delayIndex, Func<float> getIdleSyncDelayTimePred);
		[IteratorStateMachine]
		private IEnumerator LandAnimationWaitCoroutine(Animator animator, AudioPlayback bgmPlayback, int delayIndex, Func<float> getIdleSyncDelayTimePred);
		public void PlayCharaOutAnimation(bool showWarpEffect = true);
		[IteratorStateMachine]
		private IEnumerator PlayLandSe(float delayTime);
		public void RemoveShadow();
		[CompilerGenerated]
		private bool _LandAnimationWaitCoroutine_b__35_1();
	}
}
