/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OutGameModelChanger : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private RenderPartsData renderPartsData;
		public List<MeshData> defaultMeshList;
		private Dictionary<string, RenderPartsData.PartsNo> activePartsDic;
	
		// Nested types
		[Serializable]
		public struct MeshData
		{
			// Fields
			public string PartsMeshName;
			public RenderPartsData.PartsNo partsNo;
		}
	
		// Constructors
		public OutGameModelChanger();
	
		// Methods
		private void Awake();
		public void SetCharaMesh();
		private void ChangeMesh(string partsName, RenderPartsData.PartsNo partNo);
	}
}
