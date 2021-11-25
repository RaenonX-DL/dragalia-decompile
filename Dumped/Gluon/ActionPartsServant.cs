using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsServant : ActionParts
	{
		private readonly ServantData _partsData;

		public int popNum => default(int);

		public ActionPartsServant(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		private Vector3 CalcPopPos(int index)
		{
			return default(Vector3);
		}
	}
}
