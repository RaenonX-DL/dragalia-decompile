using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class DynamicAnimationClipOverrider : MonoBehaviour
	{
		[Serializable]
		public class OverrideData
		{
			[SerializeField]
			[Header("å¤\u0089æ\u009b\u00b4å\u00af¾è±¡ã\u0081®ã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0083\u0088å\u0090\u008d")]
			public string stateName;

			[SerializeField]
			[Header("å¤\u0089æ\u009b\u00b4å¾\u008cã\u0081®AnimationClip")]
			public AnimationClip overrideClip;

			[SerializeField]
			[Header("å¤\u0089æ\u009b\u00b4ã\u0082\u0092å®\u009fè¡\u008cã\u0081\u0099ã\u0082\u008bã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0083\u0088å\u0090\u008d")]
			public string triggerStateName;

			[SerializeField]
			[Header("å\u0086\u008dç\u0094\u009få¾\u008cã\u0081«å¤\u0089æ\u009b\u00b4ã\u0082\u0092æ\u0088»ã\u0081\u0099ã\u0081\u008b")]
			public bool revertAfterPlay;

			[SerializeField]
			[Header("å¤\u0089æ\u009b\u00b4å®\u009fè¡\u008cã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0083\u0088ã\u0081\u008cã\u0081©ã\u0082\u008cã\u0081\u00a0ã\u0081\u0091ç¶\u009aã\u0081\u0084ã\u0081\u009fã\u0082\u0089å¤\u0089æ\u009b\u00b4ã\u0081\u0099ã\u0082\u008bã\u0081\u008bï¼\u00880ï½\u009e1.0ï¼\u0089")]
			public float triggerNormalizedTime;
		}

		[Serializable]
		public class OverrideDataSet
		{
			public OverrideData[] data;
		}

		public OverrideDataSet[] dataSetArray;

		[SerializeField]
		[Header("å¤\u0089æ\u009b\u00b4ã\u0082\u0092æ\u0088»ã\u0081\u0099ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0083\u0096ã\u0083¬ã\u0083³ã\u0083\u0089ç\u0094\u00a8ã\u0081«ã\u0083\u0080ã\u0083\u009fã\u0083¼ã\u0081§ä\u00b8\u0080ç\u009e¬æ\u008c\u009fã\u0082\u0080ã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0083\u0088å\u0090\u008dï¼\u0088ã\u0083\u0096ã\u0083¬ã\u0083³ã\u0083\u0089ã\u0081\u008cå¿\u0085è¦\u0081ã\u0081ªã\u0081\u0091ã\u0082\u008cã\u0081°ç©ºæ¬\u0084ï¼\u0089")]
		private string revertDummyStateName;

		[SerializeField]
		[Header("å¤\u0089æ\u009b\u00b4ã\u0082\u0092æ\u0088»ã\u0081\u0099ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0083\u0096ã\u0083¬ã\u0083³ã\u0083\u0089ç§\u0092æ\u0095°ï¼\u0088ã\u0083\u0096ã\u0083¬ã\u0083³ã\u0083\u0089ã\u0081\u008cå¿\u0085è¦\u0081ã\u0081ªã\u0081\u0091ã\u0082\u008cã\u0081°ç©ºæ¬\u0084ï¼\u0089")]
		private float revertMotionBlendSec;

		private Animator animator;

		private int reservedState;

		private AnimatorOverrideController newAnimatorOverrideController;

		private List<KeyValuePair<AnimationClip, AnimationClip>> originalOverriders;

		private List<KeyValuePair<AnimationClip, AnimationClip>> overriders;

		private AnimatorStateInfo[] stateCache;

		private string revertCheckStateName;

		private string trrigerStateName;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void SetState(int state)
		{
		}

		private bool CanChangeState()
		{
			return default(bool);
		}

		private void Override(int index)
		{
		}

		private void Revert()
		{
		}
	}
}
