using System.Collections;

namespace Gluon
{
	public class EventTopPageFEH : EventTopPageBase
	{
		public override void OnQuestButtonTouched()
		{
		}

		protected override IEnumerator WaitForStatusInfoInitilizing(AnimationPattern pattern)
		{
			return null;
		}
	}
}
