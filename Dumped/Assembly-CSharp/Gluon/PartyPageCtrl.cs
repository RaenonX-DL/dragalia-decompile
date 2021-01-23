/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyPageCtrl : MonoBehaviour
	{
		// Fields
		public PartyUICanvas partyCanvas;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__1_0;
			public static Action<ErrorType, int> __9__1_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SetContent_b__1_0();
			internal void _SetContent_b__1_1(ErrorType error, int resultCode);
		}
	
		// Constructors
		public PartyPageCtrl();
	
		// Methods
		public void SetContent(int index, bool isAutoSelect = false);
	}
}
