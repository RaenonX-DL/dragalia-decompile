using System.Collections.Generic;
using Gluon.ActionData;
using Gluon.Event;

namespace Gluon.Bullet
{
	public class ActionPartsSabnackDarkTorrent : ActionParts
	{
		private List<CharacterBase> _listTarget;

		private RandomXorshift _random;

		private RunActionRandomParameter _runActionParam;

		private readonly SabnackDarkTorrentData _partsData;

		public ActionPartsSabnackDarkTorrent(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		private void SetUp(CondensBulletObject bullet, int idx)
		{
		}

		private void SetMultiPlayerTarget()
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}
	}
}
