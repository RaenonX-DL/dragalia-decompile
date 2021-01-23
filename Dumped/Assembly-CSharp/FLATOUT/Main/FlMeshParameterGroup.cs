/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMeshParameterGroup
	{
		// Fields
		public List<FlMeshParameter> _meshParameterList;
		private List<Mesh> _notSharedMeshList;
		private Hashtable _notSharedMaterialTable;
	
		// Properties
		public List<FlMeshParameter> MeshParameterList { get; set; }
	
		// Constructors
		public FlMeshParameterGroup();
	
		// Methods
		public void _Initialize();
		public void _InitializeEditor();
		public bool _CreateMesh(string textureName, bool useCustomMesh, ref FlMeshInfoParameter meshInfo, ref Mesh mesh);
		public bool _GetMaterial(string textureName, FlShaderTypes shaderType, int stencilRef, bool useCustomMesh, ref Material material);
		public bool _CloneMaterial(Material baseMaterial, string id, ref Material material);
		public void _Destroy();
		public bool _SearchMesh(string textureName, ref FlMeshInfoParameterGroup meshInfoParamGroup, ref FlMeshInfoParameter meshInfoParam);
	}
}
