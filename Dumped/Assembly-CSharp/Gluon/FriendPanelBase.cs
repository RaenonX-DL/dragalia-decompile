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
	public class FriendPanelBase : MonoBehaviour
	{
		// Fields
		public AnimationUIAutoPublisher[] enterPublishers;
		public AnimationUIAutoPublisher[] exitPublishers;
		private int animationDoneCount;
		private int animationToPlay;
		protected FriendScene scene;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0
		{
			// Fields
			public FriendPanelBase __4__this;
			public Action onFinished;
			public Action __9__0;
	
			// Constructors
			public __c__DisplayClass5_0();
	
			// Methods
			internal void _PlayEnterAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public FriendPanelBase __4__this;
			public Action onFinished;
			public Action __9__0;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _PlayExitAnimation_b__0();
		}
	
		// Constructors
		public FriendPanelBase();
	
		// Methods
		public void PlayEnterAnimation(Action onFinished);
		public virtual void PlayExitAnimation(Action onFinished);
		private void OnSingleAnimationDone(Action onAllFinished);
		public void OnMenuButtonPressed(FriendMenuButton button);
		[HideInInspector]
		public void OnMenuButtonPressed(FriendModel.PanelType type);
		public virtual void RefreshCurrentPage();
	}
}
