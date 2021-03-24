/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactFlashEffect : MonoBehaviour
	{
		// Fields
		private GameObject flashBase;
		private GameObject flashMot;
		private FlRoot flashRoot;
		private FlMotion rootMotion;
		private List<FlMotion> listMotion;
		private List<FlPlane> listPlane;
		private bool bEdgePause;
		private FlashType flashType;
		private FlashState flashState;
		private Transform parentTransform;
		private Camera parentCamera;
		private const float nearClipDistance = 2f;
		[CompilerGenerated]
		private Canvas _selfCanvas_k__BackingField;
		[CompilerGenerated]
		private Vector2 _posOnCanvas_k__BackingField;
		[CompilerGenerated]
		private Vector3 _posHeartTarget_k__BackingField;
		private GameObject[] flyingHeartIconArray;
		private Vector2 posOnCanvasOrigin;
	
		// Properties
		private Canvas selfCanvas { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector2 posOnCanvas { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 posHeartTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum FlashType
		{
			Normal = 0,
			HeartIn = 1
		}
	
		public enum FlashState
		{
			None = 0,
			Initialized = 1,
			Play = 2,
			End = 3,
			HeartIn = 4,
			Max = 5
		}
	
		// Constructors
		public ContactFlashEffect();
	
		// Methods
		public void Initialize(string flashPath, Transform cameraTrans, Camera camera, Canvas canvas, FlashType a_flashType = FlashType.Normal, GameObject a_heartIcon = null, Transform trans = null);
		private void Update();
		public void Stop();
		public void ForceEnd();
		public void Play(int id = 0, string name = "");
		public bool IsEnd();
		private void PlayMotion();
		private void PauseMotion();
		private void FixTransform(Vector2 pos);
		private bool MoveToHeartIcon();
		private void InitMoveToHeartIconByImage();
		public void ReplaceIcon(int id);
		public void SetDragonModeTimeEffect(bool isActive);
	}
}
