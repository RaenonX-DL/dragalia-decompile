using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LoginBonusItemIcon : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon icon;

		[SerializeField]
		private GameObject getMark;

		[SerializeField]
		private Text DayText;

		[SerializeField]
		private Animator getMarkAnimator;

		[SerializeField]
		private GameObject haloObject;

		[SerializeField]
		private Animator haloAnimator;

		private bool isSkipTicket;

		public void SetContent(LoginBonusRewardElement itemData)
		{
		}

		public bool IsSkipTicket()
		{
			return default(bool);
		}

		public void SetContent(GiftType giftType, int id, int count, int day)
		{
		}

		public void SetGetMark(bool isGotten, bool withAnimation)
		{
		}

		public void SetHaloLight(bool isShow)
		{
		}

		public void SetGetColor(bool isGotten)
		{
		}
	}
}
