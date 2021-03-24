/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsMirageEA : ActionParts
	{
		// Fields
		private readonly MirageEAData _partsData;
		private EnemyCharacter.CallMinionInfo callMinionInfo;
		private int currentHp;
		private RunActionIntParameter setupHpParam;
	
		// Constructors
		public ActionPartsMirageEA(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
	}
}
