/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	[RequireComponent]
	public class SkeletonPartsRenderer : MonoBehaviour
	{
		// Fields
		private MeshGenerator meshGenerator;
		private MeshRenderer meshRenderer;
		private MeshFilter meshFilter;
		private MeshRendererBuffers buffers;
		private SkeletonRendererInstruction currentInstructions;
	
		// Properties
		public MeshGenerator MeshGenerator { get; }
		public MeshRenderer MeshRenderer { get; }
		public MeshFilter MeshFilter { get; }
	
		// Constructors
		public SkeletonPartsRenderer();
	
		// Methods
		private void LazyIntialize();
		public void ClearMesh();
		public void RenderParts(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh);
		public void SetPropertyBlock(MaterialPropertyBlock block);
		public static SkeletonPartsRenderer NewPartsRendererGameObject(Transform parent, string name);
	}
}
