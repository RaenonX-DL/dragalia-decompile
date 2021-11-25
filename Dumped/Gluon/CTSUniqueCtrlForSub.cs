using System.Collections;

namespace Gluon
{
	public class CTSUniqueCtrlForSub : EnemyUniqueCtrl
	{
		public CTSUniqueCtrl.ShapeType _shapeType;

		private bool _reservedExplosion;

		private bool _isCancelDragon;

		private CollisionHitAttribute _hitAttribute;

		private string _effName;

		private int _effTrig;

		private string _seName;

		private const string CHARAEFF_CONTROL_KEY = "cts_sub";

		private const int CHARAEFF_DEAD_TRIGGER = 1;

		private bool _isExploded;

		public override void Initialize()
		{
		}

		public void Setup(CTSUniqueCtrl.ShapeType shape, string hitAttrLabel, float radius, bool isCancelDragon)
		{
		}

		public void SetupEffect(string effName, int trigger, string seName)
		{
		}

		private void Update()
		{
		}

		public bool OnFatal(bool isQuestSkill, CharacterBase attacker)
		{
			return default(bool);
		}

		public void OnDeadEnemy(EnemyCharacter deadEnemy)
		{
		}

		public void SetIncorrect()
		{
		}

		public void OnReceiveAnswer(bool correctAnswer)
		{
		}

		public IEnumerator CoExplosion()
		{
			return null;
		}
	}
}
