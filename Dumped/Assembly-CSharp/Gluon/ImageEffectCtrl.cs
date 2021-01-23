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
	public abstract class ImageEffectCtrl : MonoBehaviour
	{
		// Fields
		protected CameraData mainCameraData;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<CameraData> __9__1_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Initialize_b__1_0(CameraData x);
		}
	
		// Constructors
		protected ImageEffectCtrl();
	
		// Methods
		public virtual void Initialize(CameraGroupCtrl cameraGroupCtrl);
	}
}
