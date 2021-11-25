using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumCommonUnitIcon : CommonUnitIcon
	{
		public enum IconStatus
		{
			None,
			Possession,
			bonusClear,
			bonusComplete
		}

		[SerializeField]
		private Image bonusClearIcon;

		[SerializeField]
		private Image bonusCompleteIcon;

		public void SetIconStatus(IconStatus status)
		{
		}
	}
}
