using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthUnitEnhanceStatusController : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		public CommonUnitIcon unitIcon;

		public GrowthUnitEnhanceStatusObject[] statusObjects;

		public GameObject[] pagerOn;

		public GameObject[] pagerOff;

		public Button leftArrow;

		public Button rightArrow;

		public Text unitName;

		public Text unitReleaseCount;

		public Text unitHp;

		public Text unitAtk;

		public Text unitPower;

		public Image skillIcon;

		public Image abilityIcon1;

		public Image abilityIcon2;

		public Image[] slotIconsTypeA;

		public Image[] slotIconsTypeB;

		public Image[] slotIconsTypeC;

		public Image[] equipableIcons;

		private GrowthUnitEnhanceModel model;

		private GrowthUnitEnhanceMainCanvas mainCanvas;

		private int currentIndex;

		private Vector2 beginDragPosition;

		private bool isAnimating;

		public void InitStatusController(GrowthUnitEnhanceModel model, GrowthUnitEnhanceMainCanvas mainCanvas)
		{
		}

		public void UpdateUnitStatus()
		{
		}

		public void SetArrowEnable(bool enable)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void ShowNextStatusObject()
		{
		}

		public void ShowPrevStatusObject()
		{
		}

		public void OnAnimationCompleted()
		{
		}

		public void OnSkillIconPressed()
		{
		}

		public void OnAbility1IconPressed()
		{
		}

		public void OnAbility2IconPressed()
		{
		}

		private void SetPageOn(int index)
		{
		}

		private void ReleadUnitIcon()
		{
		}
	}
}
