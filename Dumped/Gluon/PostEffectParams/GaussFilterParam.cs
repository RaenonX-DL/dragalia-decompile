using System;
using UnityEngine;

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class GaussFilterParam
	{
		[Tooltip("æ°\u00b4å¹³æ\u0096¹å\u0090\u0091ã\u0081®ã\u0082¬ã\u0082¦ã\u0082¹ã\u0081®ç²¾åº¦")]
		public GaussType gaussHorizon;

		[Tooltip("å\u009e\u0082ç\u009b\u00b4æ\u0096¹å\u0090\u0091ã\u0081®ã\u0082¬ã\u0082¦ã\u0082¹ã\u0081®ç²¾åº¦")]
		public GaussType gaussVertical;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ã\u0081¼ã\u0081\u008bã\u0081\u0097å¹\u0085")]
		public float blurSize;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ã\u0081¼ã\u0081\u008bã\u0081\u0097ã\u0081®å¼·åº¦")]
		public float blurPower;
	}
}
