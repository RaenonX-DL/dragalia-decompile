using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;

namespace Gluon
{
	public class CtrlBoundaryAction : FastUpdateMonoBehaviour
	{
		public class BoundaryData
		{
			public int _id;

			public int _hp;

			public int _actionId;

			public EnemyBoundaryCondition _condition;

			public bool _done;
		}

		private EnemyCharacter _owner;

		public List<BoundaryData> datas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public BoundaryData activeData
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

		public bool isActiveAction => default(bool);

		public bool isFinished
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

		public void Initialize(EnemyCharacter owner)
		{
		}

		public void Reset()
		{
		}

		public static bool IsExistBoundaryAction(EnemyCharacter owner)
		{
			return default(bool);
		}

		private void CreateList()
		{
		}

		public bool Check()
		{
			return default(bool);
		}

		public bool OnFatal(bool isQuestSkill, CharacterBase attacker)
		{
			return default(bool);
		}

		public void Execute()
		{
		}

		private bool IsSuperExtraAction()
		{
			return default(bool);
		}

		public void OnFinishAction()
		{
		}

		public void SetCondition(bool onoff)
		{
		}

		public void ActivateBoundaryData(int boundaryDataId)
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
