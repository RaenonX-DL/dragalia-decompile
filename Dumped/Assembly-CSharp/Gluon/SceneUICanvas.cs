/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SceneUICanvas : MonoBehaviour
	{
		// Fields
		private const int additiveSceneUiSortingOrderDefault = 80;
		private const int additiveSceneUiSortingOrderOverHeader = 120;
		[SerializeField]
		private string parentSceneName;
		[SerializeField]
		private bool isOverHeader;
		[SerializeField]
		private GameObject addtiveSceneObj;
		[Header]
		[SerializeField]
		private UiCameraParentScene uiCameraParentScene;
		private Camera mainSceneUiCamera;
	
		// Nested types
		private enum UiCameraParentScene
		{
			None = 0,
			QuestSelect = 1
		}
	
		// Constructors
		public SceneUICanvas();
	
		// Methods
		public void OnSceneUICanvasLoaded(Camera additiveSceneCamera = null);
		private Camera GetMainSceneUiCamera(UiCameraParentScene uiCameraParentScene);
		private Camera GetQuestSelectUiCamera();
		public T GetSceneComponent<T>(string sceneName);
	}
}
