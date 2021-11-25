using System;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class ContactHeartControl : MonoBehaviour
	{
		[Serializable]
		public class MoveSetting
		{
			public Transform heartParent;

			public TweenSequenceVisualizer heartMotion;

			public float initRotateZ;

			public float initScale;

			public float finishRotationZ;

			public float initDelay;

			public float delay;

			public float jumpPower;

			public float duration;

			public float angleDurationReduce;

			public const float finalOffsetY = 142.45f;

			public const float finalScale = 0.6f;

			private Sequence seq;

			private Vector3 parentInitPosition;

			public void DoMotion(Vector3 targetPosition, Action onShowEffect, Action onTouch)
			{
			}

			public void KillMotion()
			{
			}
		}

		[SerializeField]
		public Transform targetPosition;

		public MoveSetting[] moveSetting;

		public TweenSequenceVisualizer touchTargetEffect;

		[HideInInspector]
		public ContactReliabilitySlider reliabilitySlider;

		private bool motionKilled;

		public void PlayEffect(int carry, Action<int> onAllCompleted, int targetLevel, Action onTargetLevelReached)
		{
		}

		public void KillEffect()
		{
		}
	}
}
