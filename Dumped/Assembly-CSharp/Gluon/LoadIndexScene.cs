/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NPF.NPFWrapper;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LoadIndexScene : MonoBehaviour
	{
		// Fields
		public static bool skipLogin;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<int> __9__3_0;
			public static UnityAction __9__3_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GotoOutGame_b__3_0(int diaCount);
			internal void _GotoOutGame_b__3_2();
		}
	
		// Constructors
		public LoadIndexScene();
	
		// Methods
		private void Start();
		private void Login();
		private void GotoOutGame();
		[CompilerGenerated]
		private void _Login_b__2_0();
		[CompilerGenerated]
		private void _GotoOutGame_b__3_1(NPFErrorParam error);
		[CompilerGenerated]
		private void _GotoOutGame_b__3_3();
	}
}
