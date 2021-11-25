using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsIceRay : ActionParts
	{
		private readonly IceRayData _partsData;

		private SheruSheiruUniqueCtrl _ctrl;

		private Transform startTransform;

		private bool OverlapSphereChecked;

		private int layerMask;

		public ActionPartsIceRay(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		protected override void OnFinish()
		{
		}

		private void CalcStartTransfrom()
		{
		}
	}
}
