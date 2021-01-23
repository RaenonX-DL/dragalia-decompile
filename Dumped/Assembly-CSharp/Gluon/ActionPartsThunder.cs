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
	public class ActionPartsThunder : ActionParts
	{
		// Fields
		private readonly ThunderData _partsData;
		private State _state;
		private const int THUNDER_MAX = 4;
		private List<CommonObjectStatus> _targetList;
		private ChargeMarker[] _markers;
		private float _elapsed;
	
		// Nested types
		private enum State
		{
			MarkerSet = 0,
			MarkerRun = 1,
			Fire = 2,
			DamageField = 3,
			End = 4
		}
	
		// Constructors
		public ActionPartsThunder(ActionParts resource);
	
		// Methods
		protected override void OnFinish();
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void State_MarkerSet();
		private void State_MarkerRun(float delta);
		private void State_Fire();
		private void State_DamageField();
		private void State_End();
		public override void OnCollided(GameObject target, bool isPropagation);
		private void PlayEffect(GameObject target);
		private void CreateHitAttribute(ref CollisionHitAttribute hitAttr);
	}
}
