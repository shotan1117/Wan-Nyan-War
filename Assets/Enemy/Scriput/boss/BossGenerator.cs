using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<<< HEAD:Assets/Enemy/Scriput/boss/BossGenerator.cs
public class BossGenerator : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
========
public class smokedestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
>>>>>>>> 2fa96d62 (爆弾):Assets/VFX/smoke destroy.cs
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
