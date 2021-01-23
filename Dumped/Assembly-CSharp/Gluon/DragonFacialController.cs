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
	public class DragonFacialController : MonoBehaviour
	{
		// Fields
		private const int maxFacialCount = 5;
		private GameObject[] eyeList;
		private GameObject[] mouthList;
		private Coroutine autoBlinkCoroutine;
		private Coroutine autoTalkCoroutine;
		public PartDefine lastMouth;
		public PartDefine lastEye;
		[Header]
		public StateDependentFacialData[] stateDependentFacialData;
		private Animator animator;
	
		// Nested types
		public enum ChangingPart
		{
			Mouth = 0,
			Eye = 1
		}
	
		public enum PartDefine
		{
			Normal = 0,
			Close = 1,
			Half = 2,
			Damaged = 3,
			Smiling = 4
		}
	
		[Serializable]
		public class StateDependentFacialData
		{
			// Fields
			[Header]
			[SerializeField]
			public string stateName;
			[Header]
			[SerializeField]
			public ChangingPart part;
			[Header]
			[SerializeField]
			public PartDefine type;
			[HideInInspector]
			public int prevType;
	
			// Constructors
			public StateDependentFacialData();
		}
	
		[CompilerGenerated]
		private sealed class _AutoBlinkCoroutine_d__21 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonFacialController __4__this;
			public Animator anim;
			public int startAnimationHash;
			public RuntimeAnimatorController startAnimation;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AutoBlinkCoroutine_d__21(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _AutoTalkCoroutine_d__24 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonFacialController __4__this;
			public Animator anim;
			public int startAnimationHash;
			public RuntimeAnimatorController startAnimation;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AutoTalkCoroutine_d__24(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DragonFacialController();
	
		// Methods
		private void Awake();
		private void Update();
		private void ProcessCommand(ChangingPart changingPart, int index, float rawValue);
		public void ChangeFacial(ChangingPart changingPart, int index);
		public void ResetToNormalFace(bool stopAllAutoAnimations = true);
		public void StartAutoBlink();
		private int GetCurrentAnimationNameHash(Animator anim);
		private bool CheckAnimationMatch(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation);
		public void StopAutoBlink();
		[IteratorStateMachine]
		private IEnumerator AutoBlinkCoroutine(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation);
		public void StartAutoTalk();
		public void StopAutoTalk();
		[IteratorStateMachine]
		private IEnumerator AutoTalkCoroutine(Animator anim, int startAnimationHash, RuntimeAnimatorController startAnimation);
		public void FBXImport_mMouth_01(float val);
		public void FBXImport_mMouth_02(float val);
		public void FBXImport_mMouth_03(float val);
		public void FBXImport_mMouth_04(float val);
		public void FBXImport_mMouth_05(float val);
		public void FBXImport_mEye_01(float val);
		public void FBXImport_mEye_02(float val);
		public void FBXImport_mEye_03(float val);
		public void FBXImport_mEye_04(float val);
		public void FBXImport_mEye_05(float val);
		public void FBXImport_DirectControl(string command);
	}
}
