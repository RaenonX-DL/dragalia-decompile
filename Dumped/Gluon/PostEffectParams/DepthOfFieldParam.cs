using System;
using UnityEngine;

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class DepthOfFieldParam
	{
		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081®ã\u0083\u0095ã\u0082£ã\u0083«ã\u0082¿ç\u0094\u00a8ã\u0081®è§£å\u0083\u008fåº¦")]
		public float resolutionScale;

		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081®æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097")]
		public DofFocalType focalType;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081\u008bã\u0082\u0089ã\u0083\u0094ã\u0083³ã\u0083\u0088ã\u0081\u008cã\u0081\u0082ã\u0081£ã\u0081¦ã\u0081\u0084ã\u0082\u008bå¹\u0085")]
		public float focalSize;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0081\u008cLengthã\u0081\u00a0ã\u0081£ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008bã\u0082\u0089ã\u0081®è·\u009dé\u009b¢")]
		public float focalLength;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0081\u008cLengthã\u0081\u00a0ã\u0081£ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008bã\u0082\u0089ã\u0081®æ\u009c\u0080å°\u008fè·\u009dé\u009b¢")]
		public float minFocalLength;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0081\u008cLengthã\u0081\u00a0ã\u0081£ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008bã\u0082\u0089ã\u0081®æ\u009c\u0080å¤§è·\u009dé\u009b¢")]
		public float maxFocalLength;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0081\u008cTransformã\u0081\u00a0ã\u0081£ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®å\u00af¾è±¡ã\u0081®Transformã\u0082³ã\u0083³ã\u0083\u009dã\u0083¼ã\u0083\u008dã\u0083³ã\u0083\u0088")]
		public Transform focalTransfrom;

		[Tooltip("æ³\u00a8è¦\u0096ç\u0082¹ã\u0081®ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0081\u008cPositionã\u0081\u00a0ã\u0081£ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®å\u00af¾è±¡ã\u0081®ä½\u008dç½®")]
		public Vector3 focalPosition;

		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081®é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082¹ã\u0083\u00a0ã\u0083¼ã\u0082¹ã\u0081®æ»\u0091ã\u0082\u0089ã\u0081\u008bã\u0081\u0095")]
		public float smoothness;

		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081®é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082¹ã\u0083\u00a0ã\u0083¼ã\u0082¹ã\u0081®èª¿æ\u0095\u00b4å\u0080¤")]
		public float smoothStepMin;

		[Tooltip("è¢«å\u0086\u0099ç\u0095\u008cæ·±åº¦ã\u0081®é\u0081©ç\u0094\u00a8ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082¹ã\u0083\u00a0ã\u0083¼ã\u0082¹ã\u0081®èª¿æ\u0095\u00b4å\u0080¤")]
		public float smoothStepMax;
	}
}