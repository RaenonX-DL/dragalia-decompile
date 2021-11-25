using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthCrestPlusParamConfirmPopup : CommonPopup
	{
		public Image[] itemIcons;

		public Text[] counts;

		public GameObject[] paramUIBase;

		public Text[] upParamLabelTexts;

		public Text[] upParamTexts;

		public int hpPlusValue
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int atkPlusValue
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static GrowthCrestPlusParamConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(Dictionary<int, int> materialData)
		{
		}
	}
}
