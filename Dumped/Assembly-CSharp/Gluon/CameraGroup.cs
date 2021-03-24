/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class CameraGroup
	{
		// Fields
		public string groupName;
		public List<CameraData> cameraDataList;
		[CompilerGenerated]
		private ImageEffectCtrl _imageEffectCtrl_k__BackingField;
		[CompilerGenerated]
		private List<CameraData> _cameraDataDrawList_k__BackingField;
	
		// Properties
		public ImageEffectCtrl imageEffectCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<CameraData> cameraDataDrawList { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CameraData headCameraData { get; }
		public PostEffect headPostEffect { get; }
		public Camera headCamera { get; }
		public bool enabled { get; set; }
		public float orthographicSize { get; set; }
		public float nearClipPlane { get; set; }
		public float farClipPlane { get; set; }
		public float fieldOfView { get; set; }
		public bool orthographic { get; set; }
		public Color backgroundColor { get; set; }
		public Rect rect { get; set; }
		public bool useOcclusionCulling { get; set; }
		public bool allowHDR { get; set; }
		public float aspect { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<CameraData> __9__10_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _Initialize_b__10_0(CameraData a, CameraData b);
		}
	
		// Constructors
		public CameraGroup();
	
		// Methods
		public void Initialize();
	}
}
