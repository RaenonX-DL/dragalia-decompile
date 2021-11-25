using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class SummonMultiCharaBase : MonoBehaviour
	{
		public Image charaIcon;

		public GameObject newImage;

		public GameObject moonOverride;

		public Text moonCount;

		public Transform backHaloNode;

		public Transform frontHaloNode;

		[SerializeField]
		private Transform _frontBonusNode;

		[SerializeField]
		private Image iconAmulet;

		[SerializeField]
		private Image iconDragonElements;

		[SerializeField]
		private List<Sprite> dragonElements;

		private SummonResultItemData data;

		private int resultIndex;

		public Action<SummonResultItemData, int> onButtonClicked;

		public Transform frontBonusNode => null;

		public void SetByItemData(SummonResultItemData data, int resultIndex)
		{
		}

		public void StartMoonOverride()
		{
		}

		private void SetIcon(Sprite sprite, Material mat)
		{
		}

		private void SetIsNew(bool isNew)
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		private void SetIconAmulet()
		{
		}

		private void SetIconDoragonElement()
		{
		}
	}
}
