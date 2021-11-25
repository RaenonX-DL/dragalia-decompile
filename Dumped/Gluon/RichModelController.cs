using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class RichModelController : MonoBehaviour
	{
		[Serializable]
		public class MultiMaskData
		{
			public static readonly string allMaterialName;

			[Tooltip("è\u00a8­å®\u009aã\u0081\u0099ã\u0082\u008bã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«å\u0090\u008d\n(All)ã\u0081®å\u00a0\u00b4å\u0090\u0088ã\u0081\u00afå\u0085\u00a8ã\u0081¦ã\u0081«è\u00a8­å®\u009aã\u0081\u0099ã\u0082\u008b")]
			public string materialName;

			[Tooltip("è\u00a8­å®\u009aã\u0081\u0099ã\u0082\u008bã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£")]
			public Texture2D multiMask;
		}

		[Serializable]
		public class ToonShadingData : IShaderData<ToonShadingData>
		{
			[Tooltip("æ\u009c\u0089å\u008a¹ã\u0081\u008b")]
			public bool enable;

			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³ã\u0081®å½±è\u0089²")]
			public Color toonShadowColor;

			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³å½±ã\u0081®HSVã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
			public HSVParameterBase toonShadowHSV;

			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³ã\u0081®ã\u0082\u00a8ã\u0083\u0083ã\u0082\u00b8ã\u0082«ã\u0083©ã\u0083¼ã\u0081®ã\u0082ªã\u0083¼ã\u0083\u0090ã\u0083¼ã\u0083©ã\u0082¤ã\u0083\u0089ã\u0082\u0092è¡\u008cã\u0081\u0086")]
			public bool overwriteShadowEdge;

			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³ã\u0081®ã\u0082\u00a8ã\u0083\u0083ã\u0082\u00b8ã\u0082«ã\u0083©ã\u0083¼ã\u0081®HSVã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
			public HSVParameterBase shadowEdgeHSV;

			[Tooltip("ã\u0083\u009eã\u0083«ã\u0083\u0081ç\u0094\u00a8ã\u0081®ã\u0083\u009eã\u0082¹ã\u0082\u00afã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£")]
			public MultiMaskData[] multiMaskDataArray;

			public void Copy(ToonShadingData src)
			{
			}
		}

		[Serializable]
		public class OutlineData : IShaderData<OutlineData>
		{
			[Tooltip("æ\u009c\u0089å\u008a¹ã\u0081\u008b")]
			public bool enable;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®è\u0089²")]
			public Color color;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®å\u008a\u00a0ç®\u0097ã\u0081®è\u0089²")]
			public Color addColor;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®å\u008a\u00a0ç®\u0097ã\u0081®å¼·ã\u0081\u0095")]
			public float addColorPower;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®å¤ªã\u0081\u0095")]
			public float width;

			public void Copy(OutlineData src)
			{
			}
		}

		[Serializable]
		public class RichGraphicData : IShaderData<RichGraphicData>
		{
			[Tooltip("ã\u0083\u0088ã\u0082¥ã\u0083¼ã\u0083³ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0087ã\u0082£ã\u0083³ã\u0082°ã\u0081®ã\u0083\u0087ã\u0083¼ã\u0082¿")]
			public ToonShadingData toonShadingData;

			[Tooltip("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0083©ã\u0082¤ã\u0083³ã\u0081®ã\u0083\u0087ã\u0083¼ã\u0082¿")]
			public OutlineData outlineData;

			public void Copy(RichGraphicData src)
			{
			}
		}

		[SerializeField]
		[Tooltip("ã\u0083ªã\u0083\u0083ã\u0083\u0081ã\u0082°ã\u0083©ã\u0083\u0095ã\u0082£ã\u0083\u0083ã\u0082\u00afã\u0083\u0087ã\u0083¼ã\u0082¿")]
		private RichGraphicData _richGraphicData;

		private List<Material> _materialList;

		private Transform _cacheTransform;

		public RichGraphicData richGraphicData => null;

		public GameObject rootObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Renderer[] renderers
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void SetMaterialParameter()
		{
		}

		public void SetupToonShading(GameObject obj, [Optional] ShaderLodDataObject shaderLodDataObject)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
