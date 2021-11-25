using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsTeleport : ActionParts
	{
		private const float FALL_TIME = 0.25f;

		private float elapsed;

		private readonly TeleportData _partsData;

		private RandomXorshift _random;

		private RunActionRandomParameter _runActionRandomParam;

		private Vector3 _syncTeleportPos;

		private Quaternion _syncTeleportRot;

		private RunActionPosRotParameter _runActionPosRotParam;

		public ActionPartsTeleport(Gluon.ActionData.ActionParts resource)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		private Vector3 GetTeleportPos()
		{
			return default(Vector3);
		}

		private Quaternion GetTeleportRot()
		{
			return default(Quaternion);
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private Vector3 CalcTeleportPosition_Oriented()
		{
			return default(Vector3);
		}

		private Vector3 CalcTeleportPosition_Random()
		{
			return default(Vector3);
		}

		private Vector3 CalcTeleportPosition_Fixed()
		{
			return default(Vector3);
		}

		private Vector3 CalcTeleportPosition_Veering()
		{
			return default(Vector3);
		}

		private float CalcRadius()
		{
			return default(float);
		}

		private bool IsUseSyncTargetPos()
		{
			return default(bool);
		}

		private CharacterBase TargetCorrection(CharacterBase target)
		{
			return null;
		}
	}
}
