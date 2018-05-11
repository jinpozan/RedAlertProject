using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IGameSystem {
	public abstract void Init();
	public abstract void Update();
	public abstract void Release();
}
