/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaStateActionTrigger : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private int initActionId;
		[SerializeField]
		private int defaultOffActionId;
		private CharacterBase chara;
		private int currentTriggeredActionId;
		[SerializeField]
		private MotionState[] motionStateList;
		private Animator animator;
		private int prevStateHash;
		private Tweener runningTweener;
		private RenderPartsData renderPartsData;
		private List<RenderPartsData.PartsNo> initPartsNos;
	
		// Nested types
		[Serializable]
		public class MotionState
		{
			// Fields
			public List<string> matchingMotionNames;
			[CompilerGenerated]
			private List<int> _motionTags_k__BackingField;
			public int actionId;
			public int delayFrame;
	
			// Properties
			public List<int> motionTags { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public MotionState();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<RenderPartsData.PartsMeshData, RenderPartsData.PartsNo> __9__13_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal RenderPartsData.PartsNo _OnEnable_b__13_0(RenderPartsData.PartsMeshData x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public CharaStateActionTrigger __4__this;
			public int actionId;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _RunAction_b__0();
		}
	
		// Constructors
		public CharaStateActionTrigger();
	
		// Methods
		private void Start();
		private void RefreshMotionStateList();
		protected override void OnEnable();
		public override void FastUpdate();
		private bool SwitchState(MotionState state);
		private void RunAction(int actionId, float delay);
		private void RunAction(int actionId);
		public List<int> GetActionIdsForLoad();
	}
}
