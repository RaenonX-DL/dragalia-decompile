/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortDragonViewController : MonoBehaviour
	{
		// Fields
		public FortScene fortScene;
		public float duration;
		public float distance;
		[SerializeField]
		private float fadeOutStartRatio;
		[SerializeField]
		private float fadeOutDuration;
		private Tweener moveToDragonTweener;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__7_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnDragonTapped_b__7_2();
		}
	
		// Constructors
		public FortDragonViewController();
	
		// Methods
		public void EnableToTap(bool value);
		public void OnDragonTapped();
		[CompilerGenerated]
		private void _OnDragonTapped_b__7_0();
		[CompilerGenerated]
		private void _OnDragonTapped_b__7_1();
	}
}
