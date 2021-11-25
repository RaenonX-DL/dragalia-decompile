using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission
{
	public class MissionWidgetButtonPlate : MonoBehaviour
	{
		public enum FaceType
		{
			OneFace,
			TwoFace,
			None
		}

		[SerializeField]
		[Header("è\u00a8­å®\u009aç\u0094\u00a8")]
		public FaceType type;

		public string[] buttonTexts;

		public Color[] buttonTextColors;

		public bool[] buttonTextIsOutlined;

		public Color[] buttonTextOutlineColors;

		[SerializeField]
		[Header("ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083­ã\u0083¼ã\u0083«ç\u0094\u00a8")]
		public GameObject[] objFaces;

		public Button[] oneFaceButtons;

		public Button[] twoFaceButtons;

		public Text[] oneFaceTexts;

		public Text[] twoFaceTexts;

		private void SetFaceText(Text[] face_texts, string[] texts)
		{
		}

		public void SetText(FaceType type, string[] texts)
		{
		}

		public void Start()
		{
		}
	}
}
