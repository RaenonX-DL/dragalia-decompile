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
	public class ActionPartsShapeShift : ActionParts
	{
		// Fields
		private readonly ShapeShiftData _partsData;
		public List<EnemyCharacter> _subCharaList;
		public bool _isActionDone;
	
		// Constructors
		public ActionPartsShapeShift(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		public override void Clear();
		public void ShapeShift();
	}
}
