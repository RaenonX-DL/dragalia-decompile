using System;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShareSkillSelectButton : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("ã\u0083\u009cã\u0082¿ã\u0083³")]
		private Button _button;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private SpriteRenderer _iconSprite;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³å\u0088¶å¾¡")]
		private SkillIconCtrl _iconCtrl;

		public static ShareSkillSelectButton Create(GameObject parent, int index, Action<ShareSkillSelectButton> onClick, bool isLeft)
		{
			return null;
		}

		public void Initialize(Action<ShareSkillSelectButton> onClick, bool isLeft)
		{
		}

		public override void FastUpdate()
		{
		}

		public void SetEnableButton(bool b, bool isForce = false)
		{
		}

		private void SetIcon(Material material, Sprite sprite)
		{
		}
	}
}
