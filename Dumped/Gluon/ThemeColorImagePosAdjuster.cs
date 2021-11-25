using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class ThemeColorImagePosAdjuster : MonoBehaviour
	{
		[SerializeField]
		[Header("Positions")]
		public Vector3 mypagePos;

		[SerializeField]
		public Vector3 growthPos;

		[SerializeField]
		public Vector3 partyPos;

		[SerializeField]
		public Vector3 fortPos;

		[SerializeField]
		public Vector3 summonPos;

		[SerializeField]
		public Vector3 menuPos;

		[SerializeField]
		public Vector3 eventPos;

		private Image _image;

		private Image image => null;

		private void Start()
		{
		}

		public void ApplyPosition()
		{
		}
	}
}
