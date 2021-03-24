/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumSummonCanvas : MonoBehaviour
	{
		// Fields
		private Vector2 _canvasSize;
		[HideInInspector]
		public Camera flashCamera;
		[HideInInspector]
		public Canvas uiCanvas;
		public UnityAction onEndCallback;
		private AlbumSummonPlay summonPlay;
	
		// Properties
		public Vector2 canvasSize { get; }
	
		// Constructors
		public AlbumSummonCanvas();
	
		// Methods
		public void SetUp(GiftType giftType, int masterId, Rarity rarity, Camera camera, UnityAction action);
		private void Start();
		public void ResetFlashCameraSize();
		private void Load3DScene();
		public void ChangeToResultPage();
		public void OnScreenTapped();
		[CompilerGenerated]
		private void _Load3DScene_b__10_0(GameObject prefab);
		[CompilerGenerated]
		private void _Load3DScene_b__10_1();
		[CompilerGenerated]
		private void _ChangeToResultPage_b__11_0();
	}
}
