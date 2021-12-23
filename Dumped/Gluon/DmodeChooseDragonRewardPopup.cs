using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeChooseDragonRewardPopup : PopupBase
	{
		[SerializeField]
		[Header("Item")]
		public DmodeDragonRewardDetailInfoCell cellTemplate;

		[SerializeField]
		[Header("Content")]
		public Text dmodePointText;

		public static readonly string prefabPath;

		private List<DmodeDragonRewardDetailInfoCell> cells;

		public static DmodeChooseDragonRewardPopup instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static DmodeChooseDragonRewardPopup Create(Action onClose)
		{
			return null;
		}

		public static void CallClosePU()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void Start()
		{
		}

		private void UpdateDmodePointView()
		{
		}

		public void OnActiveAbilityListPopupPressed()
		{
		}

		public void OnGetDmodePointButtonPressed()
		{
		}
	}
}
