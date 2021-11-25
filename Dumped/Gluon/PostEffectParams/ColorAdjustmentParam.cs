using System;
using UnityEngine;

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class ColorAdjustmentParam
	{
		[Tooltip("æ\u0098\u008eã\u0082\u008bã\u0081\u0095èª¿æ\u0095\u00b4å\u0080¤")]
		public float bright;

		[Tooltip("å½©åº¦èª¿æ\u0095\u00b4å\u0080¤")]
		public float saturation;

		[Tooltip("ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0082¹ã\u0083\u0088èª¿æ\u0095\u00b4å\u0080¤")]
		public float contrast;
	}
}
