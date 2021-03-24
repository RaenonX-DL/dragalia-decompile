/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsCallMinion : ActionParts
	{
		// Fields
		private readonly CallMinionData _partsData;
		private EnemyCharacter.CallMinionInfo callMinionInfo;
		private int taskId;
		private RunActionIntParameter taskIdParam;
	
		// Constructors
		public ActionPartsCallMinion(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		private Vector3 CalcPopPos(ref Transform transBase);
	}
}
