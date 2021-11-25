using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RaidPlayerUI : MonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private Text label;

		[SerializeField]
		private InGameGaugeUISpriteRenderer gaugeHP;

		[SerializeField]
		private Image[] mark;

		[SerializeField]
		[Header("resource")]
		private Sprite onMark;

		[SerializeField]
		private Sprite offMark;

		[SerializeField]
		private Image playerNoImage;

		[SerializeField]
		private Sprite[] playerNo;

		[SerializeField]
		[Header("parameter")]
		private Color32[] playerColor;

		private SandTimerUI sandTimerUI;

		private static readonly Vector3 SAND_TIMER_POS;

		public static GameObject LoadPrefab()
		{
			return null;
		}

		public static RaidPlayerUI Create(GameObject prefab, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Active(bool b)
		{
		}

		public void SetName(string name, int index, int numTotal)
		{
		}

		public void SetInfo(int numLiving, float value)
		{
		}

		public void CreateSandTimerUI()
		{
		}

		public void ShowSandTimerUI()
		{
		}

		public void HideSandTimerUI()
		{
		}

		public void SetSandTimerUICount(int count)
		{
		}

		public void SetSandTimerUICountColor(SandTimerUI.CountColorType type)
		{
		}
	}
}
