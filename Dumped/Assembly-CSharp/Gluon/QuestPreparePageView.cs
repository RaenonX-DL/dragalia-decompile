/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestPreparePageView : MonoBehaviour
	{
		// Fields
		public QuestPrepareCanvas prepareCanvas;
		public GameObject charaButtonParent;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__2_0;
			public static Action<ErrorType, int> __9__2_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetContent_b__2_0();
			internal void _SetContent_b__2_1(ErrorType error, int resultCode);
		}
	
		// Constructors
		public QuestPreparePageView();
	
		// Methods
		public void SetContent(int index, bool isAutoSelect = false);
	}
}
