using Gluon.CharacterUniqueGimmick;
using Gluon.Event;

namespace Gluon
{
	public class LastGaspUniqueCtrl : EnemyUniqueCtrl
	{
		private int _receivedFatalAttackCount;

		private int _actionId;

		private int _takedownActionId;

		private bool checkLastGaspOver;

		public bool isLastGaspOver;

		private bool holyLightEnemySet;

		private bool _isActionReserved;

		private bool _isTakedownActionReserved;

		public bool active => default(bool);

		private CtrlHolyLight holyLight => null;

		public override void Initialize()
		{
		}

		public override void FastUpdate()
		{
		}

		public void Setup(int actionId, int takedownActionId)
		{
		}

		public bool OnFatalAttacked(bool isQuestSkill, CharacterBase attacker)
		{
			return default(bool);
		}

		public void OnTakeDown()
		{
		}

		public override void OnChangeState(CharacterState state)
		{
		}
	}
}
