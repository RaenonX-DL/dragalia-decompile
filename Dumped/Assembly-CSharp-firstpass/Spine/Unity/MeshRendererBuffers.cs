/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class MeshRendererBuffers : IDisposable
	{
		// Fields
		private DoubleBuffered<SmartMesh> doubleBufferedMesh;
		internal readonly ExposedList<Material> submeshMaterials;
		internal Material[] sharedMaterials;
	
		// Nested types
		public class SmartMesh : IDisposable
		{
			// Fields
			public Mesh mesh;
			public SkeletonRendererInstruction instructionUsed;
	
			// Constructors
			public SmartMesh();
	
			// Methods
			public void Dispose();
		}
	
		// Constructors
		public MeshRendererBuffers();
	
		// Methods
		public void Initialize();
		public Material[] GetUpdatedSharedMaterialsArray();
		public bool MaterialsChangedInLastUpdate();
		public void UpdateSharedMaterials(ExposedList<SubmeshInstruction> instructions);
		public SmartMesh GetNextMesh();
		public void Clear();
		public void Dispose();
	}
}
