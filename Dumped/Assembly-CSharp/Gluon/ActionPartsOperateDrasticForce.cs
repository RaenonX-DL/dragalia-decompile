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
	public class ActionPartsOperateDrasticForce : ActionParts
	{
		// Fields
		private readonly OperateDrasticForceData _partsData;
	
		// Nested types
		public enum OperateType
		{
			Reset = 0,
			AddStack = 1,
			SubStack = 2
		}
	
		// Constructors
		public ActionPartsOperateDrasticForce(ActionParts resource);
	
		// Methods
		public override void Clear();
		protected override void OnStart();
		private void Proc();
	}
}
