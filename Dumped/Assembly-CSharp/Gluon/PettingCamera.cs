/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PettingCamera : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private Camera _mainCamera_k__BackingField;
		[CompilerGenerated]
		private Camera _renderTargetCamera_k__BackingField;
		[CompilerGenerated]
		private DragonStrokeScene _scene_k__BackingField;
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
	
		// Properties
		public Camera mainCamera { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Camera renderTargetCamera { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DragonStrokeScene scene { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public PettingCamera();
	
		// Methods
		public void Setup(Camera mainCamera, GameObject cameraRoot, DragonStrokeScene scene, DragonStrokeMain strokeMain, Camera renderTargetCamera);
		public bool IsTouchPointHit(Vector2 touchPos);
		public void SetWatchingDragon(ContactDragon dragon);
		public override void FastUpdate();
		public void OnLoadDragon(int dragonId, ContactAsset contactAsset);
		public void OnLoadNoDragon();
		public void StopCameraMotion();
		public void MoveToContactCamera();
		public void MoveToActionCamera();
		public void MoveToNoDragonCamera();
		public void ReturnCamera(float timeMul = 1f);
		public void FirstCameraImmediate();
		private void TraceBoneEmotionIcon();
	}
}
