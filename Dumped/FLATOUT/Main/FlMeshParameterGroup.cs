using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	[Serializable]
	public class FlMeshParameterGroup
	{
		public List<FlMeshParameter> _meshParameterList;

		private List<Mesh> _notSharedMeshList;

		private Hashtable _notSharedMaterialTable;

		public List<FlMeshParameter> MeshParameterList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void _Initialize()
		{
		}

		public void _InitializeEditor()
		{
		}

		public bool _CreateMesh(string textureName, bool useCustomMesh, ref FlMeshInfoParameter meshInfo, ref Mesh mesh)
		{
			return default(bool);
		}

		public bool _GetMaterial(string textureName, FlShaderTypes shaderType, int stencilRef, bool useCustomMesh, ref Material material)
		{
			return default(bool);
		}

		public bool _CloneMaterial(Material baseMaterial, string id, ref Material material)
		{
			return default(bool);
		}

		public void _Destroy()
		{
		}

		public bool _SearchMesh(string textureName, ref FlMeshInfoParameterGroup meshInfoParamGroup, ref FlMeshInfoParameter meshInfoParam)
		{
			return default(bool);
		}
	}
}
