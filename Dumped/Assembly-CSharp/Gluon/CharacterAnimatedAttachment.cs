/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterAnimatedAttachment : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private int _baseLayer_k__BackingField;
		[CompilerGenerated]
		private int _layer_k__BackingField;
		[SerializeField]
		private MotionState[] motionStateList;
		private Animator animator;
		private int currentState;
		private int paramId;
		private const string parameterNameTemplate = "AttachmentState_{0:D2}";
		private int paramLoopId;
		private const string parameterLoopNameTemplate = "IsLoop_{0:D2}";
		private int prevStateHash;
	
		// Properties
		public int baseLayer { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int layer { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		public class MotionState
		{
			// Fields
			public string matchingMotionName;
			[CompilerGenerated]
			private int _motionTag_k__BackingField;
			public int state;
			public bool isLoop;
	
			// Properties
			public int motionTag { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public MotionState();
		}
	
		// Constructors
		public CharacterAnimatedAttachment();
	
		// Methods
		private void Start();
		public void SetLayer(int layer);
		public void OverrideMotionStateList(MotionState[] motionStateList);
		private void OnLayerChanged();
		private void RefreshMotionStateList();
		private bool SwitchState(MotionState item);
		private bool SwitchState(int state, bool isLoop);
		private void OnAttached();
		public override void FastUpdate();
	}
}
