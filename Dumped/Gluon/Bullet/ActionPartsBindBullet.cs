using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Bullet
{
	public class ActionPartsBindBullet : ActionParts
	{
		public enum GenerationPoint
		{
			AreaAnchor,
			Target,
			Owner
		}

		private readonly BindBulletData _partsData;

		private long bindEventId;

		private RunActionLongParameter bindEventIdParam;

		public ActionPartsBindBullet(Gluon.ActionData.ActionParts resource)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		private void GenerateBullet()
		{
		}

		private void CalcGenerate(GenerationPoint generation, Vector3 offset, ref Vector3 position, ref Quaternion rotation)
		{
		}

		private bool Misfire()
		{
			return default(bool);
		}
	}
}
