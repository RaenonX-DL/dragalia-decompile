/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;
using UnityEngine.Serialization;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[HelpURL]
	[RequireComponent]
	public class SkeletonRenderer : MonoBehaviour, ISkeletonComponent, IHasSkeletonDataAsset
	{
		// Fields
		[CompilerGenerated]
		private SkeletonRendererDelegate OnRebuild;
		[CompilerGenerated]
		private MeshGeneratorDelegate OnPostProcessVertices;
		public SkeletonDataAsset skeletonDataAsset;
		public string initialSkinName;
		public bool initialFlipX;
		public bool initialFlipY;
		[FormerlySerializedAs]
		[SpineSlot]
		public string[] separatorSlotNames;
		[NonSerialized]
		public readonly List<Slot> separatorSlots;
		[Range]
		public float zSpacing;
		public bool useClipping;
		public bool immutableTriangles;
		public bool pmaVertexColors;
		public bool clearStateOnDisable;
		public bool tintBlack;
		public bool singleSubmesh;
		[FormerlySerializedAs]
		public bool addNormals;
		public bool calculateTangents;
		public bool logErrors;
		public bool disableRenderingOnOverride;
		[CompilerGenerated]
		private InstructionDelegate generateMeshOverride;
		[NonSerialized]
		private readonly Dictionary<Material, Material> customMaterialOverride;
		[NonSerialized]
		private readonly Dictionary<Slot, Material> customSlotMaterials;
		private MeshRenderer meshRenderer;
		private MeshFilter meshFilter;
		[NonSerialized]
		public bool valid;
		[NonSerialized]
		public Skeleton skeleton;
		[NonSerialized]
		private readonly SkeletonRendererInstruction currentInstructions;
		private readonly MeshGenerator meshGenerator;
		[NonSerialized]
		private readonly MeshRendererBuffers rendererBuffers;
	
		// Properties
		public SkeletonDataAsset SkeletonDataAsset { get; }
		public Dictionary<Material, Material> CustomMaterialOverride { get; }
		public Dictionary<Slot, Material> CustomSlotMaterials { get; }
		public Skeleton Skeleton { get; }
	
		// Events
		public event SkeletonRendererDelegate OnRebuild {
			add;
			remove;
		}
		public event MeshGeneratorDelegate OnPostProcessVertices {
			add;
			remove;
		}
		private event InstructionDelegate generateMeshOverride {
			add;
			remove;
		}
		public event InstructionDelegate GenerateMeshOverride {
			add;
			remove;
		}
	
		// Nested types
		public delegate void SkeletonRendererDelegate(SkeletonRenderer skeletonRenderer);
	
		public delegate void InstructionDelegate(SkeletonRendererInstruction instruction);
	
		// Constructors
		public SkeletonRenderer();
	
		// Methods
		public static T NewSpineGameObject<T>(SkeletonDataAsset skeletonDataAsset)
			where T : SkeletonRenderer;
		public static T AddSpineComponent<T>(GameObject gameObject, SkeletonDataAsset skeletonDataAsset)
			where T : SkeletonRenderer;
		public void SetMeshSettings(MeshGenerator.Settings settings);
		public virtual void Awake();
		private void OnDisable();
		private void OnDestroy();
		public virtual void ClearState();
		public virtual void Initialize(bool overwrite);
		public virtual void LateUpdate();
	}
}
