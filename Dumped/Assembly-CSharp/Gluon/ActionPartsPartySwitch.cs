﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsPartySwitch : ActionParts
	{
		// Fields
		private readonly PartySwitchData _partsData;
	
		// Constructors
		public ActionPartsPartySwitch(ActionParts resource);
	
		// Methods
		public override void Clear();
		protected override void OnStart();
		protected override void OnFinish();
		private void Procedure();
		public bool IsJustTimeAction();
		[CompilerGenerated]
		private void _Procedure_b__5_0();
	}
}
