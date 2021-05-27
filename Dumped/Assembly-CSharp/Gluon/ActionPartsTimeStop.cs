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
	public class ActionPartsTimeStop : ActionParts
	{
		// Fields
		private readonly TimeStopData _partsData;
	
		// Nested types
		public enum SwitchingType
		{
			OFF = 0,
			ON = 1
		}
	
		// Constructors
		public ActionPartsTimeStop(ActionParts resource);
	
		// Methods
		public override void Clear();
		protected override void OnStart();
		private void Procedure();
	}
}
