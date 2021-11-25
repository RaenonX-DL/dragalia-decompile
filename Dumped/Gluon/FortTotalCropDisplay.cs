using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FortTotalCropDisplay : MonoBehaviour
	{
		[SerializeField]
		private Text text;

		[SerializeField]
		private float moveDistanceY;

		[SerializeField]
		private float duration;

		private int _totalCropNum;

		private Vector3 initialLocalPos;

		public int totalCropNum
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public void Reset()
		{
		}

		public void AddTotalCropNum(int num, long currentNum, bool isItem)
		{
		}

		public void DispFortStoredTotalCrop()
		{
		}

		public void DispFortTotalCrop(int additionalNum)
		{
		}

		public float GetPopupAnimTotalDuration()
		{
			return default(float);
		}

		public void PlayPopupAnim()
		{
		}
	}
}
