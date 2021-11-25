using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class AstralRaidsItemPopup : CommonPopup
	{
		[SerializeField]
		private Text picesText;

		[SerializeField]
		private Text beforePicesNumText;

		[SerializeField]
		private Text afterPicesNumText;

		[SerializeField]
		private Text usePicesNumText;

		[SerializeField]
		private CommonSliderSelection picesSlider;

		private int astralPicesNum;

		private int astralPicesUseNum;

		private int astralPicesMaxNum;

		private UnityAction<int> omAstralPicesButtonPressed;

		private readonly int astralPicesMaxCount;

		public static AstralRaidsItemPopup Create(int questId, [Optional] UnityAction<int> OnOkCallback)
		{
			return null;
		}

		public override void OnCancelButtonPressed()
		{
		}

		public override void OnOkButtonPressed()
		{
		}

		public void SetContent(int questId)
		{
		}

		public void OnValueChanged(float value)
		{
		}
	}
}
