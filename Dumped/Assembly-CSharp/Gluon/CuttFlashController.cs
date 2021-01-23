/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cutt;
using FLATOUT.Main;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CuttFlashController : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public CuttFlashInitializeData initializeData;
		private FlRoot flRoot;
		private float scaleFactor;
		private RectTransform canvasRect;
		private CameraGroup flCameraGroup;
		private const float raidBossFlashSidebarWidthFull = 600f;
		private const float raidBossFlashSidebarChangeBorder = 200f;
		private const float raidBossFlashSidebarOffsetFirst = 200f;
		private const float raidBossFlashSidebarPixelToUnit = 100f;
		private const float raidBossEmptyDifficultTextOffsetY = -24f;
	
		// Constructors
		public CuttFlashController();
	
		// Methods
		private void Start();
		private void OnDestroy();
		public void PlayMotion(string labelName);
		public void AltherUpdate(int frame);
		public void SetFtuInitializeData(CuttFtuInitializeData data, string folderPath);
		private float GetTextWidth(TextMesh textMesh);
	}
}
