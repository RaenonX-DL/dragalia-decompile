using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyRichShaderData : CuttTimelineKeyWithInterpolate
	{
		[Tooltip("ã\u0082·ã\u0083¼ã\u0083³ã\u0081®ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®è\u0089²")]
		public Color toonGlobalShadowColor;

		[Tooltip("ã\u0082·ã\u0083¼ã\u0083³ã\u0081®ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®ã\u0082°ã\u0083­ã\u0083¼ã\u0081®è\u0089²")]
		public Color toonGlobalShadowGlowColor;

		[Tooltip("ã\u0082·ã\u0083¼ã\u0083³ã\u0081®ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®ã\u0082\u00a8ã\u0083\u0083ã\u0082\u00b8ã\u0081®HSVã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		public HSVParameterBase toonCommonEdgeShadowHSV;

		[Tooltip("ã\u0082·ã\u0083¼ã\u0083³ã\u0081®ã\u0083©ã\u0082¤ã\u0083\u0088ã\u0081®å\u009b\u009eè»¢å\u0080¤")]
		public Vector3 toonLightParamRoatate;

		[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³èª¿æ\u0095\u00b4æ\u009c\u0080å°\u008f")]
		public float outlineWidthClampMin;

		[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³èª¿æ\u0095\u00b4æ\u009c\u0080å¤§")]
		public float outlineWidthClampMax;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public CuttTimelineKey Interpolate(CuttTimelineKey interpKey, CuttTimelineKey prevKey, float t)
		{
			return null;
		}
	}
}
