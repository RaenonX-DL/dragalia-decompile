/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsDoll : ActionParts
	{
		// Fields
		private readonly DollData _partsData;
		private int[] _partyIdxs;
		private List<CharacterBase> _listTarget;
		private DollFieldUniqueCtrl _fieldCtrl;
	
		// Nested types
		public enum Mode
		{
			Execute = 0,
			Release = 1,
			Field = 2,
			FieldOff = 3
		}
	
		public enum TargetType
		{
			ActionTarget = 0,
			HandlingPlayer = 1,
			ExceptHandlingPlayerInSameParty = 2
		}
	
		// Constructors
		public ActionPartsDoll(ActionParts resource);
	
		// Methods
		public override void OnPostCreated(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		private void Proc();
		private void Execute();
		private void Release();
		private void Field(bool on = true);
		private void CreateCtrlDoll(CharacterBase target, CharacterSelector targetSelector);
		private void GetTargetOnExecute();
		private void ExcludeOutOfRangeTargets(List<CharacterBase> targets);
		[CompilerGenerated]
		private int _GetTargetOnExecute_b__15_0(int i);
	}
}
