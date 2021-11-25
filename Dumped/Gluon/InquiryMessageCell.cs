using System;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class InquiryMessageCell : TableViewCell<InquiryMessageListCellData>
	{
		private readonly int TitleStringMax;

		private readonly int TitleStringSingleMax;

		[SerializeField]
		private Text titleLine;

		[SerializeField]
		private Text titleLines;

		[SerializeField]
		private Text time;

		private string opinionId;

		[NonSerialized]
		public UnityAction<string> onClickedCallback;

		public void InitSetting(AtgenOpinionList initOpinion)
		{
		}

		public override void UpdateContent(InquiryMessageListCellData data)
		{
		}

		public void OnLeftButtonPressed()
		{
		}

		private static void OmitText(Text text)
		{
		}
	}
}
