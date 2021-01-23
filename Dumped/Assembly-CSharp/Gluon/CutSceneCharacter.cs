/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CutSceneCharacter : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		public string characterPrefabName;
		[SerializeField]
		public string animationControllerName;
		[SerializeField]
		public string weaponPrefabName;
		[SerializeField]
		public string eyeAnimationControllerName;
		[SerializeField]
		public string mouthAnimationControllerName;
		private GameObject character;
		private SkinnedMeshRenderer meshRenderer;
		private GameObject weapon;
		private GameObject eyeObject;
		private GameObject mouthObject;
		private Animator eyeAnimator;
		private Animator mouthAnimator;
		private AnimationData eye;
		private AnimationData mouth;
		private const float blinkIntervalMin = 1.5f;
		private const float blinkIntervalMax = 5f;
		private const float blinkLoopInterval = 0.41666666f;
		private CutSceneInitializer initializer;
		private static readonly int maxCut;
		private Dictionary<int, StateName> stateNameDictionary;
		private static readonly string baseLayerName;
	
		// Nested types
		private class AnimationData
		{
			// Fields
			public bool enable;
			public bool playing;
			public float interval;
			public float time;
			public int count;
			public string stateName;
			public int materialIdx;
			public float intervalMin;
			public float intervalMax;
			public float loopInterval;
	
			// Constructors
			public AnimationData();
		}
	
		private class StateName
		{
			// Fields
			public string name;
			public string fullName;
	
			// Constructors
			public StateName();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CutSceneCharacter __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CutSceneCharacter();
		static CutSceneCharacter();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		private GameObject CreateFaceAnimationObject(string animationControllerName, out Animator animator, GameObject top);
		private void UpdateAnimation(AnimationData animation, float[] offsetX);
		private void InitAutoAnimation(AnimationData data, string name);
		public void ClearLoop();
		private void UpdateFaceAnimation(GameObject obj, Animator animator, AnimationData data);
		private void LateUpdate();
		public void SetVisible(int visible);
	}
}
