using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

namespace Gluon
{
	public class DmodeSkipFloorScene : SceneBase
	{
		[SerializeField]
		[Header("BackGround")]
		private Canvas bgCanvas;

		[SerializeField]
		private Camera uiCamera;

		[SerializeField]
		[Header("Flash")]
		private Camera flashCamera;

		private int selectedCharaId;

		private int selectedEditSkill1CharaId;

		private int selectedEditSkill2CharaId;

		private DmodeServitorType selectedServitorType;

		private int destinationFloorNum;

		private DmodeSkipFloorAnimationPlayer skipFloorAnimationPlayer;

		private BaseCanvasContents baseCanvasContents;

		private Task requestDungeonStartTask;

		private static readonly string skipFloorAnimationPlayerPath;

		private static readonly string bgContentsPath;

		private void Start()
		{
		}

		private void OnPrevSceneExitDone()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		public void RequestApi()
		{
		}

		private void OnEnterAnimation()
		{
		}

		private void SetupFlashCamera()
		{
		}

		private Task RequestDungeonFloorSkip()
		{
			return null;
		}

		private IEnumerator GoToIngame()
		{
			return null;
		}
	}
}
