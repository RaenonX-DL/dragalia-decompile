using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class PlayerBuffUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private SpriteRenderer[] buffImage;

		[SerializeField]
		private SpriteRenderer[] buffCountImage10;

		[SerializeField]
		private SpriteRenderer[] buffCountImage01;

		[SerializeField]
		private SpriteRenderer[] debuffImage;

		[SerializeField]
		private SpriteRenderer[] debuffCountImage10;

		[SerializeField]
		private SpriteRenderer[] debuffCountImage01;

		private CharacterBase character;

		private void Start()
		{
		}

		public void SetCharacter(CharacterBase chara)
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
