using System;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyMaterialData : CuttTimelineKeyTransformData, ICuttTimelineKeyHasColor
	{
		public enum MaterialKeyType
		{
			GetMaterialAndSetParam,
			SetParamOnly
		}

		public enum MaterialParamType
		{
			FloatValue,
			ColorValue
		}

		public enum RootNodeKind
		{
			Character,
			BgModel
		}

		[Serializable]
		public class ShaderParamData
		{
			public MaterialParamType shaderParamType;

			public string shaderParamName;

			public float shaderParamValue;

			public Color shaderParamColor;

			public void SetData(ShaderParamData src)
			{
			}

			public void SetMaterialAccessData(ShaderParamData src)
			{
			}
		}

		public MaterialKeyType keyType;

		public RootNodeKind rootNodeKind;

		public CuttCharacterInitializer.CharacterId charaObjectId;

		public string charaNodeName;

		public string charaMaterialName;

		public ShaderParamData[] shaderParamDataArray;

		public override CuttTimelineKeyDataType dataType => default(CuttTimelineKeyDataType);

		public override void OnLoad(CuttTimelineControl timelineControl)
		{
		}

		public Color GetRepresentativeColor()
		{
			return default(Color);
		}

		public bool IsChanged(CuttTimelineKeyMaterialData targetData)
		{
			return default(bool);
		}

		public void SetData(CuttTimelineKeyMaterialData targetData)
		{
		}

		public void SetMaterialtAccessData(CuttTimelineKeyMaterialData targetData)
		{
		}

		public int GetParamNum()
		{
			return default(int);
		}

		private void AddParam()
		{
		}

		private void RemoveParam(int index)
		{
		}
	}
}
