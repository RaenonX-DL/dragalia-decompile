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
	public class FlMeshParameter : FlScriptableObject
	{
		// Fields
		public List<FlCustomMeshInfoParameter> _customMeshInfoParameterList;
		public List<FlMeshInfoParameterGroup> _meshParameterGroupList;
		private Hashtable _customMeshInfoParameterTable;
	
		// Properties
		public List<FlMeshInfoParameterGroup> MeshParameterGroupList { get; set; }
		public List<FlCustomMeshInfoParameter> CustomMeshInfoParameterList { get; set; }
	
		// Constructors
		public FlMeshParameter();
	
		// Methods
		public void _Initialize();
		public bool _CreateMesh(string textureName, List<Mesh> meshList, bool useCustomMesh, ref FlMeshInfoParameter meshInfo, ref Mesh mesh);
		public FlCustomMeshInfoParameter _GetCustomMeshInfoParam(string textureName);
		public bool _GetMaterial(string textureName, FlShaderTypes shaderType, int stencilRef, bool useCustomMesh, ref Material material);
		public void _Destroy();
		public bool _SearchMesh(string textureName, ref FlMeshInfoParameterGroup meshInfoParamGroup, ref FlMeshInfoParameter meshInfoParam);
	}
}
