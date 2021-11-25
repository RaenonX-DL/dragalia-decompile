using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EarnEventInfoCtrl : EventInfoCtrlBase
	{
		[SerializeField]
		[Header("ã\u0083¬ã\u0082¤ã\u0083\u0089äº¤æ\u008f\u009bã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a01,2,ã\u0083\u0081ã\u0082§ã\u0083¬ã\u0083³ã\u0082\u00b8ã\u0083\u0081ã\u0082±ã\u0083\u0083ã\u0083\u0088 ")]
		private Image[] materialImages;

		[SerializeField]
		[Header("ã\u0083¬ã\u0082¤ã\u0083\u0089äº¤æ\u008f\u009bã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a01,2,ã\u0083\u0081ã\u0082§ã\u0083¬ã\u0083³ã\u0082\u00b8ã\u0083\u0081ã\u0082±ã\u0083\u0083ã\u0083\u0088 ")]
		private Text[] materialTexts;

		[SerializeField]
		private Text hintText;

		[SerializeField]
		private Text hintTitleText;

		protected override void Start()
		{
		}

		public static EarnEventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}

		private void SetEventHintText()
		{
		}

		private void SetEventHintTitle()
		{
		}
	}
}
