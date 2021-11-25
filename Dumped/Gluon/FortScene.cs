using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class FortScene : SceneBase
	{
		public GameObject uiParent;

		public GameObject fortWorld;

		public Transform cameraFollowTarget;

		public Camera mainCamera;

		public FortAssetsManager assetsManager;

		[SerializeField]
		[Header("å\u0088\u009då\u009b\u009eæ¼\u0094å\u0087ºé\u0096¢é\u0080£ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		private float _titleFadeInDuration;

		[SerializeField]
		private float _titleDispDuration;

		[SerializeField]
		private float _titleFadeOutDuration;

		[SerializeField]
		private float characterDispDelay;

		[SerializeField]
		[Header("é\u008d\u009bå\u0086¶å±\u008bæ¼\u0094å\u0087ºé\u0096¢é\u0080£ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
		private Vector3 blackSmithTutorialEffectAdjustPos;

		private int _noContactSelectedDradonId;

		private EventSystem _eventSystem;

		private const float FlashCameraDefaultSize = 5f;

		private const string dragonAnimationControllerPath = "Animations/OutGame/DragonContact/d200001_01_mot";

		private const string fortGraphicsDataPath = "Prefabs/OutGame/Fort/Graphics/FortGraphicsData";

		public static FortScene instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Canvas uiCanvas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int noContactSelectedDradonId
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public float titleFadeInDuration => default(float);

		public float titleDispDuration => default(float);

		public float titleFadeOutDuration => default(float);

		public PopupBase activePopup
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FortViewController fortViewCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FortPutController fortPutCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FortCameraController cameraCtrl
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FortModel model
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FlashPlayerManager flashPlayerManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isGridMode
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public EventSystem eventSystem => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public static List<string> GetPreLoadAssetList()
		{
			return null;
		}

		public static void ClearPreLoadingAsset()
		{
		}

		public static void LoadEffectResources()
		{
		}

		public bool CheckTutorialRequired(bool isSetTutorialStep = true)
		{
			return default(bool);
		}

		public bool CheckBlackSmithTutorialRequired(bool isSetTutorialStep = true)
		{
			return default(bool);
		}

		public bool IsTutorialCompleted()
		{
			return default(bool);
		}

		private void SetFortTutorialStep()
		{
		}

		public void CheckTutorialStatus()
		{
		}

		private bool CheckTutorialBuildComplete()
		{
			return default(bool);
		}

		private IEnumerator Tutorial_1_6()
		{
			return null;
		}

		public void TutorialBuildCompleted()
		{
		}

		private void TutorialDragonContactStart()
		{
		}

		public void LoadDragon(int dragonId)
		{
		}

		public void CheckBadges()
		{
		}

		public void ReturnToFortTop()
		{
		}

		private void OnFooterPressed(string tabName, Footer.MenuTab tabType)
		{
		}

		public void PrepareToClearFortView()
		{
		}

		public void EnableTouchEvent(bool isEnable)
		{
		}

		public override void OnPresentReceived()
		{
		}

		public FortMenuGroupType GetGroupeTypeByTabIndex(int tabIndex)
		{
			return default(FortMenuGroupType);
		}

		public string GetGroupeTypeText(FortMenuGroupType type)
		{
			return null;
		}

		public void SetFlashCameraSetting()
		{
		}

		public override void OnBeforeLeaving()
		{
		}

		private void OnDestroy()
		{
		}

		private void FooterButtonLongPressed(string tabName, Footer.MenuTab tabType)
		{
		}
	}
}
