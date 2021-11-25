using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonSkillIcon : CommonIcon
	{
		public Image ownerImage;

		public GameObject blackMaskObject;

		public GameObject lockObject;

		public GameObject selectObject;

		public GameObject flagObject;

		public Image skillCostImage;

		public Text skillCostText;

		public void SetupSkillIcon(SkillListCellData data)
		{
		}
	}
}
