/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsSyncCharacterPosition : ActionParts
	{
		// Fields
		private readonly SyncCharacterPositionData _partsData;
	
		// Constructors
		public ActionPartsSyncCharacterPosition(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		private void SyncPlayerPosition();
	}
}
