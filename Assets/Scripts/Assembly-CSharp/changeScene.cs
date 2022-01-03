using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000004 RID: 4
public class changeScene : MonoBehaviour
{
	// Token: 0x06000006 RID: 6 RVA: 0x000020C5 File Offset: 0x000002C5
	public void click()
	{
		SceneManager.LoadScene("game", LoadSceneMode.Single);
	}
}
