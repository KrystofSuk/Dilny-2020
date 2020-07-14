using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Attributes/Bullet")]
public class BulletAttribute : MonoBehaviour
{
    [HideInInspector]
    public int playerId = 0;

	//This will create a dialog window asking for which dialog to add
	private void Reset()
	{
		Utils.Collider2DDialogWindow(this.gameObject, true);
	}
}
