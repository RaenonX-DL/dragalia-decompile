/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionMoveBase : ActionInterval
	{
		// Fields
		protected int _property;
		protected int prevLayer;
	
		// Nested types
		public enum PropertyType
		{
			PushOut = 1,
			AutoDash = 2,
			ForcedMove = 4,
			ChargeMove = 8,
			ThroughChara = 16
		}
	
		// Constructors
		public ActionMoveBase();
	
		// Methods
		protected bool IsProperty(PropertyType type);
		protected void SetPrevLayer();
		protected void ResetLayer();
	}
}
