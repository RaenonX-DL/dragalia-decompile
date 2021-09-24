/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DynamicAnimationClipOverrider : MonoBehaviour
	{
		// Fields
		public OverrideDataSet[] dataSetArray;
		[Header]
		[SerializeField]
		private string revertDummyStateName;
		[Header]
		[SerializeField]
		private float revertMotionBlendSec;
		private Animator animator;
		private int reservedState;
		private AnimatorOverrideController newAnimatorOverrideController;
		private List<KeyValuePair<AnimationClip, AnimationClip>> originalOverriders;
		private List<KeyValuePair<AnimationClip, AnimationClip>> overriders;
		private AnimatorStateInfo[] stateCache;
		private string revertCheckStateName;
		private string trrigerStateName;
	
		// Nested types
		[Serializable]
		public class OverrideData
		{
			// Fields
			[Header]
			[SerializeField]
			public string stateName;
			[Header]
			[SerializeField]
			public AnimationClip overrideClip;
			[Header]
			[SerializeField]
			public string triggerStateName;
			[Header]
			[SerializeField]
			public bool revertAfterPlay;
			[Header]
			[SerializeField]
			public float triggerNormalizedTime;
	
			// Constructors
			public OverrideData();
		}
	
		[Serializable]
		public class OverrideDataSet
		{
			// Fields
			public OverrideData[] data;
	
			// Constructors
			public OverrideDataSet();
		}
	
		// Constructors
		public DynamicAnimationClipOverrider();
	
		// Methods
		private void Start();
		private void OnDestroy();
		private void Update();
		public void SetState(int state);
		private bool CanChangeState();
		private void Override(int index);
		private void Revert();
	}
}
