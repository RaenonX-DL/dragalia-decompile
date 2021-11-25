using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsUpthrust : ActionParts
	{
		private class Target
		{
			public List<int> partyIndex;
		}

		private readonly UpthrustData _partsData;

		private Target _targets;

		public List<EnemyCharacter> enemyObjects
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

		public ActionPartsUpthrust(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}
	}
}
