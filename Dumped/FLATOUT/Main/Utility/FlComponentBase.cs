using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlComponentBase : MonoBehaviour
	{
		protected bool _exist;

		protected FlObjectBase _objectBase;

		protected FlUIBase _uiBase;

		public bool Exist => default(bool);

		public FlObjectBase ObjectBase => null;

		public FlUIBase UIBase => null;

		private void OnDestroy()
		{
		}

		public virtual T Initialize<T>() where T : FlUIBase, new()
		{
			return null;
		}

		protected virtual void _ApplyValue()
		{
		}

		protected virtual void _Initialize_PostProcess()
		{
		}

		protected virtual void _Release()
		{
		}
	}
}
