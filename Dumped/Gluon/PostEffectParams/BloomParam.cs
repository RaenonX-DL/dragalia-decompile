using System;
using UnityEngine;

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class BloomParam
	{
		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ç\u0094\u00a8ã\u0081®ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®è§£å\u0083\u008fåº¦")]
		public float resolutionScale;

		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0081®ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®å¼·ã\u0081\u0095")]
		public float bloomWeight;

		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0082\u0092é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bæ\u0098\u008eã\u0082\u008bã\u0081\u0095ã\u0081®ã\u0081\u0097ã\u0081\u008dã\u0081\u0084å\u0080¤")]
		public float bloomThreshold;

		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0082\u0092é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bæ\u0098\u008eã\u0082\u008bã\u0081\u0095ã\u0081®å¼·åº¦")]
		public float bloomIntensity;

		[Tooltip("ã\u0083\u0096ã\u0083«ã\u0083¼ã\u0083\u00a0ã\u0081®æ\u0098\u008eã\u0082\u008bã\u0081\u0095ã\u0081®æ\u00b8\u009bè¡°å\u0080¤")]
		public float bloomLuminancePower;
	}
}
