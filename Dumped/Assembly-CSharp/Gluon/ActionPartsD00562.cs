/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsD00562 : ActionParts
	{
		// Fields
		private readonly D00562Data _partsData;
		private List<int> _taskIds;
		private int _actionId;
		private int _actionPartsIndex;
	
		// Constructors
		public ActionPartsD00562(ActionParts resource);
	
		// Methods
		public void SetActionPartsAddress(int actionId, int index);
		protected override void OnStart();
		protected override void OnFinish();
		protected override bool OnUpdate(float delta);
	}
}
