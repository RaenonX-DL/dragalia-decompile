/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AttachObject
	{
		// Fields
		[CompilerGenerated]
		private GameObject _go_k__BackingField;
		private Animator animator;
		private RuntimeAnimatorController savedRuntimeAnimatorController;
	
		// Properties
		public GameObject go { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public AttachObject(GameObject obj);
	
		// Methods
		public void SetAnimation(string motionPath);
		private bool GetAnimatorComponent();
		public void SaveCurrentAnimation();
		public void LoadSavedAnimation();
		public void Attach(Transform attachNode);
		public void PlayAnimation(string stateName);
		public void PlayBlendAnimation(string stateName, float blendDuration, bool checkSame);
		public bool IsAnimationState(string stateName);
		public bool IsNextAnimationState(string stateName);
		public void SetVisible(bool visible);
		public void SetLightProbeAnchor(Transform lightProbeAnchorNode);
	}
}
