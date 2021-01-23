/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyMaterialData : CuttTimelineKeyTransformData, ICuttTimelineKeyHasColor
	{
		// Fields
		public MaterialKeyType keyType;
		public RootNodeKind rootNodeKind;
		public CuttCharacterInitializer.CharacterId charaObjectId;
		public string charaNodeName;
		public string charaMaterialName;
		public ShaderParamData[] shaderParamDataArray;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Nested types
		public enum MaterialKeyType
		{
			GetMaterialAndSetParam = 0,
			SetParamOnly = 1
		}
	
		public enum MaterialParamType
		{
			FloatValue = 0,
			ColorValue = 1
		}
	
		public enum RootNodeKind
		{
			Character = 0,
			BgModel = 1
		}
	
		[Serializable]
		public class ShaderParamData
		{
			// Fields
			public MaterialParamType shaderParamType;
			public string shaderParamName;
			public float shaderParamValue;
			public Color shaderParamColor;
	
			// Constructors
			public ShaderParamData();
	
			// Methods
			public void SetData(ShaderParamData src);
			public void SetMaterialAccessData(ShaderParamData src);
		}
	
		// Constructors
		public CuttTimelineKeyMaterialData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public Color GetRepresentativeColor();
		public bool IsChanged(CuttTimelineKeyMaterialData targetData);
		public void SetData(CuttTimelineKeyMaterialData targetData);
		public void SetMaterialtAccessData(CuttTimelineKeyMaterialData targetData);
		public int GetParamNum();
		private void AddParam();
		private void RemoveParam(int index);
	}
}
