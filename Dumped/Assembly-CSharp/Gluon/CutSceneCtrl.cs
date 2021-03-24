/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CutSceneCtrl : SingletonMonoBehaviour<Gluon.CutSceneCtrl>
	{
		// Fields
		private GameObject cutSceneObject;
		private CutSceneInitializer initializer;
		[CompilerGenerated]
		private bool _playing_k__BackingField;
		[CompilerGenerated]
		private string _cutSceneName_k__BackingField;
		private List<AudioPlayback> playbackList;
	
		// Properties
		public bool playing { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string cutSceneName { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CutSceneCtrl();
	
		// Methods
		protected override void Awake();
		protected override void OnDestroy();
		public void LoadCutScene(string cutSceneName);
		public bool CutSceneInitialized();
		public void ReleaseCutScene();
		public void PlayCut(string cutName);
		public bool IsPlaying();
		public void PlaySound(string cueName);
		public void StopSound();
	}
}
