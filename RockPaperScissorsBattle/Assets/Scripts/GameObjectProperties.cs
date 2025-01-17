using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectProperties : MonoBehaviour
{
    /// <summary>
    /// 0 - PIEDRA
    /// 1 - PAPEL
    /// 2 - TIJERA
    /// </summary>
  

    [SerializeField]
    private int type;
    public int Type { get => type; set => type = value; }

    [SerializeField]
    private Sprite[] sprite;

    private void Update()
    {
        switch (type)
        {
            case 2:
                this.GetComponentInChildren<SpriteRenderer>().sprite = sprite[type];
                this.name = this.sprite[type].name;
                this.tag = this.sprite[type].name;
                break;
            case 1:
               
                this.GetComponentInChildren<SpriteRenderer>().sprite = sprite[type];
                this.name = this.sprite[type].name;
                this.tag = this.sprite[type].name;
                break;
            case 0:
                
                this.GetComponentInChildren<SpriteRenderer>().sprite = sprite[type];
                this.name = this.sprite[type].name;
                this.tag = this.sprite[type].name;
                break;
            default:
                print("ERROR VALUE TYPE INCORRECT");
                break;
        }
    }


}
