/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsB00250 : ActionParts
	{
		// Fields
		private readonly B00250Data _partsData;
		private State _state;
		private StoneSatelliteUniqueCtrl _ctrl;
		private List<CharacterBase> _attackChild;
		private RandomXorshift _random;
		private RunActionRandomParameter _runActionParam;
	
		// Nested types
		private enum State
		{
			init = 0,
			attack = 1,
			retreat = 2
		}
	
		// Constructors
		public ActionPartsB00250(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private bool UpdateAttack();
		private bool UpdateRetreat();
		private List<CharacterBase> GetTargetCharas();
	}
}
