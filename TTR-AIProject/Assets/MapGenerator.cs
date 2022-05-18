using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    Sprite[] routeSprites;
    // Start is called before the first frame update
    void Start()
    {
        Sprite[] routeSprites = (Sprite) UnityEditor.AssetDatabase.LoadAllAssetsAtPath("Assets/MapAssets.png");
        Debug.Log(routeSprites.Length);
        //PlaceTrack(1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaceTrack(int length, int color){
        length -= 1;
        GameObject Track = new GameObject("New Track");
        SpriteRenderer renderer = Track.AddComponent<SpriteRenderer>();
        
        var trackRenderer = Track.GetComponent<Renderer>();

        switch (color){
            case 0:
                trackRenderer.material.SetColor("_Color", Color.gray);
                break;
            case 1:
                trackRenderer.material.SetColor("_Color", Color.white);
                break;
            case 2:
                trackRenderer.material.SetColor("_Color", Color.black);
                break;
            case 3:
                trackRenderer.material.SetColor("_Color", Color.green);
                break;
            case 4:
                trackRenderer.material.SetColor("_Color", Color.blue);
                break;
            case 5:
                trackRenderer.material.SetColor("_Color", Color.red);
                break;
            case 6:
                trackRenderer.material.SetColor("_Color", new Color(1f, .6f, 0f, 1f));
                break;
            case 7:
                trackRenderer.material.SetColor("_Color", new Color(1f, .75f, .75f, 1f));
                break;
            case 8:
                trackRenderer.material.SetColor("_Color", Color.yellow);
                break;
            default:
                trackRenderer.material.SetColor("_Color", Color.cyan); //If we pass a bad color int, it'll make the track cyan.
                break;
        }
    }
}
