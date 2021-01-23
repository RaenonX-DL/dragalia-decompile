/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	public class SPFXCameraSimple : MonoBehaviour
	{
		// Fields
		private Camera RefCamera;
		public Light TargetLight;
		[Range]
		public float SceneLightScale;
		[Range]
		public float SceneAmbientScale;
		public eDrawLayer[] DrawLayerTable;
		private bool RequiredBillboardCamera;
		public bool RequireBillboardCamera;
		public bool RotV_DirectX;
		public bool RotV_Metal;
		[SerializeField]
		private bool UseTryRendering;
	
		// Constructors
		protected SPFXCameraSimple();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		private void Awake();
		private void Start();
		private void OnPostRender();
	}
}
