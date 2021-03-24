/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class ProximityReaction : Reaction
	{
		// Fields
		private HashSet<int> triggerHistory;
	
		// Constructors
		public ProximityReaction();
	
		// Methods
		private void OnTriggerEnter(Collider other);
		private void OnTriggerExit(Collider other);
	}
}
