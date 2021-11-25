using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class MiasmaUniqueCtrl : EnemyUniqueCtrl
	{
		public enum State
		{
			Idle,
			Start,
			Run,
			BoostBegin,
			Boosting,
			BoostEnd,
			Wait,
			Abort
		}

		private float _timer;

		public const float POINT_MAX = 10000f;

		[SerializeField]
		private float _point;

		private float _addPointSpeed;

		private float _waitTimeForAuto;

		private int _actionId;

		private string _effName;

		private const string effKey = "aura_miasma";

		private string _beginSe;

		private string _endSe;

		public State state
		{
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float point
		{
			get
			{
				return default(float);
			}
			private set
			{
			}
		}

		private bool IsPointSync
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

		private float PointSyncDelayTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Reset()
		{
		}

		public override void Initialize()
		{
		}

		private void Update()
		{
		}

		private void ProcStart()
		{
		}

		private void ProcRun()
		{
		}

		private void ProcBoostBegin()
		{
		}

		private void ProcBoosting()
		{
		}

		private void ProcBoostEnd()
		{
		}

		private void ProcAbort()
		{
		}

		public void OnAbort()
		{
		}

		public void Setup(int actionId, float addPointSpeed, float waitTimeForAuto)
		{
		}

		public void SetupEffect(string effName, string beginSe, string endSe)
		{
		}

		public void SetPoint(float value)
		{
		}

		public void AddPoint(float value, bool fromEventSkill = false)
		{
		}

		public void OnReceiveMiasmaEvent(CharacterSpecialState state)
		{
		}

		public void SendMiasmaGaugeChangeEvent(float value)
		{
		}

		public void SendMiasmaGaugeChangeRequestEvent(float addValue)
		{
		}
	}
}
