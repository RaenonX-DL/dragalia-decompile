using System;
using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class AnimationUIAutoPublisher : MonoBehaviour
	{
		[SerializeField]
		[Header("Sets")]
		public AnimationUIAutoSet[] uiSets;

		public const float animationFPS = 60f;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093ï¼\u0088ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ï¼\u0089")]
		public int enterDuration;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡")]
		public Vector3 enterRotation;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u009b\u009eè»¢é\u0081\u0085å»¶ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
		public int enterRotationDelay;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u0088\u009dæ\u009c\u009fä½\u008dç½®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 enterOffset;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0090ã\u0082¦ã\u0083³ã\u0083\u0089ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 enterBoundOffset;

		[SerializeField]
		[Header("é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0090ã\u0082¦ã\u0083³ã\u0083\u0089ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
		public float enterBoundScale;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093ï¼\u0088ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ï¼\u0089")]
		public int exitDuration;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡æ\u009c\u0080çµ\u0082ç\u00b8®å°\u008fç\u008e\u0087")]
		public float exitScale;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ç§»å\u008b\u0095é\u0080\u009fåº¦")]
		public float exitSpeed;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0096¹å\u0090\u0091")]
		public float exitDirection;

		[SerializeField]
		[Header("çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡çµ\u0082äº\u0086æ\u0099\u0082ä½\u008dç½®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 exitOffset;

		[SerializeField]
		[Header("ã\u0083\u0080ã\u0082¤ã\u0082¢ã\u0083­ã\u0082°çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡å\u009b\u009eè»¢")]
		public Vector3 exitRotation;

		[SerializeField]
		[Header("è\u0087ªå\u008b\u0095é\u0096\u008bå§\u008b")]
		public bool bAutoStartEnterAnimation;

		[SerializeField]
		[Header("è\u0087ªå\u008b\u0095Playç\u008a¶æ\u0085\u008bæ¶\u0088ã\u0081\u0099")]
		public bool bAutoClearAnimation;

		[SerializeField]
		[Header("Animation Pattern")]
		public AnimationUICanvas.AnimationPattern pattern;

		[SerializeField]
		[Header("Animation Enable Type")]
		public AnimationUIBase.AnimationEnableType enableType;

		private void Awake()
		{
		}

		public void PreheatAll()
		{
		}

		public void RePublishAll()
		{
		}

		private void Start()
		{
		}

		public void PlayEnterAnimation(Action onFinished, int setIndex = -1)
		{
		}

		private IEnumerator EnterAnimationCoroutine(Action onFinished, int setIndex = -1)
		{
			return null;
		}

		public void PlayExitAnimation(Action onFinished, int setIndex = -1)
		{
		}

		private void CheckAndClearPlayState(int setIndex = -1)
		{
		}

		public void ForceClearPlayedStatus(int setIndex = -1)
		{
		}

		public void CompleteRunningAnimation(int setIndex = -1)
		{
		}

		private IEnumerator ExitAnimationCoroutine(Action onFinished, int setIndex = -1)
		{
			return null;
		}
	}
}
