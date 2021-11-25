using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SkillInfoCommonListCell : CommonIconListCell
	{
		[SerializeField]
		private Transform iconParentTransform;

		[SerializeField]
		private Text skillName;

		[SerializeField]
		private Text skillDetail;

		[SerializeField]
		private GameObject blackMaskObject;

		[SerializeField]
		private GameObject effectBaseObject;

		protected override void Start()
		{
		}

		public override void UpdateContent(CommonIconListCellData data)
		{
		}

		public void OmitTextWithEllipsis(Text text)
		{
		}

		public override void LoadUnitIcon()
		{
		}

		public void PlayUnlockSkillEffect([Optional] Action endCallBack)
		{
		}
	}
}
