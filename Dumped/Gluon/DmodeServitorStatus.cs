using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeServitorStatus : MonoBehaviour
	{
		[SerializeField]
		private RawImage dragonIcon;

		[SerializeField]
		private Text dragonNameText;

		[SerializeField]
		private RawImage skillIcon;

		[SerializeField]
		private Text skillNameText;

		private static readonly int skillMaxLevel;

		public DmodeServitorType selectedServitorType
		{
			[CompilerGenerated]
			get
			{
				return default(DmodeServitorType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void InitializeSelectedDmodeServitorType(int charaId)
		{
		}

		public void Reload()
		{
		}

		public void ShowChangeEquipedServitorSkillPopup()
		{
		}

		private void UpdateEquipedServitorSkill()
		{
		}

		private DmodeServitorElement SearchDmodeServitorDataFromServitorType(DmodeServitorType servitorType)
		{
			return null;
		}

		public void ShowSkillDetailPopup()
		{
		}

		public void ShowPassiveAbilityListPopup()
		{
		}
	}
}
