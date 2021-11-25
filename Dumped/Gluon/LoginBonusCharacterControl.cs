using System;
using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class LoginBonusCharacterControl : MonoBehaviour
	{
		private class MouthRateControl
		{
			public int index16;

			public float rate;

			public MouthRateControl(int index16, float rate)
			{
			}
		}

		private enum EffectKind
		{
			Appear,
			Spirit,
			Scales,
			Nof
		}

		public const string animatorAndAnimationPath = "Animations/OutGame/LoginBonus";

		private static readonly int animTriggerToAppear;

		private static readonly int animTriggerToIntroduce;

		private static readonly int animTriggerToMove;

		private static readonly int animTriggerToIdle;

		private static readonly int animTriggerToOut;

		private static readonly int animTriggerTapSkip;

		[SerializeField]
		private RuntimeAnimatorController controller;

		private GameObject chara;

		private SkinnedMeshRenderer skinRenderer;

		private Animator animator;

		private Action callback;

		private SimpleCharacterModel model;

		private bool isAlreadyProcOnMoveToStandPositionEnd;

		private SimpleCharacterDirectFacialAnimation facialAnimation;

		private MouthRateControl[] mouthRateList;

		private int lastRateIndex;

		private bool lastRatePositive;

		private EffectObject[] effectGameObjectArray;

		private static readonly string[] effectFileName;

		private bool _isLoaded;

		public bool IsLoaded => default(bool);

		private void Awake()
		{
		}

		public IEnumerator Load(Action finishCallback)
		{
			return null;
		}

		private int GetMouthIndex16(int frameCount)
		{
			return default(int);
		}

		private GameObject LoadCharacter()
		{
			return null;
		}

		private IEnumerator PlayAllBindEffect()
		{
			return null;
		}

		public IEnumerator PlayPopEffect()
		{
			return null;
		}

		private EffectObject PlayBindEffect(GameObject bodyObject, EffectKind kind, string bindJointName)
		{
			return null;
		}

		private void DestroyAllEffect()
		{
		}

		private void DestroyEffect(EffectKind kind)
		{
		}

		public void ResetToIdle()
		{
		}

		public void MoveStart(Action callback)
		{
		}

		public void OnMoveStart()
		{
		}

		public void OnMoveToStandPositionEnd(bool isTapSkip)
		{
		}

		private void OnShowCharacter()
		{
		}

		private IEnumerator DelayAction(float sec, Action action)
		{
			return null;
		}

		public void IntroduceStart(Action callback)
		{
		}

		public void SetMouthTalkState(bool isOpen)
		{
		}

		public void OnIntroduceTrigger()
		{
		}

		public void ToOut()
		{
		}

		public void SetMouthTrigger(string triggerName)
		{
		}

		public void OnTapSkip()
		{
		}
	}
}
