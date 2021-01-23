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
	public class ActionPartsOperateDungeonGimmick : ActionParts
	{
		// Fields
		private readonly OperateDungeonGimmickData _partsData;
		private bool _isDone;
		private List<CharacterBase> _listWarpTarget;
	
		// Nested types
		public enum GimmickType
		{
			Warp = 0
		}
	
		public enum OperateType
		{
			Activate = 0,
			Deactivate = 1,
			ForcingWarp = 2
		}
	
		public enum WarpTarget
		{
			Self = 0,
			AllUnit = 1,
			OnlyPassEntrance = 2
		}
	
		// Constructors
		public ActionPartsOperateDungeonGimmick(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		public override void Clear();
		private void Proc();
		private void ProcWarp();
		private void ListWarpTarget();
	}
}
