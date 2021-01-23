/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class WaitForSpineAnimationComplete : IEnumerator
	{
		// Fields
		private bool m_WasFired;
	
		// Properties
		object IEnumerator.Current { get; }
	
		// Constructors
		public WaitForSpineAnimationComplete(TrackEntry trackEntry);
	
		// Methods
		private void HandleComplete(TrackEntry trackEntry);
		private void SafeSubscribe(TrackEntry trackEntry);
		public WaitForSpineAnimationComplete NowWaitFor(TrackEntry trackEntry);
		bool IEnumerator.MoveNext();
		void IEnumerator.Reset();
	}
}
