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
	public class ActionPartsTerminateOtherParts : ActionParts
	{
		// Fields
		private readonly TerminateOtherData _partsData;
		private ActionParts.PartsData.ConditionData partConditionData;
	
		// Constructors
		public ActionPartsTerminateOtherParts(ActionParts resource);
	
		// Methods
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		[CompilerGenerated]
		private bool _OnUpdate_b__5_0(ActionParts x);
	}
}
