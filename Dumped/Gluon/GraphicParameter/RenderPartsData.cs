using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.GraphicParameter
{
	public class RenderPartsData : MonoBehaviour
	{
		public enum PartsNo
		{
			A = 0,
			B = 1,
			C = 2,
			D = 3,
			E = 4,
			F = 5,
			G = 6,
			H = 7,
			None = -1
		}

		[Serializable]
		public class RendererData
		{
			[Tooltip("å\u00af¾è±¡ã\u0081®ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083©ã\u0083¼")]
			public Renderer renderer;

			[Tooltip("å\u00af¾è±¡ã\u0081®ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ID")]
			public int materialIndex;
		}

		[Serializable]
		public class RendererDataArray
		{
			public RendererData[] rendererDataArray;
		}

		[Serializable]
		public class PartsMeshData
		{
			[Tooltip("ã\u0083\u0091ã\u0083¼ã\u0083\u0084å\u0090\u008d\nEyeã\u0082\u0092æ\u008c\u0087å®\u009aã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ç\u009b®ã\u0083\u0091ã\u0083\u0081å\u00af¾å¿\u009c\nMouthã\u0082\u0092æ\u008c\u0087å®\u009aã\u0081\u0099ã\u0082\u008bã\u0081\u00a8å\u008f£ã\u0083\u0091ã\u0082\u00afå\u00af¾å¿\u009c")]
			public string name;

			[Tooltip("ã\u0083¡ã\u0082¤ã\u0083³ã\u0081®ã\u0082«ã\u0083©ã\u0083¼å¤\u0089æ\u009b\u00b4ã\u0081\u00a8å\u0090\u008cæ\u009c\u009fã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
			public bool isSyncMainColor;

			[Tooltip("ã\u0082¢ã\u0082\u00afã\u0083\u0086ã\u0082£ã\u0083\u0096ã\u0081ªã\u0083\u0091ã\u0083¼ã\u0083\u0084ç\u0095ªå\u008f·")]
			public PartsNo activeNo;

			[Tooltip("Cuttã\u0081§å\u0088\u009dæ\u009c\u009få\u008c\u0096ã\u0081\u0097ã\u0081\u009fã\u0081\u0084ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0083\u0091ã\u0083¼ã\u0083\u0084ç\u0095ªå\u008f·")]
			public PartsNo cuttInitializeNo;

			[Header("ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0082²ã\u0083¼ã\u0083\u00a0")]
			[Tooltip("ã\u0083\u009eã\u0082¤ã\u0083\u009aã\u0083¼ã\u0082\u00b8ã\u0081§å\u0088\u009dæ\u009c\u009få\u008c\u0096ã\u0081\u0097ã\u0081\u009fã\u0081\u0084ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0083\u0091ã\u0083¼ã\u0083\u0084ç\u0095ªå\u008f·")]
			public PartsNo myPageSceneInitializeNo;

			[Tooltip("æ­¦å\u0099\u00a8ã\u0082\u0092è£\u0085å\u0082\u0099ã\u0081\u0099ã\u0082\u008bã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0082²ã\u0083¼ã\u0083\u00a0ã\u0082·ã\u0083¼ã\u0083³ã\u0081§å\u0088\u009dæ\u009c\u009få\u008c\u0096ã\u0081\u0097ã\u0081\u009fã\u0081\u0084ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0083\u0091ã\u0083¼ã\u0083\u0084ç\u0095ªå\u008f·")]
			public PartsNo equipWeaponSceneInitializeNo;

			[Tooltip("ã\u0081\u009dã\u0081®ä»\u0096ã\u0082¢ã\u0082¦ã\u0083\u0088ã\u0082²ã\u0083¼ã\u0083\u00a0ã\u0082·ã\u0083¼ã\u0083³ã\u0081§å\u0088\u009dæ\u009c\u009få\u008c\u0096ã\u0081\u0097ã\u0081\u009fã\u0081\u0084ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0083\u0091ã\u0083¼ã\u0083\u0084ç\u0095ªå\u008f·")]
			public PartsNo otherOutGameSceneInitializeNo;

			[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ç\u0094\u00a8ã\u0081®ã\u0083\u0091ã\u0083¼ã\u0083\u0084ã\u0081®ã\u0083¬ã\u0083³ã\u0083\u0080ã\u0083©ã\u0083¼")]
			public List<RendererDataArray> rendererDataArrayList;

			[HideInInspector]
			public MaterialPropertyData materialPropertyData;

			private PartsNo currentPartsNo;

			public PartsNo CurrentPartsNo
			{
				get
				{
					return default(PartsNo);
				}
				set
				{
				}
			}

			public void SetActiveRenderer(PartsNo no)
			{
			}
		}

		[SerializeField]
		[Tooltip("æ\u009c¬ä½\u0093ã\u0081®Rendererï¼\u0088ã\u0081\u0093ã\u0081\u0093ã\u0081«ç\u0099»é\u008c²ã\u0081\u0095ã\u0082\u008cã\u0081\u009fRendererã\u0081\u008cã\u0081\u0099ã\u0081¹ã\u0081¦ç\u0084¡å\u008a¹ã\u0081®æ\u0099\u0082ã\u0081\u00afã\u0083\u0091ã\u0083¼ã\u0083\u0084å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088å\u0087¦ç\u0090\u0086ã\u0081\u00afè¡\u008cã\u0082\u008fã\u0081ªã\u0081\u0084ï¼\u0089")]
		private List<Renderer> bodyRenderers;

		[SerializeField]
		private List<PartsMeshData> _partsMeshDataList;

		private List<Renderer> entryRendererList;

		public static readonly string SpecialPartsName_Eye;

		public static readonly string SpecialPartsName_Mouth;

		public static readonly string[] SpecialPartsNames;

		public List<PartsMeshData> partsMeshDataList => null;

		public Dictionary<string, PartsMeshData> partsMeshDataDictionary
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public PartsMeshData GetPartsMeshData(string name)
		{
			return null;
		}

		public bool IsPartsRenderer(Renderer testRenderer)
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void ChangeMesh(string partsName, PartsNo partsNo)
		{
		}

		public void RestoreMeshEnable()
		{
		}

		public void ResetChangeMesh()
		{
		}

		public void CuttInitialize()
		{
		}

		public void OutGameInitialize(SimpleCharacterModelLoader.OutGameScene scene)
		{
		}

		public void SetPropertyBlock()
		{
		}

		public MaterialPropertyData GetMaterialPropertyData(string partsName)
		{
			return null;
		}

		public static PartsNo GetPartsNoFromString(string partsNoStr)
		{
			return default(PartsNo);
		}

		public List<Renderer> GetEntryRendererList()
		{
			return null;
		}

		public List<Renderer> GetBodyRendererList()
		{
			return null;
		}

		public void AddBodyRendererList(Renderer renderer)
		{
		}
	}
}
