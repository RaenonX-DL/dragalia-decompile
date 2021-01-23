/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MainCameraCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject _mainCameraRoot;
		[SerializeField]
		private CameraGroupCtrl _gameMainCamera;
		[SerializeField]
		private CameraGroupCtrl _story3DMainCamera;
		[SerializeField]
		private CameraGroupCtrl _story2DMainCamera;
		[SerializeField]
		private CameraGroupCtrl _uiCamera;
		[SerializeField]
		private CameraLabel _enableMainCameraLabel;
		private bool _isInitialized;
		public static readonly string[] effectRenderTextureNames;
		[CompilerGenerated]
		private RenderTextureManager _renderTextureManager_k__BackingField;
		private const string _defaultInGameCameraPrefabRoot = "Prefabs/InGame/Camera/";
		private const string _defaultInGameCameraPrefabName = "gamecamera000";
		private const string _ingameImageEffectRoot = "Prefabs/InGame/ImageEffect/";
		private const string _defaultStory3DCameraPrefabRoot = "Prefabs/Story/3D/Camera/";
		private const string _defaultStory3DCameraPrefabName = "story3dcamera000";
		private const string _story3DImageEffectRoot = "Prefabs/Story/3D/ImageEffect/";
	
		// Properties
		public CameraGroupCtrl gameMainCamera { get; }
		public CameraGroupCtrl story3DMainCamera { get; }
		public CameraGroupCtrl story2DMainCamera { get; }
		public CameraGroupCtrl uiCamera { get; }
		public CameraLabel enableMainCameraLabel { get; }
		public bool isInitialized { get; }
		public RenderTextureManager renderTextureManager { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum CameraLabel
		{
			Main = 0,
			Story3D = 1,
			Story2D = 2
		}
	
		// Constructors
		public MainCameraCtrl();
		static MainCameraCtrl();
	
		// Methods
		private GameObject LoadCamera(string prefabName, string defaultPrefabRoot, string defaultPrefabName, string imageEffectRoot, string imageEffectPrefabName);
		public void InitializeCamera(CameraLabel cameraLabel, string cameraPrefabName, string imageEffectPrefabName);
		public void Initialize(string inGameCameraPrefabName = "gamecamera000", string inGameImageEffectPrefabName = null, string story3DCameraPrefabName = "story3dcamera000", string story3DImageEffectPrefabName = null);
		public void ChangeMainCamera(CameraLabel label);
		public CameraGroupCtrl GetActiveGameCamera();
	}
}
