using System.Collections;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeServitorPassiveBuildUpPopup : PopupBase, ICustomMessage
	{
		[SerializeField]
		private DmodeServitorPassiveAbilityCell abilitycell;

		[SerializeField]
		private Text insufficientMaterialText;

		[SerializeField]
		private CraftMaterialCell[] materialCell;

		[SerializeField]
		private CommonSlider slider;

		[SerializeField]
		private Button plusButton;

		[SerializeField]
		private Button minusButton;

		[SerializeField]
		private Button okButton;

		[SerializeField]
		private Text useCountText;

		[SerializeField]
		private Text totalCountText;

		[SerializeField]
		private PointerEventHandler plusButtonEventHandler;

		[SerializeField]
		private PointerEventHandler minusButtonEventHandler;

		[SerializeField]
		private PointerEventHandler okButtonHandler;

		public const string prefabPath = "Prefabs/OutGame/Dmode/DmodeServitor/DmodeServitorPassiveBuildUpPopup";

		private DmodeServitorPassiveLevelElement dmodeServitorPassiveLevelElement;

		private int passiveTypeNum;

		private bool isEndInitTask;

		private bool isSkipChangeValueTask;

		private int _nowValue;

		private int minValue;

		private int maxValue;

		private Coroutine updateUICoroutine;

		private Coroutine countCoroutine;

		public int nowValue
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public static DmodeServitorPassiveBuildUpPopup Create(int passiveNum)
		{
			return null;
		}

		public void SetContent(int passiveNum)
		{
		}

		public void ChangedSliderValue(float newValue)
		{
		}

		private IEnumerator UpdatePopupUIDelay()
		{
			return null;
		}

		private void UpdatePopupUI()
		{
		}

		public void OnPlusButtonPressed()
		{
		}

		public void OnMinusButtonPressed()
		{
		}

		public void OnValueChangeButtonLongPressed(int countInc)
		{
		}

		private IEnumerator CountSpeedCoroutine(bool isPlus)
		{
			return null;
		}

		public void OnReleasePassiveLevel()
		{
		}

		public void OnPassiveAbilityLevelRelease(DmodeServitorPassiveLevelElement beforePassiveElement)
		{
		}

		private void UpdateMaterialCell()
		{
		}

		private void OnIconPressed(CraftMaterialCellData data)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
