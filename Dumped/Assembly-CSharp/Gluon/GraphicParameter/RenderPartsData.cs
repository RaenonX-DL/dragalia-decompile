/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.GraphicParameter
{
	public class RenderPartsData : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private List<Renderer> bodyRenderers;
		[SerializeField]
		private List<PartsMeshData> _partsMeshDataList;
		private List<Renderer> entryRendererList;
		[CompilerGenerated]
		private readonly Dictionary<string, PartsMeshData> _partsMeshDataDictionary_k__BackingField;
		public static readonly string SpecialPartsName_Eye;
		public static readonly string SpecialPartsName_Mouth;
		public static readonly string[] SpecialPartsNames;
	
		// Properties
		public List<PartsMeshData> partsMeshDataList { get; }
		public Dictionary<string, PartsMeshData> partsMeshDataDictionary { [CompilerGenerated] get; }
	
		// Nested types
		public enum PartsNo
		{
			None = -1,
			A = 0,
			B = 1,
			C = 2,
			D = 3,
			E = 4,
			F = 5,
			G = 6,
			H = 7
		}
	
		[Serializable]
		public class RendererData
		{
			// Fields
			[Tooltip]
			public Renderer renderer;
			[Tooltip]
			public int materialIndex;
	
			// Constructors
			public RendererData();
		}
	
		[Serializable]
		public class RendererDataArray
		{
			// Fields
			public RendererData[] rendererDataArray;
	
			// Constructors
			public RendererDataArray();
		}
	
		[Serializable]
		public class PartsMeshData
		{
			// Fields
			[Tooltip]
			public string name;
			[Tooltip]
			public bool isSyncMainColor;
			[Tooltip]
			public PartsNo activeNo;
			[Tooltip]
			public PartsNo cuttInitializeNo;
			[Header]
			[Tooltip]
			public PartsNo myPageSceneInitializeNo;
			[Tooltip]
			public PartsNo equipWeaponSceneInitializeNo;
			[Tooltip]
			public PartsNo otherOutGameSceneInitializeNo;
			[Tooltip]
			public List<RendererDataArray> rendererDataArrayList;
			[HideInInspector]
			public MaterialPropertyData materialPropertyData;
			private PartsNo currentPartsNo;
	
			// Properties
			public PartsNo CurrentPartsNo { get; set; }
	
			// Constructors
			public PartsMeshData();
	
			// Methods
			public void SetActiveRenderer(PartsNo no);
		}
	
		// Constructors
		public RenderPartsData();
		static RenderPartsData();
	
		// Methods
		public PartsMeshData GetPartsMeshData(string name);
		public bool IsPartsRenderer(Renderer testRenderer);
		private void Awake();
		private void LateUpdate();
		public void ChangeMesh(string partsName, PartsNo partsNo);
		public void RestoreMeshEnable();
		public void ResetChangeMesh();
		public void CuttInitialize();
		public void OutGameInitialize(SimpleCharacterModelLoader.OutGameScene scene);
		public void SetPropertyBlock();
		public MaterialPropertyData GetMaterialPropertyData(string partsName);
		public static PartsNo GetPartsNoFromString(string partsNoStr);
		public List<Renderer> GetEntryRendererList();
	}
}
