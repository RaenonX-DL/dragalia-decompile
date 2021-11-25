using System;
using UnityEngine;

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class PostFilmParam
	{
		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0083¢ã\u0083¼ã\u0083\u0089")]
		public PostFilmMode filmMode;

		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®ã\u0082«ã\u0083©ã\u0083¼ã\u0081®å¼·ã\u0081\u0095")]
		public float filmPower;

		[Tooltip("ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®é\u0081©ç\u0094\u00a8ä½\u008dç½®ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector2 filmOffsetParam;

		[Tooltip("ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088ã\u0081®å¼·ã\u0081\u0095")]
		public float vignetteIntensity;

		[Tooltip("ã\u0083\u00b4ã\u0082£ã\u0083\u008dã\u0083\u0083ã\u0083\u0088ã\u0081®æ\u00b8\u009bè¡°å\u0080¤")]
		public float vignetteDecrement;

		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®è\u0089²æ\u0083\u0085å\u00a0±ï¼\u0090")]
		public Color filmColor0;

		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®è\u0089²æ\u0083\u0085å\u00a0±ï¼\u0091")]
		public Color filmColor1;

		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®è\u0089²æ\u0083\u0085å\u00a0±ï¼\u0092")]
		public Color filmColor2;

		[Tooltip("ã\u0083\u009dã\u0082¹ã\u0083\u0088ã\u0083\u0095ã\u0082£ã\u0083«ã\u0083\u00a0ã\u0081®è\u0089²æ\u0083\u0085å\u00a0±ï¼\u0093")]
		public Color filmColor3;

		public void SetColorAll(Color color)
		{
		}
	}
}
