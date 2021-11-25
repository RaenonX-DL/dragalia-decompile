using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FirstCharaSelectCell : TableViewCell<FirstCharaSelectData>
	{
		[SerializeField]
		private Text charaName;

		[SerializeField]
		private GameObject checkMark;

		[SerializeField]
		private GameObject recommend;

		[SerializeField]
		private GameObject colleague;

		[SerializeField]
		private Transform charaIconTrans;

		[SerializeField]
		private Button summonButton;

		public Action<int> onSummonButtonClick;

		private int charaId;

		public override void UpdateContent(FirstCharaSelectData itemData)
		{
		}

		public void OnSummonButtonClick()
		{
		}
	}
}
