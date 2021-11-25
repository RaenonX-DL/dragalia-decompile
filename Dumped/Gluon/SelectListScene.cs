using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class SelectListScene : ShopTradeScene
	{
		[SerializeField]
		private Transform selectViewParent;

		[SerializeField]
		[Header("BG")]
		public Canvas bgCanvas;

		public static UnityAction<UnityAction> decideButtonCallBack;

		private ShopTreasureTradeMaterialSelectView selectView;

		private BaseCanvasContents baseCanvasContents;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDecideButtonPressed()
		{
		}

		public void BackButtonPressed()
		{
		}
	}
}
