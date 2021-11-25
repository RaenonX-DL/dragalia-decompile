using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class TutorialSummonResultScene : MonoBehaviour, IPlaySummonInterface
	{
		public enum TutorialSummonPlayPhase
		{
			None,
			Loading,
			ReadFinish,
			DropItem,
			DropItemEnd,
			ToResult
		}

		private enum ItemFallKind
		{
			Normal,
			Ssr
		}

		[SerializeField]
		private GameObject stage3dNode;

		[SerializeField]
		private GameObject postEffectCameraGO;

		[SerializeField]
		private Transform camera3DParent;

		public Camera mainCamera;

		private List<SummonResultItemData> resultItems;

		private FlashPlayer[] itemFallFlashPlayers;

		private Vector3 resultFlashCameraInitPosition;

		private TutorialSummonPlayPhase playPhase;

		private Camera storedMainCamera;

		private Coroutine _execCoroutine;

		private TutorialSummonResultPage parentPage;

		private const float originalCameraFov = 60f;

		[HideInInspector]
		public Transform node3d;

		private static readonly string SE_ITEM_FALL;

		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;

		[HideInInspector]
		public RenderTexture charaWeaponRenderTexture;

		[HideInInspector]
		public CameraClearFlags oldFlashCameraClearFlags;

		private static readonly Vector2[] iconPosition1;

		private static readonly Vector2[] iconPosition2;

		private static readonly Vector2[] iconPosition3;

		private static readonly Vector2[] iconPosition4;

		private static readonly Vector2[] iconPosition5;

		private static readonly Vector2[] iconPosition6;

		private static readonly Vector2[] iconPosition7;

		private static readonly Vector2[] iconPosition8;

		private static readonly Vector2[] iconPosition9;

		public static readonly Vector2[] iconPosition10;

		public static readonly Vector2[][] iconPositions;

		public Camera OverlayUICamera => null;

		Transform IPlaySummonInterface.node3d => null;

		FlashPlayerManager IPlaySummonInterface.flashPlayerManager => null;

		RenderTexture IPlaySummonInterface.charaWeaponRenderTexture => null;

		CameraClearFlags IPlaySummonInterface.oldFlashCameraClearFlags
		{
			get
			{
				return default(CameraClearFlags);
			}
			set
			{
			}
		}

		public bool IsBoxSummon => default(bool);

		public void Start()
		{
		}

		public void OnDestroy()
		{
		}

		public void Init()
		{
		}

		public void StartLoading(TutorialSummonResultPage page, bool show3DModel, Action loadEndCallback)
		{
		}

		private IEnumerator LoadResource(Action loadEndCallback)
		{
			return null;
		}

		public IEnumerator LoadSummonBgScene()
		{
			return null;
		}

		private void OnAllAsyncLoadPrepared()
		{
		}

		private void ResetCameraPositionInStage()
		{
		}

		void IPlaySummonInterface.StartWhiteOutEffect(float inTime, float outTime)
		{
		}

		public void OnBoxSummonEvent(BoxSummonEventId eid)
		{
		}

		public void StartAnimation(Action animEndCallback)
		{
		}

		private IEnumerator PlaySummonAnimation(Action animEndCallback)
		{
			return null;
		}

		public void SkipFirstCut()
		{
		}

		private void Reset()
		{
		}

		public void StartItemFall()
		{
		}

		private void SetupEtoECamera()
		{
		}

		private void GoToResult(bool isFadingOut)
		{
		}

		public void ClearAll()
		{
		}

		private IEnumerator ItemFallCoroutine()
		{
			return null;
		}

		private FlashPlayer GetItemFallFlashPlayer(int index)
		{
			return null;
		}

		private void ResetEtoECamera()
		{
		}

		private void ExitItemFall()
		{
		}

		public void DestroyItemFallFlashPlayers()
		{
		}

		private void ResetCamera(bool bIsDragon = false)
		{
		}

		public void SkipAniamtion()
		{
		}

		private IEnumerator SkipCoroutine()
		{
			return null;
		}

		public void DestroyStage3DNodeChildren()
		{
		}

		private void DestroyChildren(Transform t)
		{
		}
	}
}
