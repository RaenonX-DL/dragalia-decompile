using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsOperateCutt : ActionParts
	{
		public enum OperateType
		{
			AbortCutt,
			PlayCutt
		}

		private readonly OperateCuttData _partsData;

		private bool _hasFinishProc;

		public ActionPartsOperateCutt(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void ProcFinish()
		{
		}
	}
}
