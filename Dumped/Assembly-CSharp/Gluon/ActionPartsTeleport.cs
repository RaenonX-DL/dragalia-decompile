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
	public class ActionPartsTeleport : ActionParts
	{
		// Fields
		private const float FALL_TIME = 0.25f;
		private float elapsed;
		private readonly TeleportData _partsData;
		private RandomXorshift _random;
		private RunActionRandomParameter _runActionRandomParam;
		private Vector3 _syncTeleportPos;
		private Quaternion _syncTeleportRot;
		private RunActionPosRotParameter _runActionPosRotParam;
	
		// Constructors
		public ActionPartsTeleport(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		private Vector3 GetTeleportPos();
		private Quaternion GetTeleportRot();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private Vector3 CalcTeleportPosition_Oriented();
		private Vector3 CalcTeleportPosition_Random();
		private Vector3 CalcTeleportPosition_Fixed();
		private Vector3 CalcTeleportPosition_Veering();
		private float CalcRadius();
		private bool IsUseSyncTargetPos();
		private CharacterBase TargetCorrection(CharacterBase target);
	}
}
