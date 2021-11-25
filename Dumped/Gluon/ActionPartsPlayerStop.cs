using System.Runtime.CompilerServices;
using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsPlayerStop : ActionParts
	{
		public enum SwitchingType
		{
			OFF,
			ON
		}

		public enum StopTypes
		{
			TimeStop,
			ForCutIn,
			ForCutIn2
		}

		private readonly PlayerStopData _partsData;

		public float timeCount
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ActionPartsPlayerStop(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnFinish()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void Procedure(bool isSwitch)
		{
		}
	}
}
