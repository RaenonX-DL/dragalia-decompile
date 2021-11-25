using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace Gluon
{
	public class AfterPrologueDownloadCharaDetailPopup : CommonPopup
	{
		public Text charaName;

		public Text charaDescription;

		public Text skillName1;

		public Text skillName2;

		public Text skillDescription1;

		public Text skillDescription2;

		public Image[] skillIcons1;

		public Image[] skillIcons2;

		private Dictionary<string, int> skillIconNameToIndex;

		public int charaId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static AfterPrologueDownloadCharaDetailPopup CreateCharaDetailPopup(int charaId)
		{
			return null;
		}

		protected override void Start()
		{
		}
	}
}
