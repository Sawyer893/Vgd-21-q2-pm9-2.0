using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    // Start is called before the first frame update.
    void Start()
    {
        
    }

    // Update is called once per frame
    
   

    
    private Dictionary<Sprite, Sprite> RunCycle = new Dictionary<Sprite, Sprite>();
    public Sprite GetReplacementSprite(Sprite orig, string replacementFolderPath)
    {
        if (RunCycle.ContainsKey(orig)) return RunCycle[orig];
        Sprite Idle = Resources.Load<Sprite>(replacementFolderPath + "/" + orig.name); // Or however it is you load your replacement sprites
        RunCycle.Add(orig, Idle);
        return Idle;
    }
}



