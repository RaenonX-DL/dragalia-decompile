/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class WaitForSpineTrackEntryEnd : IEnumerator
	{
		// Fields
		private bool m_WasFired;
	
		// Properties
		object IEnumerator.Current { get; }
	
		// Constructors
		public WaitForSpineTrackEntryEnd(TrackEntry trackEntry);
	
		// Methods
		private void HandleEnd(TrackEntry trackEntry);
		private void SafeSubscribe(TrackEntry trackEntry);
		public WaitForSpineTrackEntryEnd NowWaitFor(TrackEntry trackEntry);
		bool IEnumerator.MoveNext();
		void IEnumerator.Reset();
	}
}
