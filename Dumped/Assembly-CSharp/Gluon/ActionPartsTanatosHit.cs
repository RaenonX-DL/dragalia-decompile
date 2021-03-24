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
	public class ActionPartsTanatosHit : ActionPartsHit
	{
		// Fields
		private readonly TanatosHitData _partsData;
		private bool _hitFlag;
		private int _difficultyIndex;
	
		// Constructors
		public ActionPartsTanatosHit(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		public override void OnCollided(GameObject target, bool isPropagation);
	}
}
