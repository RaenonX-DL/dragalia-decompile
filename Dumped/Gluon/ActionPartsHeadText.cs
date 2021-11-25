using Gluon.ActionData;
using Gluon.Event;

namespace Gluon
{
	public class ActionPartsHeadText : ActionParts
	{
		private readonly HeadTextData _partsData;

		private static readonly string[] textIdNames;

		private int _countOfActionStart;

		private RunActionIntParameter _runActionParam;

		public ActionPartsHeadText(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		public override RunActionParameterBase CreateRunActionParameter()
		{
			return null;
		}

		public override void SetRunActionParameter(RunActionParameterBase param)
		{
		}

		protected override void OnStart()
		{
		}
	}
}
