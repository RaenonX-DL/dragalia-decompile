/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;
using UnityEngine.UI;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[AddComponentMenu]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[RequireComponent]
	public class SkeletonGraphic : MaskableGraphic, ISkeletonComponent, IAnimationStateComponent, ISkeletonAnimation, IHasSkeletonDataAsset
	{
		// Fields
		public SkeletonDataAsset skeletonDataAsset;
		[SpineSkin]
		public string initialSkinName;
		public bool initialFlipX;
		public bool initialFlipY;
		[SpineAnimation]
		public string startingAnimation;
		public bool startingLoop;
		public float timeScale;
		public bool freeze;
		public bool unscaledTime;
		private Texture overrideTexture;
		protected Skeleton skeleton;
		protected Spine.AnimationState state;
		[SerializeField]
		protected MeshGenerator meshGenerator;
		private DoubleBuffered<MeshRendererBuffers.SmartMesh> meshBuffers;
		private SkeletonRendererInstruction currentInstructions;
		[CompilerGenerated]
		private UpdateBonesDelegate UpdateLocal;
		[CompilerGenerated]
		private UpdateBonesDelegate UpdateWorld;
		[CompilerGenerated]
		private UpdateBonesDelegate UpdateComplete;
		[CompilerGenerated]
		private MeshGeneratorDelegate OnPostProcessVertices;
	
		// Properties
		public SkeletonDataAsset SkeletonDataAsset { get; }
		public Texture OverrideTexture { get; set; }
		public override Texture mainTexture { get; }
		public Skeleton Skeleton { get; }
		public SkeletonData SkeletonData { get; }
		public bool IsValid { get; }
		public Spine.AnimationState AnimationState { get; }
		public MeshGenerator MeshGenerator { get; }
	
		// Events
		public event UpdateBonesDelegate UpdateLocal {
			add;
			remove;
		}
		public event UpdateBonesDelegate UpdateWorld {
			add;
			remove;
		}
		public event UpdateBonesDelegate UpdateComplete {
			add;
			remove;
		}
		public event MeshGeneratorDelegate OnPostProcessVertices {
			add;
			remove;
		}
	
		// Constructors
		public SkeletonGraphic();
	
		// Methods
		public static SkeletonGraphic NewSkeletonGraphicGameObject(SkeletonDataAsset skeletonDataAsset, Transform parent);
		public static SkeletonGraphic AddSkeletonGraphicComponent(GameObject gameObject, SkeletonDataAsset skeletonDataAsset);
		protected override void Awake();
		public override void Rebuild(CanvasUpdate update);
		public virtual void Update();
		public virtual void Update(float deltaTime);
		public void LateUpdate();
		public Mesh GetLastMesh();
		public void Clear();
		public void Initialize(bool overwrite);
		public void UpdateMesh();
	}
}
