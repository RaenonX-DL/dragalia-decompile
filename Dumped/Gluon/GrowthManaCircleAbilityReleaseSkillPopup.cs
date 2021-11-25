using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleAbilityReleaseSkillPopup : CommonPopup
	{
		public enum PopupType
		{
			None,
			Skill,
			Ability,
			ExAbility,
			BurstAttack
		}

		public Text subTitle1;

		public Text subTitle2;

		public Text label2;

		public Text requiredMpNum;

		public Text currentMPNum;

		public Text afterMPNum;

		public Text warningText;

		public Image manaIcon;

		public Image dewIcon;

		public Image iconImage;

		public GameObject burstAttackIcon;

		public Text nameText;

		public Text detailText;

		public CommonIconListSortDeco iconDeco;

		public ScrollRect detailScrollRect;

		public GameObject bottomHalf;

		public GameObject[] items;

		public Image[] itemIconImages;

		public CommonIconListSortDeco[] itemIconDeco;

		public Text[] itemDetailText;

		public Text[] requiredDewNums;

		public Text[] dewLabelText;

		public GameObject manaOrdewRequiredObj;

		public GameObject materialObj;

		public GrowthManaCircleReleaseMaterialIcon icon;

		public CommonExAbilityCell[] exAbilityCells;

		public static GrowthManaCircleAbilityReleaseSkillPopup Create(ManaPieceType type, bool isGrowMaterial = false)
		{
			return null;
		}

		public void SetParameters(GrowthManaCircleModel model, GrowthManaCircleManaPieceData pieceData, int currentMP, WeaponType weaponType, bool isCircleReleased = true)
		{
		}

		private void SetSkill(GrowthManaCircleManaPieceData pieceData)
		{
		}

		private void SetAbility(GrowthManaCircleManaPieceData pieceData)
		{
		}

		private void SetExAbility(GrowthManaCircleManaPieceData pieceData, GrowthManaCircleManaPieceData[] exAbilityPieceData, int exAbilityLevel)
		{
		}

		private void SetExAbilityGrowthMaterial(GrowthManaCircleManaPieceData pieceData, GrowthManaCircleManaPieceData[] exAbilityPieceData, int exAbilityLevel)
		{
		}

		private void SetBurstAttack(GrowthManaCircleManaPieceData pieceData, WeaponType weaponType)
		{
		}

		public void SetItem(GrowthManaCircleManaPieceData pieceData)
		{
		}

		public void SetIconImage(PopupType type, int masterId, int level, int index = 0)
		{
		}

		public void SetNameText(string name, ElementalType type = ElementalType.NONE)
		{
		}

		public void SetDetailText(string detail, ElementalType type = ElementalType.NONE)
		{
		}

		private IEnumerator SetScrollRectMovementType()
		{
			return null;
		}

		public void SetLevelText(int level, bool isMax = false)
		{
		}
	}
}
