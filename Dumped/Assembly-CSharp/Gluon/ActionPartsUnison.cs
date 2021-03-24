/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsUnison : ActionParts
	{
		// Fields
		private readonly UnisonData _partsData;
		private bool _isDone;
	
		// Nested types
		public enum UnisonType
		{
			OnSite = 0,
			SamePosition = 1,
			AreaAnchor = 2,
			DiagonalLine = 3
		}
	
		// Constructors
		public ActionPartsUnison(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		private void Procedure();
		private void OrderAction(EnemyCharacter chara, int actionId);
		private void SetPosition(EnemyAbilityProcUnison ability);
		private void SetPositionDiagonal(EnemyAbilityProcUnison ability, Transform primaryTransform, Transform secondaryTransform);
		private CharacterBase GetTarget();
	}
}
