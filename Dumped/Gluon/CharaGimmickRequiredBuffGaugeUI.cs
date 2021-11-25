using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickRequiredBuffGaugeUI : CharaGimmickBaseGaugeUI
	{
		[Serializable]
		public class IconParam
		{
			public int conditionId;

			public string iconName;
		}

		[SerializeField]
		[Header("component")]
		private RectTransform rootRt;

		[SerializeField]
		private RectTransform iconRootRt;

		[SerializeField]
		private SpriteRenderer bgImage;

		[SerializeField]
		private GameObject baseIconUI;

		[SerializeField]
		[Header("parameter")]
		private float bgWidthSize;

		[SerializeField]
		private IconParam[] iconParams;

		private CharacterBase owner;

		private Dictionary<int, CharaGimmickRequiredBuffGaugeIconUI> iconUIDic;

		private List<CharaGimmickRequiredBuffGaugeIconUI> iconUIList;

		private bool isVisible;

		private int iconMaxNum => default(int);

		private int iconActiveNum => default(int);

		public static CharaGimmickRequiredBuffGaugeUI Create(CharacterBase chara, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(CharacterBase chara)
		{
		}

		private bool GetIconParam(int conditionId, out IconParam param)
		{
			return default(bool);
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		private void ExecHide(bool isForce = false)
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		public override int GetGaugeType()
		{
			return default(int);
		}
	}
}
