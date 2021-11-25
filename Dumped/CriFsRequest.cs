using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CriFsRequest : CriDisposable
{
	public delegate void DoneDelegate(CriFsRequest request);

	public DoneDelegate doneDelegate
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool isDone
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string error
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool isDisposed
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public override void Dispose()
	{
	}

	public virtual void Stop()
	{
	}

	public YieldInstruction WaitForDone(MonoBehaviour mb)
	{
		return null;
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public virtual void Update()
	{
	}

	protected void Done()
	{
	}

	private IEnumerator CheckDone()
	{
		return null;
	}

	~CriFsRequest()
	{
	}
}
