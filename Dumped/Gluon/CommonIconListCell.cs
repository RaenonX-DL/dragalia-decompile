using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class CommonIconListCell : TableViewCell<CommonIconListCellData>
	{
		[SerializeField]
		protected GameObject frame;

		public CommonIconListCellData data;

		protected CommonUnitIcon icon;

		protected CommonIcon commonIcon;

		protected CommonSkillIcon skillIcon;

		protected WeaponPassiveAbilityIcon weaponPassiveAbilityIcon;

		protected DmodeServitorPassiveIcon dmodeServitorPassiveAbilityIcon;

		[SerializeField]
		public CommonIconButtonEvent buttonPressed;

		[SerializeField]
		public CommonIconButtonEvent buttonLongPressed;

		protected CommonIconListCaption caption;

		private int captionAbilityId;

		private string captionTitle;

		protected bool isMoveFirstColmnIcon;

		protected virtual void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public override void UpdateContent(CommonIconListCellData data)
		{
		}

		public virtual void LoadUnitIcon()
		{
		}

		public void OnButtonPressed()
		{
		}

		public void OnButtonLongPressed()
		{
		}

		private IEnumerator WaitMoment(UnityAction callback)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		public virtual void UpdateSkillContent(SkillListCellData data)
		{
		}

		public virtual void UpdateWeaponPassiveAbilityContent(WeaponPassiveAbilityListCellData data)
		{
		}

		public virtual void UpdateDmodeServitorPassiveContent(DmodeServitorPassiveIconListCellData data)
		{
		}
	}
}
