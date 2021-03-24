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
	public class AlbumPlayRecordScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Camera mainCamera;
		private AlbumPlayRecordCanvas playRecordCanvas;
		private string charaVoiceGroupName;
	
		// Constructors
		public AlbumPlayRecordScene();
	
		// Methods
		private void Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		private void BackButtonPressed();
	}
}
