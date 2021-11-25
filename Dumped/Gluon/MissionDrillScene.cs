using System.Collections;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class MissionDrillScene : SceneBase
	{
		private Canvas mainCanvas;

		private MissionDrillMainCanvas drillMainCanvas;

		private MissionDrillCompleteCanvas completeCanvas;

		private const string mainCanvasPath = "Prefabs/OutGame/MissionDrill/MissionDrillMainCanvas";

		private const string completeCanvasPath = "Prefabs/OutGame/MissionDrill/MissionDrillCompleteCanvas";

		private const string nhaamDrillVoiceGroup = "VO_CHR_100007_01_DRILL";

		private const string soundGroup_OUT_COMMONUSE = "OUT_COMMONUSE";

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private IEnumerator UnloadScene()
		{
			return null;
		}

		private void PlayCompleteDirection(DrillTalkElement talk)
		{
		}

		private void OnCompleteDirectionFinished()
		{
		}

		public override void StartExitAnimation()
		{
		}
	}
}
