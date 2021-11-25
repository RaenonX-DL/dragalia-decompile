using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumPlayerRecordListCell : MonoBehaviour
	{
		public Image icon;

		public Text paramText;

		public Slider paramGauge;

		public CircleOutline outline;

		private const float gaugeMaxValue = 3000f;

		private const float gaugeDispOffsetValue = 90f;

		private const int recordMaxValue = 9999;

		public void UpdateCell(AlbumPlayerRecordListCellData cellData)
		{
		}

		public void SetIcon(AlbumPlayerRecordListCellData cellData)
		{
		}

		public void SetGaugeColor(AlbumPlayerRecordListCellData cellData)
		{
		}
	}
}
