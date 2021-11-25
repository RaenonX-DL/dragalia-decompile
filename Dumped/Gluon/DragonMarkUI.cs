using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DragonMarkUI : CharacterMarkUI
	{
		[SerializeField]
		[Header("component")]
		private RectTransform conditionRt;

		[SerializeField]
		private RectTransform markRt;

		[SerializeField]
		private RectTransform nameRt;

		[SerializeField]
		private RectTransform iconRt;

		[SerializeField]
		private SpriteRenderer markImage;

		[SerializeField]
		private SpriteRenderer iconImage;

		[SerializeField]
		private SpriteRenderer sandTimerImage;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private InGameGaugeUISpriteRenderer timeGauge;

		[SerializeField]
		[Header("resource")]
		private Sprite[] marks;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³èª¿æ\u0095\u00b4å\u0080¤")]
		public float iconAdjustPosX;

		private InGameUICtrl inGameUI;

		private DragonCharacter owner;

		private RectTransform rootRt;

		private VisibleUIObject rootRtVisible;

		private VisibleUIObject conditionRtVisible;

		private VisibleUIObject nameRtVisible;

		private VisibleUIObject iconRtVisible;

		private SandTimerUI sandTimerUI;

		private CharaCircleGaugeUI circleGaugeUI;

		private Vector3 iconOriginalPos;

		private bool isOwner;

		private bool isEnableGaugeAnim;

		private const float SandTimerOffsetY = 40f;

		private const float SandTimerMarkAdjustY = 27f;

		private const float CircleGaugeOffsetY = 68f;

		private const float CircleGaugeMarkAdjustY = 80f;

		public void Initialize(DragonCharacter dragon, InGameUICtrl inGameUI)
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateIcon()
		{
		}

		public override void UpdatePosition(bool interpolation = true)
		{
		}

		public void SetEnableGaugeAnim(bool enable)
		{
		}

		public bool IsChangingGaugeAnim()
		{
			return default(bool);
		}

		public void SetTimeGauge(float value, bool immediate)
		{
		}

		private void InvisibleAll()
		{
		}

		public override void Show(DisplayType type, [Optional] CharacterBase target)
		{
		}

		private void Show()
		{
		}

		public override void SetPlayerNo(int no, bool own)
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		public void CreateSandTimerUI()
		{
		}

		public void ShowSandTimerUI()
		{
		}

		public void HideSandTimerUI()
		{
		}

		public void SetSandTimerUICount(int count)
		{
		}

		public void SetSandTimerUICountColor(SandTimerUI.CountColorType type)
		{
		}

		private bool IsSandTimerUICountDown()
		{
			return default(bool);
		}

		public override void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void ShowCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void HideCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void SetCircleGaugeUIGaugeTimer(CharaCircleGaugeUI.Type type, float time, float initialTime)
		{
		}

		public override void SetCircleGaugeUICount(CharaCircleGaugeUI.Type type, int count)
		{
		}
	}
}
