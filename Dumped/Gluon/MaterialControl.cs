using Cute.Core;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class MaterialControl : FastUpdateMonoBehaviour
	{
		private enum TaskLabel
		{
			Wait,
			Play,
			Stop,
			Pause
		}

		[SerializeField]
		private float _timeScale;

		private MaterialPropertyRenderer[] _materilPropertyDataArray;

		private float _time;

		private int _frame;

		private TaskLabel _taskLabel;

		private float _frameRate;

		public float timeScale
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public MaterialPropertyRenderer[] materilPropertyDataArray => null;

		public float time => default(float);

		public int frame => default(int);

		public static float GetSecondFromFrame(float frame)
		{
			return default(float);
		}

		public static int GetFrameFromSecond(float sec)
		{
			return default(int);
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void AddFrame()
		{
		}

		private void Awake()
		{
		}

		public override void FastUpdate()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
