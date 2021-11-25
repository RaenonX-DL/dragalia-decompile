using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftEvolutionBaseFrame : MonoBehaviour
	{
		public Image weaponIcon;

		public Image skillIcon;

		public Image[] abilityIcons;

		public Text skillText;

		public Text[] abilityText;

		public Text weaponName;

		public Text hpParam;

		public Text atkParam;

		public Text hpParamText;

		public Text atkParamText;

		public LimitStarBase limit;

		public Text plusParam;

		public GameObject sortDecoAttachNode;

		public Text selfCountText;

		private ulong weaponId;

		private int skillLv;

		private WeaponDataElement weaponData;

		private bool isSelfInBox;

		[SerializeField]
		private GameObject skillBase;

		[SerializeField]
		private GameObject[] abilityBase;

		[SerializeField]
		private Transform[] starEffectBase;

		private GameObject originEffectObj;

		private bool isPlayLimitEffect;

		private void Awake()
		{
		}

		public void SetupBaseInfo(ulong keyId)
		{
		}

		public void SetupBaseInfoByMasterId(int masterId, int takeOverHpPlusParam = 0, int takeOverAtkPlusParam = 0)
		{
		}

		public void OnSkillButtonPressed()
		{
		}

		public void OnAbilityButtonPressed(int intex)
		{
		}

		public void OnIconButtonPressed()
		{
		}

		public void SetCraftCountText(long count)
		{
		}

		private void SetupFromMasterData(WeaponDataElement masterWeaponData)
		{
		}

		private void SetupLimitBreakMaxEffect()
		{
		}

		private void DestoryLimitBreakMaxEffect()
		{
		}
	}
}
