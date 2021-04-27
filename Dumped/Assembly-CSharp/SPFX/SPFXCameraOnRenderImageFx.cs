/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	public class SPFXCameraOnRenderImageFx : MonoBehaviour
	{
		// Fields
		private Camera RefCamera;
		private bool RequiredBillboardCamera;
		[Header]
		public Light TargetLight;
		[Range]
		public float SceneLightScale;
		[Range]
		public float SceneAmbientScale;
		[Header]
		public eDrawLayer[] DrawLayersBefore;
		public eDrawLayer[] DrawLayersAfter;
		[Header]
		public bool BillboardCamera;
		[Header]
		public eDebugInfoType DebugInfoType;
		[Header]
		private Shader CopyShader;
		public Material CopyMaterial;
		private int _DepthPass;
		private int _ColorPass;
	
		// Nested types
		public enum MaterialPassName
		{
			DepthTexture = 0,
			MainTextureBase = 1,
			MainTextureSideY = 2
		}
	
		// Constructors
		public SPFXCameraOnRenderImageFx();
	
		// Methods
		private void Awake();
		private void OnEnable();
		private void OnDisable();
		private void OnDestroy();
		private void Start();
		private void OnRenderImage(RenderTexture source, RenderTexture destination);
	}
}
