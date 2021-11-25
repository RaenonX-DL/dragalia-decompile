using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class DragonDetailPage : EventQuestPageBase
	{
		[SerializeField]
		[Header("Plate")]
		public SummonResultStatusPlate statusPlate;

		[SerializeField]
		private Transform returnButtonTransform;

		private SceneNameDefine.PageName previousPageName;

		public Action onBeforLeaving
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void OnButtonBackTouched()
		{
		}

		public void SetContent(SummonResultItemData itemData, SceneNameDefine.PageName lastPage)
		{
		}
	}
}
