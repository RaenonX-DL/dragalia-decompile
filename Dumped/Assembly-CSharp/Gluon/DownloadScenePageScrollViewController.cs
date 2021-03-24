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
	public class DownloadScenePageScrollViewController : MonoBehaviour
	{
		// Fields
		public PageViewBase pageViewBase;
		[SerializeField]
		public GameObject content;
		[SerializeField]
		public Sprite[] sprites;
		public Vector2[] offsets;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<int> __9__4_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Start_b__4_1(int pageIndex);
		}
	
		// Constructors
		public DownloadScenePageScrollViewController();
	
		// Methods
		private void Start();
		[CompilerGenerated]
		private void _Start_b__4_0(GameObject page, int index);
	}
}
