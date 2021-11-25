using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class MonsterPreviewScene : SceneBase
	{
		public GameObject bgPanel;

		public Canvas mainCanvas;

		public GameObject monsterNode;

		public GameObject mainCamera;

		private int showMonsterId;

		[SerializeField]
		private MonsterLibraryCamera previewCameras;

		private Vector3 cameraPositionOffset;

		private Animator monsterAnimator;

		private bool playAnimationFlg;

		private int actionLoopIndex;

		private string[] animationStateNames;

		private void Start()
		{
		}

		private void BackButtonPressed()
		{
		}

		private void SetMonsterModel()
		{
		}

		private void SetCameraProperty()
		{
		}

		private bool SetupMonsterMasterData()
		{
			return default(bool);
		}

		public void ActionButtonPressed()
		{
		}

		private IEnumerator playAnimationDelay()
		{
			return null;
		}
	}
}
