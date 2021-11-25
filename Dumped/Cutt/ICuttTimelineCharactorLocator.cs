using UnityEngine;

namespace Cutt
{
	public interface ICuttTimelineCharactorLocator
	{
		bool cuttCharaVisible { get; set; }

		CuttCharaPosition cuttCharaStandingPosition { get; set; }

		Vector3 cuttCharaInitialPosition { get; set; }

		Vector3 cuttCharaHeadPosition { get; }

		Vector3 cuttCharaChestPosition { get; }

		Vector3 cuttCharaFootPosition { get; }

		Animation cuttAnimationComponent { get; }

		Transform cuttRootTransform { get; }

		int cuttCharaHeightLevel { get; set; }

		float cuttCharaHeightValue { get; }

		float cuttCharaHeightRatio { get; set; }
	}
}
