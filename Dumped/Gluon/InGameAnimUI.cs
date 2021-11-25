using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class InGameAnimUI : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class AnimData
		{
			[Tooltip("ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«")]
			public Vector3 scale;

			[Tooltip("ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089å\u0080¤")]
			public float fade;

			[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0099\u0082é\u0096\u0093")]
			public float animTime;

			[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081\u008cçµ\u0082ã\u0082\u008fã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089ã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
			public float afterWaitTime;

			[Tooltip("è£\u009cé\u0096\u0093ã\u0082¿ã\u0082¤ã\u0083\u0097")]
			public Ease ease;

			[HideInInspector]
			public Vector3 prevScale;

			[HideInInspector]
			public float prevFade;
		}

		[SerializeField]
		[Header("component")]
		protected RectTransform[] _animRt;

		[SerializeField]
		protected SpriteRenderer[] _animImage;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0083«ã\u0083¼ã\u0083\u0097å\u009b\u009eæ\u0095°")]
		protected int _loopCount;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡é\u0096\u008bå§\u008bå\u0089\u008dã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093\n  ã\u0083«ã\u0083¼ã\u0083\u0097ã\u0081«ã\u0081\u00afå\u0090«ã\u0081¾ã\u0082\u008cã\u0081¾ã\u0081\u009bã\u0082\u0093ã\u0080\u0082")]
		protected float _startWaitTime;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡æ\u0083\u0085å\u00a0±\n  â\u0080»è¦\u0081ç\u00b4\u00a0æ\u0095° 0 ã\u0081\u00afå\u0088\u009dæ\u009c\u009få\u0080¤ã\u0081\u00a8ã\u0081ªã\u0082\u008aã\u0081¾ã\u0081\u0099ã\u0080\u0082")]
		protected AnimData[] _animData;

		protected Sequence _seqAnim;

		protected Color[] _originColor;

		protected Action _onComplete;

		protected bool _isEnableScaleAnim;

		protected bool _isEnableFadeAnim;

		public void Awake()
		{
		}

		public void Initialize(Action onComplete)
		{
		}

		public void OnDestroy()
		{
		}

		public bool Play(bool isForce = false)
		{
			return default(bool);
		}

		public void Stop()
		{
		}

		public bool IsPlaying()
		{
			return default(bool);
		}

		private Sequence CreateAnim()
		{
			return null;
		}

		private void ApplyImageData(AnimData data)
		{
		}

		private void OnUpdateScale(Vector3 scale)
		{
		}

		private void OnUpdateFade(float fade)
		{
		}
	}
}
