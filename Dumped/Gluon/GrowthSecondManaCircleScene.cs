using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gluon
{
	public class GrowthSecondManaCircleScene : GrowthManaCircleScene
	{
		public GrowthSecondManaCircleObjectsController secondObjectsController;

		public GrowthSecondManaCircleModel secondModel;

		private List<GrowthSecondManaCircleManaPieceObject> selectedTouchPointList;

		public bool isPlayFirstEnterEffect;

		private static GrowthAwakeResultPop.BeforeData beforeUsePlatinumCrystalData;

		private int autoReleaseStartIndex;

		protected override IEnumerator Start()
		{
			return null;
		}

		protected override IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		public void FirstEnterEffectComplete()
		{
		}

		protected override void Update()
		{
		}

		protected override void LateUpdateTask()
		{
		}

		public override void Reset()
		{
		}

		public void OnTouchPointClicked(GrowthSecondManaCircleManaPieceObject touchedPoint)
		{
		}

		protected void UpdatePointDesc(int centerTouchPointIndex)
		{
		}

		private void DoReleasePoint()
		{
		}

		private IEnumerator PlayReleasePointEffect(GrowthSecondManaCircleManaPieceObject touchedPoint)
		{
			return null;
		}

		public void PlayFirstEnterEffectAsync()
		{
		}

		public void ResetDescCanvasParam()
		{
		}

		public override void OnAutotButtonPressed()
		{
		}

		protected override void SendAutoReleaseData(List<GrowthManaCircleManaPieceData> pieceDataList, bool isGrowMaterial)
		{
		}

		protected override void DoAutoReleasePoint()
		{
		}

		private void PlayAutoReleaseEffect(List<GrowthSecondManaCircleManaPieceObject> pointList, TouchGuardObject touchGuardObject)
		{
		}

		private Task PlayAutoReleaseEffectTask(List<GrowthSecondManaCircleManaPieceObject> pointList, bool isUsePlatinum)
		{
			return null;
		}

		protected override void UsePlatinumCrystalResultAction(GrowthAwakeResultPop.BeforeData beforeData)
		{
		}

		private void PlayUsePlatinumCrystalDirection(GrowthAwakeResultPop.BeforeData beforeData, int startIndex, List<GrowthSecondManaCircleManaPieceObject> pointList)
		{
		}
	}
}
