/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.GraphicParameter
{
	public class ChangePartsMesh : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private List<Renderer> bodyRenderers;
		[SerializeField]
		private List<PartMeshData> _partMeshDataList;
		[CompilerGenerated]
		private readonly Dictionary<string, PartMeshData> _partsMeshDataDictionary_k__BackingField;
	
		// Properties
		public List<PartMeshData> partMeshDataList { get; }
		public Dictionary<string, PartMeshData> partsMeshDataDictionary { [CompilerGenerated] get; }
	
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
		public class PartMeshData
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
			[Tooltip]
			public Renderer[] renderers;
			[HideInInspector]
			public MaterialPropertyData materialPropertyData;
	
			// Constructors
			public PartMeshData();
	
			// Methods
			public void SetActiveRenderer(int no);
		}
	
		// Constructors
		public ChangePartsMesh();
	
		// Methods
		public bool IsPartsRenderer(Renderer testRenderer);
		private void Awake();
		private void LateUpdate();
		public void ChangeMesh(string partsName, PartsNo partsNo);
		public void CuttInitialize();
		public void SetPropertyBlock();
		public MaterialPropertyData GetMaterialPropertyData(string partsName);
		public static PartsNo GetPartsNoFromString(string partsNoStr);
	}
}
