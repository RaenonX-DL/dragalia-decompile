using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsAppearMultiWeak : ActionParts
	{
		private readonly AppearMultiWeakData _partsData;

		private List<Vector3> _tmpPopPositionList;

		public ActionPartsAppearMultiWeak(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected void PopWeak()
		{
		}

		private Vector3 CalcPopPosition(Vector3 offset)
		{
			return default(Vector3);
		}

		private void TargetCorrection(ref CommonObjectStatus target)
		{
		}
	}
}
