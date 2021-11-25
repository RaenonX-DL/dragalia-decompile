using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public abstract class SimpleCharacterFacialControlBase : SimpleCharacterFacialControlInterface
	{
		private bool isEnable;

		protected List<Material> materialList;

		protected Vector2 defaultOffset
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected Vector2 currentOffset
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Setup(List<Material> materialList)
		{
		}

		public void SetEnable(bool enable)
		{
		}

		public bool GetEnable()
		{
			return default(bool);
		}

		protected void ApplyOffset()
		{
		}

		public void LateUpdate()
		{
		}

		public void SetTrigger(string triggerName)
		{
		}

		protected abstract void OnSetup(out Vector2 defaultTextureOffset);

		protected abstract bool OnLateUpdate(out Vector2 outTextureOffset);

		protected virtual void OnTrigger(string triggerName)
		{
		}

		public virtual void SetFaceEye(CharaFaceEye faceEye)
		{
		}

		public virtual void SetFaceMouth(CharaFaceMouth faceMouth)
		{
		}
	}
}
