using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class TutorialSummonUnitListPopup : PopupBase
	{
		[SerializeField]
		private TutorialSummonUnitListController ctrl;

		public static TutorialSummonUnitListPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}

		public override void StartCloseAnimation([Optional] UnityEvent onCompleted)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
