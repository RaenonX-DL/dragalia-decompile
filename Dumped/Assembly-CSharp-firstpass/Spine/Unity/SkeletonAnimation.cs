/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[AddComponentMenu]
	[ExecuteInEditMode]
	[HelpURL]
	public class SkeletonAnimation : SkeletonRenderer, ISkeletonAnimation, IAnimationStateComponent
	{
		// Fields
		public Spine.AnimationState state;
		[CompilerGenerated]
		private UpdateBonesDelegate _UpdateLocal;
		[CompilerGenerated]
		private UpdateBonesDelegate _UpdateWorld;
		[CompilerGenerated]
		private UpdateBonesDelegate _UpdateComplete;
		[SerializeField]
		[SpineAnimation]
		private string _animationName;
		public bool loop;
		public float timeScale;
	
		// Properties
		public Spine.AnimationState AnimationState { get; }
		public string AnimationName { get; set; }
	
		// Events
		protected event UpdateBonesDelegate _UpdateLocal {
			add;
			remove;
		}
		protected event UpdateBonesDelegate _UpdateWorld {
			add;
			remove;
		}
		protected event UpdateBonesDelegate _UpdateComplete {
			add;
			remove;
		}
		public event UpdateBonesDelegate UpdateLocal {
			add;
			remove;
		}
		public event UpdateBonesDelegate UpdateWorld {
			add;
			remove;
		}
		public event UpdateBonesDelegate UpdateComplete {
			add;
			remove;
		}
	
		// Constructors
		public SkeletonAnimation();
	
		// Methods
		private TrackEntry TrySetAnimation(string animationName, bool animationLoop);
		public static SkeletonAnimation AddToGameObject(GameObject gameObject, SkeletonDataAsset skeletonDataAsset);
		public static SkeletonAnimation NewSkeletonAnimationGameObject(SkeletonDataAsset skeletonDataAsset);
		public override void ClearState();
		public override void Initialize(bool overwrite);
		private void Update();
		public void Update(float deltaTime);
	}
}
