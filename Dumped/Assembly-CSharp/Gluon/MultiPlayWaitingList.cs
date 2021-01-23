/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MultiPlayWaitingList
	{
		// Fields
		private List<int> _actorIds;
	
		// Constructors
		public MultiPlayWaitingList();
	
		// Methods
		public void StartWaitForAllOthers();
		public void StartWaitFor(int actorId);
		public void Update();
		public void StopWaitFor(int actorId);
		public void Clear();
		public bool IsWaitingForActor(int actorId);
		public bool IsWaitingForAny();
		private bool IsRoomAvailable();
	}
}
