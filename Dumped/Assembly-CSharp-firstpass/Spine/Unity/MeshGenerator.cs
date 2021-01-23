/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[Serializable]
	public class MeshGenerator
	{
		// Fields
		public Settings settings;
		private const float BoundsMinDefault = 1F / 0F;
		private const float BoundsMaxDefault = -1F / 0F;
		[NonSerialized]
		private readonly ExposedList<Vector3> vertexBuffer;
		[NonSerialized]
		private readonly ExposedList<Vector2> uvBuffer;
		[NonSerialized]
		private readonly ExposedList<Color32> colorBuffer;
		[NonSerialized]
		private readonly ExposedList<ExposedList<int>> submeshes;
		[NonSerialized]
		private Vector2 meshBoundsMin;
		[NonSerialized]
		private Vector2 meshBoundsMax;
		[NonSerialized]
		private float meshBoundsThickness;
		[NonSerialized]
		private int submeshIndex;
		[NonSerialized]
		private SkeletonClipping clipper;
		[NonSerialized]
		private float[] tempVerts;
		[NonSerialized]
		private int[] regionTriangles;
		[NonSerialized]
		private Vector3[] normals;
		[NonSerialized]
		private Vector4[] tangents;
		[NonSerialized]
		private Vector2[] tempTanBuffer;
		[NonSerialized]
		private ExposedList<Vector2> uv2;
		[NonSerialized]
		private ExposedList<Vector2> uv3;
	
		// Properties
		public int VertexCount { get; }
		public MeshGeneratorBuffers Buffers { get; }
	
		// Nested types
		[Serializable]
		public struct Settings
		{
			// Fields
			public bool useClipping;
			[Range]
			[Space]
			public float zSpacing;
			[Header]
			[Space]
			public bool pmaVertexColors;
			public bool tintBlack;
			public bool calculateTangents;
			public bool addNormals;
			public bool immutableTriangles;
	
			// Properties
			public static Settings Default { get; }
		}
	
		// Constructors
		public MeshGenerator();
	
		// Methods
		public static void GenerateSingleSubmeshInstruction(SkeletonRendererInstruction instructionOutput, Skeleton skeleton, Material material);
		public static void GenerateSkeletonRendererInstruction(SkeletonRendererInstruction instructionOutput, Skeleton skeleton, Dictionary<Slot, Material> customSlotMaterials, List<Slot> separatorSlots, bool generateMeshOverride, bool immutableTriangles = false);
		public static void TryReplaceMaterials(ExposedList<SubmeshInstruction> workingSubmeshInstructions, Dictionary<Material, Material> customMaterialOverride);
		public void Begin();
		public void AddSubmesh(SubmeshInstruction instruction, bool updateTriangles = true);
		public void BuildMesh(SkeletonRendererInstruction instruction, bool updateTriangles);
		public void BuildMeshWithArrays(SkeletonRendererInstruction instruction, bool updateTriangles);
		public void ScaleVertexData(float scale);
		private void AddAttachmentTintBlack(float r2, float g2, float b2, int vertexCount);
		public void FillVertexData(Mesh mesh);
		public void FillTriangles(Mesh mesh);
		public void FillTrianglesSingle(Mesh mesh);
		public void TrimExcess();
		internal static void SolveTangents2DEnsureSize(ref Vector4[] tangentBuffer, ref Vector2[] tempTanBuffer, int vertexCount);
		internal static void SolveTangents2DTriangles(Vector2[] tempTanBuffer, int[] triangles, int triangleCount, Vector3[] vertices, Vector2[] uvs, int vertexCount);
		internal static void SolveTangents2DBuffer(Vector4[] tangents, Vector2[] tempTanBuffer, int vertexCount);
	}
}
