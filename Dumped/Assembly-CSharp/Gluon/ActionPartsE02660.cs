/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsE02660 : ActionParts
	{
		// Fields
		private int _actionId;
		private short _actionPartsIndex;
	
		// Constructors
		public ActionPartsE02660(ActionParts resource);
	
		// Methods
		public void SetActionPartsAddress(int actionId, int index);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
