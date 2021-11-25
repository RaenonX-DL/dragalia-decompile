using System;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharacterAnimatedAttachment : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class MotionState
		{
			public string matchingMotionName;

			public int state;

			public bool isLoop;

			public int motionTag
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		[SerializeField]
		private MotionState[] motionStateList;

		private Animator animator;

		private int currentState;

		private int paramId;

		private const string parameterNameTemplate = "AttachmentState_{0:D2}";

		private int paramLoopId;

		private const string parameterLoopNameTemplate = "IsLoop_{0:D2}";

		private int prevStateHash;

		public int baseLayer
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int layer
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Start()
		{
		}

		public void SetLayer(int layer)
		{
		}

		public void OverrideMotionStateList(MotionState[] motionStateList)
		{
		}

		private void OnLayerChanged()
		{
		}

		private void RefreshMotionStateList()
		{
		}

		private bool SwitchState(MotionState item)
		{
			return default(bool);
		}

		private bool SwitchState(int state, bool isLoop)
		{
			return default(bool);
		}

		private void OnAttached()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
