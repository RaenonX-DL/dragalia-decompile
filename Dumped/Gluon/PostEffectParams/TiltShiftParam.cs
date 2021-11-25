using System;
using UnityEngine;

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class TiltShiftParam
	{
		[Serializable]
		public struct PointIrisSetting
		{
			[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088é\u0099¤å¤\u0096ç\u00af\u0084å\u009b²ã\u0081®ä\u00b8­å¿\u0083ã\u0081®Xåº§æ\u00a8\u0099")]
			public float pointIrisCenterX;

			[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088é\u0099¤å¤\u0096ç\u00af\u0084å\u009b²ã\u0081®ä\u00b8­å¿\u0083ã\u0081®Yåº§æ\u00a8\u0099")]
			public float pointIrisCenterY;

			[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®é\u0099¤å¤\u0096ç\u00af\u0084å\u009b²ã\u0081®å\u0086\u0086ã\u0081®ç\u00b8¦å\u008d\u008aå¾\u0084")]
			public float pointIrisRadiusX;

			[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®é\u0099¤å¤\u0096ç\u00af\u0084å\u009b²ã\u0081®å\u0086\u0086ã\u0081®æ\u00a8ªå\u008d\u008aå¾\u0084")]
			public float pointIrisRadiusY;
		}

		[Tooltip("ã\u0083\u0087ã\u0083\u0090ã\u0083\u0083ã\u0082°ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0081§è¡\u00a8ç¤ºã\u0081\u0097ã\u0081¾ã\u0081\u0099ã\u0080\u0082")]
		public bool isDebugMode;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ç\u0094\u00a8ã\u0081®ã\u0081¼ã\u0081\u008bã\u0081\u0097ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ã\u0081®è§£å\u0083\u008fåº¦")]
		public float resolutionScale;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®é\u0081©ç\u0094\u00a8ç\u00af\u0084å\u009b²")]
		public float blurArea;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®å¼·åº¦")]
		public float blurPower;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088é\u0081©ç\u0094\u00a8ã\u0081®é«\u0098ã\u0081\u0095ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public float blurOffset;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®å¼·ã\u0081\u0095ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public float blurBaseUp;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®é\u0099¤å¤\u0096ã\u0081\u0099ã\u0082\u008bã\u0082\u00a8ã\u0083ªã\u0082¢ã\u0081®æ\u008c\u0087å®\u009a")]
		public PointIrisSetting[] pointIrisSettings;

		[Tooltip("ã\u0083\u0086ã\u0082£ã\u0083«ã\u0083\u0088ã\u0082·ã\u0083\u0095ã\u0083\u0088ã\u0081®é\u0099¤å¤\u0096ã\u0081\u0099ã\u0082\u008bã\u0081\u0097ã\u0081\u008dã\u0081\u0084å\u0080¤")]
		public float pointIrisCutout;

		public void setPointIrisSetting(int index, float centerX, float centerY, float radiusX, float radiusY)
		{
		}
	}
}
