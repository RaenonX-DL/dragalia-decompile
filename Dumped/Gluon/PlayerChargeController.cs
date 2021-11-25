using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class PlayerChargeController
	{
		private CharacterBase owner;

		private float afterChargeCompleteSec;

		private const float chargeCompleteWaitSecForAI = 0.1f;

		public bool isCharging
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isExceed
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int chargeLv
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isEnableBurstAttack => default(bool);

		public Vector3? impactPos
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float GetChargeCompleteWaitSecForAI(CharacterBase owner)
		{
			return default(float);
		}

		public PlayerChargeController(CharacterBase owner)
		{
		}

		public int GetChargeMarkerActionId()
		{
			return default(int);
		}

		public void Startup()
		{
		}

		public void Update()
		{
		}

		public void Finish(bool isAttack, bool isGuard = false)
		{
		}

		public void ForceComplete()
		{
		}

		private bool IsAllyTarget()
		{
			return default(bool);
		}

		private CharacterBase SearchNearestCharacter()
		{
			return null;
		}

		public bool IsChargeComplete(float waitSec = 0f, int stopChargeLv = 0)
		{
			return default(bool);
		}

		private void OnChargeComplete()
		{
		}
	}
}
