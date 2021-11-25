using System.Collections;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;

namespace Gluon
{
	public class DefWarHouseUniqueCtrl : EnemyUniqueCtrl
	{
		private enum State
		{
			Ready,
			Wait,
			Raided,
			Save,
			Destroy,
			End
		}

		private State _state;

		private GameMasterUniqueCtrl _gm;

		private FieldTalkTriggerAccessPoint _accessPoint;

		private EnemyCharacter _bandit;

		private const int RAIDED_UIID = 7;

		private string resident_label;

		private const float RESIDENT_WAIT = 1f;

		public int idx
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

		public EnemyCharacter resident
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private bool hasShowRaided
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

		public override void Initialize()
		{
		}

		private void Update()
		{
		}

		private void UpdateReady()
		{
		}

		private void UpdateWait()
		{
		}

		private void UpdateRaided()
		{
		}

		public IEnumerator CoUpdateSave()
		{
			return null;
		}

		private void UpdateDestroy()
		{
		}

		private void SetBandit()
		{
		}
	}
}
