/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DungeonBgArtistBgModelGroup : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private DungeonBgModelProduction.BgModelGroup bgModelGroup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__1 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DungeonBgArtistBgModelGroup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__1(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DungeonBgArtistBgModelGroup();
	
		// Methods
		[IteratorStateMachine]
		public IEnumerator Start();
	}
}
