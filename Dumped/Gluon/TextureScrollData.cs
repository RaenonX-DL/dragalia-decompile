using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class TextureScrollData
	{
		[SerializeField]
		[Tooltip("è\u00a8­å®\u009aã\u0081\u0099ã\u0082\u008bã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0083\u0097ã\u0083­ã\u0083\u0091ã\u0083\u0086ã\u0082£")]
		private string _texturePropertyName;

		private string _texturePropertyName_ST;

		private int _texturePropertyID;

		private int _texturePropertyID_ST;

		[SerializeField]
		[Tooltip("è\u00a8­å®\u009aã\u0081\u0099ã\u0082\u008bã\u0082¢ã\u0083«ã\u0083\u0095ã\u0082¡ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0083\u0097ã\u0083­ã\u0083\u0091ã\u0083\u0086ã\u0082£")]
		private string _alphaTexturePropertyName;

		private string _alphaTexturePropertyName_ST;

		private int _alphaTexturePropertyID_ST;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082«ã\u0083¼ã\u0083\u0096ã\u0082\u0092ä½¿ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008b")]
		private bool _animationCurveMode;

		[SerializeField]
		[Tooltip("ï¼\u0091å\u009b\u009eã\u0081§ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0081\u0099ã\u0082\u008bUVå\u0080¤")]
		private Vector2 _Speed;

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
		[Tooltip("Uæ\u0096¹å\u0090\u0091ã\u0081®ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve _animationCurveU;

		[SerializeField]
		[Tooltip("Væ\u0096¹å\u0090\u0091ã\u0081®ã\u0082¹ã\u0082\u00afã\u0083­ã\u0083¼ã\u0083«ã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082«ã\u0083¼ã\u0083\u0096")]
		private AnimationCurve _animationCurveV;

		private Vector4 _Texture_ST;

		private int _oldFrame;

		private float _intervalTime;

		private int _randomOffsetFrame;

		public string AlphaTexturePropertyName => null;

		public Vector2 speed
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public void Start()
		{
		}

		public void Update(float time, int frame, Material material, MaterialPropertyBlock materialPropertyBlock, Vector2 scale)
		{
		}
	}
}
