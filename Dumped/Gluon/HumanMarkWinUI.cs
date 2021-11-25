using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class HumanMarkWinUI : CharacterMarkUI
	{
		[SerializeField]
		[Header("component")]
		private Text labelText;

		[SerializeField]
		private GameObject gobjLabel;

		private CharacterBase owner;

		private RectTransform rootRt;

		private VisibleUIObject labelVisible;

		private VisibleUIObject rootVisible;

		public void Initialize(CharacterBase player)
		{
		}

		private void LateUpdate()
		{
		}

		public override void UpdatePosition(bool interpolation = true)
		{
		}

		private void InvisibleAll()
		{
		}

		private Vector2 GetScreenPos(CharacterBase chara)
		{
			return default(Vector2);
		}
	}
}
