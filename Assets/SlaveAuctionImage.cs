using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlaveAuctionImage : MonoBehaviour
{
 [SerializeField]   SlaveSelectionButton ssb;
    [SerializeField] SpriteRenderer spriteRenderer;

    private void Start()
    {
       ssb =  GetComponentInParent<SlaveSelectionButton>();
        spriteRenderer= GetComponent<SpriteRenderer>();
        Sprite defaultSprite = Resources.Load<Sprite>("DefaultCharacterSprite");
        if(ssb.character.sprite !=null)
        {
            spriteRenderer.sprite = ssb.character.sprite;
        }
        else
        {
            spriteRenderer.sprite = defaultSprite;  
        }

        
    }
}
