using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class PettingCamera : FastUpdateMonoBehaviour
	{
		private GameObject cameraRoot;

		private Vector3 cameraAnimOffset;

		private Animator cameraAnimator;

		private float cameraFieldOfViewDefault;

		private DragonStrokeMain strokeMain;

		private RectTransform canvasTransform;

		private ContactDragon dragon;

		private RenderTexture renderTexture;

		private Texture2D fakeRenderTexture;

		public readonly Vector2 renderTextureSize;

		private bool isTouchGuardOn;

		private const string cameraMotionPath = "Animations/OutGame/DragonContact/Camera/CAM_LOC_DC_cam";

		public Camera mainCamera
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

		public Camera renderTargetCamera
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

		public DragonStrokeScene scene
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

		public void Setup(Camera mainCamera, GameObject cameraRoot, DragonStrokeScene scene, DragonStrokeMain strokeMain, Camera renderTargetCamera)
		{
		}

		public bool IsTouchPointHit(Vector2 touchPos)
		{
			return default(bool);
		}

		public void SetWatchingDragon(ContactDragon dragon)
		{
		}

		public override void FastUpdate()
		{
		}

		public void OnLoadDragon(int dragonId, ContactAsset contactAsset)
		{
		}

		public void OnLoadNoDragon()
		{
		}

		public void StopCameraMotion()
		{
		}

		public void MoveToContactCamera()
		{
		}

		public void MoveToActionCamera()
		{
		}

		public void MoveToNoDragonCamera()
		{
		}

		public void ReturnCamera(float timeMul = 1f)
		{
		}

		public void FirstCameraImmediate()
		{
		}

		private void TraceBoneEmotionIcon()
		{
		}
	}
}
