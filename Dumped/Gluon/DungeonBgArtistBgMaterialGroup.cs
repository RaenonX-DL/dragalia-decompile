using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class DungeonBgArtistBgMaterialGroup : MonoBehaviour
	{
		public enum MaterialGroupID
		{
			A,
			B,
			C,
			D,
			E,
			H,
			G,
			I,
			J,
			K,
			L,
			M,
			N,
			O,
			P,
			Q,
			R,
			S,
			T,
			U,
			V,
			W,
			X,
			Y,
			Z
		}

		public enum MaterialPropertyLabel
		{
			Color,
			SubTextureAlpha,
			SubPaletteAlpha
		}

		[Serializable]
		public class MaterialGroupData
		{
			[Tooltip("ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ã\u0082°ã\u0083«ã\u0083¼ã\u0083\u0097å\u0090\u008d")]
			public string name;

			[Tooltip("ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ã\u0082°ã\u0083«ã\u0083¼ã\u0083\u0097ã\u0081®IDã\u0083©ã\u0083\u0099ã\u0083«")]
			public MaterialGroupID id;

			[Tooltip("æ\u0093\u008dä½\u009cå\u00af¾è±¡ã\u0081®ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«")]
			public List<Material> materialList;

			[NonSerialized]
			public List<Material> materialsWorkList;
		}

		[SerializeField]
		[Tooltip("ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ã\u0081®ã\u0083\u0097ã\u0083­ã\u0083\u0080ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0082\u0092è¡\u008cã\u0081\u0086ã\u0082²ã\u0083¼ã\u0083\u00a0ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088")]
		private GameObject productionObject;

		[SerializeField]
		[Tooltip("ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ã\u0082°ã\u0083«ã\u0083¼ã\u0083\u0097ã\u0083\u0087ã\u0083¼ã\u0082¿")]
		private List<MaterialGroupData> _materialGroupDataList;

		private static int[] materialPropertyIDArray;

		public List<MaterialGroupData> materialGroupDataList => null;

		public void SetFloat(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, float value)
		{
		}

		public void SetVector(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, Vector4 vec)
		{
		}

		public void SetColor(MaterialGroupID groupID, MaterialPropertyLabel propertyLabel, Color color)
		{
		}

		private void Awake()
		{
		}

		public IEnumerator Start()
		{
			return null;
		}
	}
}
