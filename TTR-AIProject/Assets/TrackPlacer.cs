using UnityEngine;

public class MakeTrack 
{
    public Sprite sprite;

    void PlaceTrack(int length, int color)
    {
        GameObject Track = new GameObject("New Track");
        SpriteRenderer renderer = Track.AddComponent<SpriteRenderer>();
        renderer.sprite = spriteResources.Load("C: \Users\Simon\source\repos\TTR - AIProject\TTR - AIProject\Assets\routeTileGray");
        var trackRenderer = Track.GetComponent<Renderer>();

        if(color == "1")
        {
            trackRenderer.material.SetColor("_Color", Color.white);
        }

        else if(color == "2")
        {
            trackRenderer.material.SetColor("_Color", Color.black);
        }

        else if (color == "3")
        {
            trackRenderer.material.SetColor("_Color", Color.green);
        }

        else if (color == "4")
        {
            trackRenderer.material.SetColor("_Color", Color.blue);
        }

        else if (color == "5")
        {
            trackRenderer.material.SetColor("_Color", Color.red);
        }

        else if (color == "6")
        {
            trackRenderer.material.SetColor("_Color", Color.orange);
        }

        else if (color == "7")
        {
            trackRenderer.material.SetColor("_Color", Color.pink);
        }

        else if (color == "8")
        {
            trackRenderer.material.SetColor("_Color", Color.yellow);
        }

        else
        {
            trackRenderer.material.SetColor("_Color", Color.gray);
        }


    }
}


