using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class MainCameraCtrl : FastUpdateMonoBehaviour
	{
		public enum CameraLabel
		{
			Main,
			Story3D,
			Story2D
		}

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

		private const string _defaultInGameCameraPrefabRoot = "Prefabs/InGame/Camera/";

		private const string _defaultInGameCameraPrefabName = "gamecamera000";

		private const string _ingameImageEffectRoot = "Prefabs/InGame/ImageEffect/";

		private const string _defaultStory3DCameraPrefabRoot = "Prefabs/Story/3D/Camera/";

		private const string _defaultStory3DCameraPrefabName = "story3dcamera000";

		private const string _story3DImageEffectRoot = "Prefabs/Story/3D/ImageEffect/";

		public CameraGroupCtrl gameMainCamera => null;

		public CameraGroupCtrl story3DMainCamera => null;

		public CameraGroupCtrl story2DMainCamera => null;

		public CameraGroupCtrl uiCamera => null;

		public CameraLabel enableMainCameraLabel => default(CameraLabel);

		public bool isInitialized => default(bool);

		public RenderTextureManager renderTextureManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private GameObject LoadCamera(string prefabName, string defaultPrefabRoot, string defaultPrefabName, string imageEffectRoot, string imageEffectPrefabName)
		{
			return null;
		}

		public void InitializeCamera(CameraLabel cameraLabel, string cameraPrefabName, string imageEffectPrefabName)
		{
		}

		public void Initialize(string inGameCameraPrefabName = "gamecamera000", [Optional] string inGameImageEffectPrefabName, string story3DCameraPrefabName = "story3dcamera000", [Optional] string story3DImageEffectPrefabName)
		{
		}

		public void ChangeMainCamera(CameraLabel label)
		{
		}

		public CameraGroupCtrl GetActiveGameCamera()
		{
			return null;
		}
	}
}
