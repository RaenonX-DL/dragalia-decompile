using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class DrumScrollAllController : MonoBehaviour
	{
		[SerializeField]
		private DrumScrollRect lowerScrollRect;

		[SerializeField]
		private DrumScrollRect upperScrollRect;

		[SerializeField]
		private DrumScrollRect centerScrollRect;

		public int scrollItemCount;

		public int instantateItemCount;

		public UnityAction<int, GameObject> onUpdateItem;

		public int startScollCount;

		public int CurrentTopIndex => default(int);

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
