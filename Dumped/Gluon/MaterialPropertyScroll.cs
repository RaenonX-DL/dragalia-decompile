using System;
using UnityEngine;

namespace Gluon
{
	public class MaterialPropertyScroll : MaterialControlComponent
	{
		[Serializable]
		public class ScrollData
		{
			[SerializeField]
			[Tooltip("è\u00a8­å®\u009aã\u0081\u0099ã\u0082\u008bã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0083\u0097ã\u0083­ã\u0083\u0091ã\u0083\u0086ã\u0082£")]
			private string _texturePropertyName;

			private int _texturePropertyID;

			[SerializeField]
			[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082«ã\u0083¼ã\u0083\u0096ã\u0082\u0092ä½¿ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008b")]
			private bool _animationCurveMode;

			[SerializeField]
			[Tooltip("ï¼\u0091å\u009b\u009eã\u0081§ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0081\u0099ã\u0082\u008bUVå\u0080¤")]
			private float _Speed;

			[SerializeField]
			[Tooltip("ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0081®æ\u009b\u00b4æ\u0096°ã\u0082¿ã\u0082¤ã\u0083\u009fã\u0083³ã\u0082°ã\u0081®ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
			private int _IntervalFrame;

			[SerializeField]
			[Tooltip("ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0081®æ\u009b\u00b4æ\u0096°ã\u0082¿ã\u0082¤ã\u0083\u009fã\u0083³ã\u0082°ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088æ\u009c\u0080å¤§ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
			private int _randomOffsetMaxFrame;

			[SerializeField]
			[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082«ã\u0083¼ã\u0083\u0096ã\u0081®ã\u0083\u0088ã\u0083¼ã\u0082¿ã\u0083«ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0")]
			private float _animationTotalTime;

			[SerializeField]
			[Tooltip("ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081®ã\u0082¹ã\u0082¿ã\u0083¼ã\u0083\u0088ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088æ\u0099\u0082é\u0096\u0093")]
			private float _animationStartOffsetTime;

			[SerializeField]
			[Tooltip("ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082«ã\u0083¼ã\u0083\u0096")]
			private AnimationCurve _animationCurve;

			private int _oldFrame;

			private float _intervalTime;

			private int _randomOffsetFrame;

			public float speed
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}

			public void Start()
			{
			}

			public void Update(float time, int frame, Material material, MaterialPropertyBlock materialPropertyBlock)
			{
			}
		}

		[SerializeField]
		private ScrollData[] _scrollData;

		public ScrollData[] scrollData => null;

		protected override void Awake()
		{
		}

		protected void Reset()
		{
		}

		private void Update()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}
	}
}
