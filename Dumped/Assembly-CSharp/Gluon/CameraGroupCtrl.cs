/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CameraGroupCtrl : MonoBehaviour
	{
		// Fields
		public List<CameraGroup> cameraGroupList;
		[CompilerGenerated]
		private Transform _rootTransform_k__BackingField;
		[CompilerGenerated]
		private CameraGroup _mainCameraGroup_k__BackingField;
		[CompilerGenerated]
		private CameraController _cameraController_k__BackingField;
		[CompilerGenerated]
		private PostEffect _mainPostEffect_k__BackingField;
		public FilterUseType _heavyFilterUseType;
	
		// Properties
		public Transform rootTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CameraGroup mainCameraGroup { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CameraController cameraController { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PostEffect mainPostEffect { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FilterUseType heavyFilterUseType { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public string name;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal bool _FindCameraGroup_b__0(CameraGroup x);
		}
	
		// Constructors
		public CameraGroupCtrl();
	
		// Methods
		protected virtual void Awake();
		public CameraGroup FindCameraGroup(string name);
		public virtual int GetRenderLayer(Material material);
		public virtual void Initialize();
	}
}
