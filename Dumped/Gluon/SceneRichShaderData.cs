using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class SceneRichShaderData : ScriptableObject, IShaderData<SceneRichShaderData>
	{
		[Serializable]
		public class ShadowParam : IShaderData<ShadowParam>
		{
			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³ã\u0081®ã\u0081\u008bã\u0081\u008bã\u0082\u008aæ\u0096¹ã\u0082\u0092æ±ºã\u0082\u0081ã\u0082\u008b")]
			public float step;

			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³ã\u0081®ã\u0081\u008bã\u0081\u008bã\u0082\u008aæ\u0096¹ã\u0082\u0092æ±ºã\u0082\u0081ã\u0082\u008b")]
			public float feather;

			public void Copy(ShadowParam src)
			{
			}
		}

		[Serializable]
		public class ToonShadingData : IShaderData<ToonShadingData>
		{
			[Tooltip("ã\u0082·ã\u0083¼ã\u0083³ã\u0081®ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®è\u0089²")]
			public Color toonGlobalShadowColor;

			[Tooltip("ã\u0082·ã\u0083¼ã\u0083³ã\u0081®ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®ã\u0082°ã\u0083­ã\u0083¼ã\u0081®è\u0089²")]
			public Color toonGlobalShadowGlowColor;

			[Tooltip("ã\u0082·ã\u0083¼ã\u0083³ã\u0081®ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®ã\u0082\u00a8ã\u0083\u0083ã\u0082\u00b8ã\u0081®HSVã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
			public HSVParameterBase toonCommonEdgeShadowHSV;

			[Tooltip("ã\u0082·ã\u0083¼ã\u0083³ã\u0081®ã\u0083©ã\u0082¤ã\u0083\u0088ã\u0081®å\u009b\u009eè»¢å\u0080¤")]
			public Vector3 toonLightParamRoatate;

			[Tooltip("ã\u0083\u009eã\u0083\u0083ã\u0083\u0088ã\u0082­ã\u0083£ã\u0083\u0083ã\u0083\u0097ã\u0083\u0097ã\u0083­ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0081®ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£")]
			public Texture2D matcapProjectionTex;

			[Tooltip("ã\u0083\u009eã\u0083\u0083ã\u0083\u0088ã\u0082­ã\u0083£ã\u0083\u0083ã\u0083\u0097ã\u0083\u0097ã\u0083­ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0082·ã\u0083§ã\u0082ªã\u0081®LODã\u0083¬ã\u0083\u0099ã\u0083«")]
			public float matcapProjectionTexLevel;

			[Tooltip("ã\u0083\u009eã\u0083\u0083ã\u0083\u0088ã\u0082­ã\u0083£ã\u0083\u0083ã\u0083\u0097ã\u0083\u0097ã\u0083­ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0081®è\u0089²")]
			public Color matcapProjectionColor;

			[Tooltip("ã\u0083\u009eã\u0083\u0083ã\u0083\u0088ã\u0082­ã\u0083£ã\u0083\u0083ã\u0083\u0097ã\u0083\u0097ã\u0083­ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0081®å¼·ã\u0081\u0095")]
			public float matcapProjectionIntensity;

			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
			public ShadowParam shadowToon;

			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®ã\u0082\u00a8ã\u0083\u0083ã\u0082\u00b8ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
			public ShadowParam shadowEdge;

			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®ã\u0082°ã\u0083­ã\u0083¼ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
			public ShadowParam shadowGlow;

			public void Copy(ToonShadingData src)
			{
			}
		}

		[Serializable]
		public class OutlineData : IShaderData<OutlineData>
		{
			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®è\u0089²")]
			public Color color;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®å¤ªã\u0081\u0095")]
			public float width;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³èª¿æ\u0095\u00b4æ\u009c\u0080å°\u008f")]
			public float widthClampMin;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³èª¿æ\u0095\u00b4æ\u009c\u0080å¤§")]
			public float widthClampMax;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®å¥¥è¡\u008cã\u0081\u008dã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
			public float offset;

			public void Copy(OutlineData src)
			{
			}
		}

		[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0087ã\u0082£ã\u0083³ã\u0082°ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		public ToonShadingData toonShadingData;

		[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		public OutlineData outlineData;

		private ToonShadingData startToonShadingData;

		private OutlineData startOutlineData;

		public void Copy(SceneRichShaderData src)
		{
		}

		public void Reset()
		{
		}

		private void Awake()
		{
		}
	}
}
