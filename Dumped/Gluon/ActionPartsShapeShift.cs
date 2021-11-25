using System.Collections.Generic;
using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsShapeShift : ActionParts
	{
		private readonly ShapeShiftData _partsData;

		public List<EnemyCharacter> _subCharaList;

		public bool _isActionDone;

		public ActionPartsShapeShift(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		public void ShapeShift()
		{
		}
	}
}
