using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestMapImage : MonoBehaviour
	{
		[SerializeField]
		private GameObject _rootObj;

		[SerializeField]
		public RawImage render3dImage;

		[SerializeField]
		public RawImage render3dImageBlack;

		[SerializeField]
		public Camera render3dCamera;

		[SerializeField]
		private GameObject render3dCameraParent;

		[SerializeField]
		private GameObject characterShaderSettingsObj;

		[SerializeField]
		[Header("Shader")]
		private PartyCharacterShaderSettings charaShaderSettings;

		[SerializeField]
		private Image outerFrame;

		[SerializeField]
		private RectTransform dummyRectQuestTop;

		[SerializeField]
		private RectTransform dummyRectQuestTopFrame;

		[SerializeField]
		private RectTransform dummyRectQuestMiddle;

		[SerializeField]
		private RectTransform dummyRectQuestMiddleFrame;

		private const float waitRenderTime = 0.1f;

		private AnimationUIPart[] animationUIParts;

		private QuestDifficultyImageSetter[] difficultyImageSetters;

		public static Action<RenderTexture> onFinishMapInstance;

		[SerializeField]
		private Transform campaignTrans;

		private CampaignButtons campaign;

		private string campaginPath;

		public float fedeIn;

		public float mapMoveTime;

		public float fadeout;

		private bool isMapAnim;

		public Vector3 flashScale;

		public float flashSec;

		private FlashPlayerManager fpMgr;

		private FlashPlayer questTransitionEffect;

		private RenderTexture render3dTexture;

		private bool isCompleteStartProcess;

		private bool _isOpenFlag;

		public GameObject rootObj => null;

		public AnimationUIPart[] animationUIPartsProperty => null;

		public bool isRenderBgReady
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

		public bool isCloseCompleted
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

		public bool IsCompleteStartProcess => default(bool);

		public bool isOpenFlag
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void SetUpRenderBg(int backgroundPath)
		{
		}

		private IEnumerator SetupRenderBg(int locationId)
		{
			return null;
		}

		public virtual void OnOpen()
		{
		}

		private IEnumerator WaitBgAndOpen()
		{
			return null;
		}

		protected virtual void Open()
		{
		}

		private void WaitBackGround()
		{
		}

		private IEnumerator WaitBackGroundCoroutine()
		{
			return null;
		}

		public virtual void OnClose()
		{
		}

		protected virtual void Close(bool isDestroyOnCompleted = true)
		{
		}

		public void OnCloseCompleted(bool isDestroyOnCompleted = true)
		{
		}

		public void OnAppear()
		{
		}

		public void OnHide()
		{
		}

		public void SetDifficultyImage(QuestSelectScene.Difficulty difficulty)
		{
		}

		public void EnableRootObj(bool enable)
		{
		}

		public void SetupCharaShader()
		{
		}

		public void MapDownAnimation()
		{
		}

		public void MapFadeOutAnimation(Action showQuestPrepare3dImage)
		{
		}

		private IEnumerator MapFadeOutAnimationCorutine(Action showQuestPrepare3dImage)
		{
			return null;
		}

		private void FrameDefault()
		{
		}

		public Tweener SetScreenTransVisible(bool visible)
		{
			return null;
		}

		private Sequence MapImageDOScaleY(float endValue, float duration, Ease ease, [Optional] TweenCallback callback)
		{
			return null;
		}

		private static Sequence DOScaleY(GameObject obj, float endValue, float duration, Ease ease, [Optional] TweenCallback callback)
		{
			return null;
		}
	}
}
