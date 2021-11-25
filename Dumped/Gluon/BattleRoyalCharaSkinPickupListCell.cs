using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalCharaSkinPickupListCell : MonoBehaviour
	{
		public Image charaIcon;

		public Image skillIcon;

		public Text skillText;

		public GameObject summonButtonObject;

		public GameObject releaseButtonObject;

		public GameObject releasedTextObject;

		public Action goSummonCallBack;

		public Action<int> releaseSkinCallBack;

		private int specialSkillId;

		[HideInInspector]
		public int skinId
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

		public void InitCell(int charaSkinId)
		{
		}

		public void UpdateCellButton()
		{
		}

		public void OnSummonButtonPressed()
		{
		}

		public void OnReleaseButtonPressed()
		{
		}

		public void OnSkillCellPressed()
		{
		}
	}
}
