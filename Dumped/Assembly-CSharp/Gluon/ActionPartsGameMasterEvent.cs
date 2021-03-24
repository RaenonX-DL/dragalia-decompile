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
	public class ActionPartsGameMasterEvent : ActionParts
	{
		// Fields
		private readonly GameMasterEventData _partsData;
		private GameMasterUniqueCtrl _gm;
		private int _nextEvent;
		private string _egLabel;
		private RunActionGameMasterEvent tmpSetupParam;
		private bool _isDone;
	
		// Constructors
		public ActionPartsGameMasterEvent(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void ProcCommand();
		private void ProcTurn();
		private void ProcCompleteTurn();
		private void ProcSudden();
		private void ProcBandit();
	}
}
