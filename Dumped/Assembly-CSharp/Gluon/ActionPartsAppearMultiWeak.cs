/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsAppearMultiWeak : ActionParts
	{
		// Fields
		private readonly AppearMultiWeakData _partsData;
		private bool _isDone;
		private List<Vector3> _tmpPopPositionList;
	
		// Constructors
		public ActionPartsAppearMultiWeak(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override void Clear();
		protected override void OnStart();
		protected void PopWeak();
		private Vector3 CalcPopPosition(Vector3 offset);
		private void TargetCorrection(ref CommonObjectStatus target);
	}
}
