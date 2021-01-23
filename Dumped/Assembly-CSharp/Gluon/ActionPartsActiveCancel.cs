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
	public class ActionPartsActiveCancel : ActionParts
	{
		// Fields
		private readonly ActiveCancelData _partsData;
		private bool isStart;
	
		// Nested types
		public enum ActionType
		{
			None = 0,
			BurstAttack = 1
		}
	
		// Constructors
		public ActionPartsActiveCancel(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void AnalyzeActionType();
	}
}
