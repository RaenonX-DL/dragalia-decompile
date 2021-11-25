using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectChapterMap : AnimationUIObject
	{
		[Serializable]
		public class ChapterIconPos
		{
			[SerializeField]
			private Image _iconImage1;

			[SerializeField]
			private Image _iconImage2;

			private bool initFlag;

			[SerializeField]
			private Button _button;

			public Image iconImage1
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Vector2 iconPos1
			{
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Image iconImage2
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Vector2 iconPos2
			{
				[CompilerGenerated]
				get
				{
					return default(Vector2);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Button button
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public void Initialize(int index)
			{
			}
		}

		public QuestSelectScene questSelectScene;

		[SerializeField]
		public Canvas selfCanvas;

		[SerializeField]
		public Image uiWorldMap;

		[SerializeField]
		private float worldmapScrollOffsetY;

		[SerializeField]
		private QuestCloudController worldMapCloudCtrl;

		private Tweener worldMapMoveTweener;

		private readonly Vector2 mapSize;

		private const float adjustCloudSpeed = 0.5f;

		[SerializeField]
		private float worldIconMoveTime;

		private Material worldMapMaterial;

		private int worldMapId;

		private CanvasGroup worldMapCanvasGroup;

		private Tweener mapChangeFadeTweener;

		[SerializeField]
		[Header("ã\u0083\u009eã\u0083\u0083ã\u0083\u0097å\u0088\u0087æ\u009b¿æ\u0099\u0082é\u0096\u0093 X:in Y:out")]
		private Vector2 mapChangeDurationSec;

		private QuestChapterIconPos[] chapterMapIconArray;

		[SerializeField]
		private float mapOffset;

		[SerializeField]
		private float iPhoneXMapOffset;

		[SerializeField]
		private AnimationUIBase mapAnimation;

		public float worldMoveTime => default(float);

		public bool IsMapIconInitDone
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

		public bool IsInitDone
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

		protected override void Awake()
		{
		}

		private IEnumerator InitializeWorldMapMaterial()
		{
			return null;
		}

		public void ChangeWorldMap(int mapId)
		{
		}

		private void InitializeMapIcon()
		{
		}

		private void DestroyChapter()
		{
		}

		private void WorldMapCheck()
		{
		}

		public void Initialize(int lastSelectedChapterNumber, QuestSelectWheelElement topChapterElement)
		{
		}

		private IEnumerator InitializeCoroutine(int lastSelectedChapterNumber, QuestSelectWheelElement topChapterElement)
		{
			return null;
		}

		public void OnUpdate(QuestSelectWheelElement topChapterElement, int topNum, int beforeNum, Action onComplete)
		{
		}

		public void EnableChapterMapIconArray(int topNum, bool flag)
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		public void FadeWorldMap(float fromAlpha, float toAlpha)
		{
		}

		public void GetChapterIconPivotAndLocalPos(int chapterNumber, out Vector2 chapterPivot, out Vector3 chapterTargetLocalPos)
		{
		}

		public void DisplayChapterIcon()
		{
		}

		public Tweener NewChapterTweenMove(int newChapter, float during)
		{
			return null;
		}

		public Tweener NewChapterTweenScale(float endValue, float time)
		{
			return null;
		}

		public void CloudFadeOut(int topNum)
		{
		}

		private void SetChapterIconAlpha(int chapterIndex, float alphaValue)
		{
		}

		public void SetChapterIconButton(QuestSelectWheelElement topChapterElement)
		{
		}

		public void InitchapterMapIconArray(int lastSelectedChapterNumber)
		{
		}

		public void AllChapterIconButtonInteractable(bool enable)
		{
		}

		public QuestChapterIconPos[] GetChapterIcon()
		{
			return null;
		}

		private Vector3 ConvertLocalPositionByPivot(RectTransform rectTrans, Vector2 newPivot)
		{
			return default(Vector3);
		}
	}
}
