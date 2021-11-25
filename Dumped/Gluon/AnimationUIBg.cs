using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class AnimationUIBg : MonoBehaviour
	{
		[SerializeField]
		[Header("ã\u0082­ã\u0083£ã\u0083³ã\u0083\u0090ã\u0082¹ã\u0081\u0084ã\u0081£ã\u0081±ã\u0081\u0084ã\u0081«æ\u008b¡å¤§ã\u0081\u0099ã\u0082\u008b")]
		private bool expandToCanvasSize;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ\u0095°")]
		public float enterFrame;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u0088\u009dæ\u009c\u009fä½\u008dç½®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 enterOffset;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bæ\u0099\u0082æ\u008b¡å¤§ç\u008e\u0087")]
		public float enterSize;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡ã\u0082¢ã\u0083\u008bã\u0083¡æ\u009c\u0089ã\u0082\u008a")]
		public bool enterAlphaChange;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0æ\u0095°")]
		public float exitFrame;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡çµ\u0082äº\u0086ä½\u008dç½®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 exitOffset;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086æ\u0099\u0082ç\u00b8®å°\u008fç\u008e\u0087")]
		public float exitSize;

		public Canvas canvas;

		private RectTransform rectTransform;

		private CanvasGroup canvasGroup;

		private Vector2 initialSize;

		private Vector3 initialPosition;

		private Sequence runningSeq;

		public bool skipExitAnimation
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void ResetInitialPosAndSize()
		{
		}

		public void ResetAlpha()
		{
		}

		public void InitAlpha()
		{
		}

		public void StartEnterAnimation()
		{
		}

		public void StartExitAnimation()
		{
		}
	}
}
