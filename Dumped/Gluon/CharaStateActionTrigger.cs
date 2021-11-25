using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class CharaStateActionTrigger : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class MotionState
		{
			public List<string> matchingMotionNames;

			public int actionId;

			public int delayFrame;

			public List<int> motionTags
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}
		}

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

		private void Start()
		{
		}

		private void RefreshMotionStateList()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void FastUpdate()
		{
		}

		private bool SwitchState(MotionState state)
		{
			return default(bool);
		}

		private void RunAction(int actionId, float delay)
		{
		}

		private void RunAction(int actionId)
		{
		}

		public List<int> GetActionIdsForLoad()
		{
			return null;
		}
	}
}
