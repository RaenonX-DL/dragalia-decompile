using UnityEngine;

namespace Cutt
{
	public interface ICuttTimelineMSQTarget
	{
		Animation cuttMSQAnimation { get; }

		bool cuttMSQControlled { get; set; }

		AnimationState cuttMSQCurrentAnimState { get; set; }

		float cuttMSQCurrentAnimStartTime { get; set; }
	}
}
