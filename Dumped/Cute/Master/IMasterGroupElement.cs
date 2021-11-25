using System.Collections.Generic;
using UnityEngine;

namespace Cute.Master
{
	public interface IMasterGroupElement
	{
	}
	public abstract class IMasterGroupElement<T> : IMasterBase where T : IMasterElement, new()
	{
		[SerializeField]
		protected int id;

		[SerializeField]
		protected bool initialized;

		public List<T> List;

		public int Id => default(int);
	}
}
