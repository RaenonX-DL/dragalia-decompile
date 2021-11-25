using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class CtrlOverdrive : MonoBehaviour
	{
		public enum Phase
		{
			Initilize,
			Ordinary,
			Overdrive,
			Break,
			End
		}

		private Phase _phase;

		private EnemyCharacter _owner;

		[SerializeField]
		private bool _canSetPoint;

		[SerializeField]
		private float _limit;

		[SerializeField]
		private float _point;

		[SerializeField]
		private float _scale;

		private float _odSpeed;

		private static CharacterSpecialState _tmpChangeBossState;

		private bool isOverdriveReserved;

		private bool isBreakReserved;

		private const int HIDE_EFF_TRIG = 13;

		public Phase phase
		{
			get
			{
				return default(Phase);
			}
			private set
			{
			}
		}

		public float baseOD
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float baseBreak
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool canSetPoint
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float limit
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float point
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float rate => default(float);

		public float scale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool isOnRageAction
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

		public int playedLoopEffTrg
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

		public bool isShowingLoopEff
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

		public void Setup(EnemyCharacter owner, float baseOD_, float baseBreak_)
		{
		}

		public void Reset()
		{
		}

		public void OnUpdate()
		{
		}

		private void UpdateOrdinary()
		{
		}

		private void OnOverdrive()
		{
		}

		private void UpdateOverdrive()
		{
		}

		private void OnBreak([Optional] CharacterBase attacker)
		{
		}

		private void UpdateBreak()
		{
		}

		private void OnOrdinary()
		{
		}

		public void OnDamaged(float dmg, [Optional] CharacterBase attacker)
		{
		}

		public void OnDamagedRate(float percentage)
		{
		}

		public void OnEnd()
		{
		}

		public bool CheckOverdrive()
		{
			return default(bool);
		}

		public void CheckBreak([Optional] CharacterBase attacker)
		{
		}

		public void OnOverdriveReceived()
		{
		}

		public void OnBreakReceived()
		{
		}

		private void SendOverdrive()
		{
		}

		private void SendBreak()
		{
		}

		private bool CanInterrupt()
		{
			return default(bool);
		}

		public void SetOverdrive(bool canReserve = false)
		{
		}

		public void HideEff()
		{
		}

		public void RestoreEffect()
		{
		}

		private void OnRateChanged()
		{
		}
	}
}
