/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimationUICanvasManager : SingletonInBaseMonoBehaviour<Gluon.AnimationUICanvasManager>
	{
		// Fields
		private List<AnimationUICanvas> animationUICanvases;
	
		// Constructors
		public AnimationUICanvasManager();
	
		// Methods
		public void Register(AnimationUICanvas item);
		public void UnRegister(AnimationUICanvas item);
		public void Clear();
		public void StartEnterAnimation();
		public void StartExitAnimation(bool bClear = true);
		public bool CheckRegisteredCanvas(AnimationUICanvas item);
	}
}
