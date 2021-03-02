using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // This is so that it should find the Text component
using UnityEngine.Events; // This is so that you can extend the pointer handlers
using UnityEngine.EventSystems; // This is so that you can extend the pointer handlers

public class colorchange : MonoBehaviour
{
    public bool once = true;
    public Color rainbow = Color.black; //the color we gone use
    public TextMesh textmesh;// you have to get the mesh in the inspector for it to work btw
    // Start is called before the first frame update
    void Start()
    {
        //idk whats going on
       // StartCoroutine(changecolors());
    }
    

    // Update is called once per frame
    void Update()
    {
        if (once)
        {
            StartCoroutine(changecolors());
            once = false;
        }
    }

    IEnumerator changecolors()
    {

        //I swear there has got to be a easier way to do this
        if (rainbow == Color.black)
        {
            rainbow = Color.red;
        }
        //cause otherwise you wouldnt see it
        yield return new WaitForSeconds(1);
        textmesh.color = rainbow;

        if (rainbow == Color.red)
        {
            rainbow = Color.yellow;
        }
        yield return new WaitForSeconds(1);
        textmesh.color = rainbow;
        if (rainbow == Color.yellow)
        {
            rainbow = Color.green;
        }
        yield return new WaitForSeconds(1);
        textmesh.color = rainbow;
        if (rainbow == Color.green)
        {
            rainbow = Color.cyan;
        }
        yield return new WaitForSeconds(1);
        textmesh.color = rainbow;
        if (rainbow == Color.cyan)
        {
            rainbow = Color.blue;
        }
        yield return new WaitForSeconds(1);
        textmesh.color = rainbow;
        if (rainbow == Color.blue)
        {
            rainbow = Color.magenta;
        }
        yield return new WaitForSeconds(1);
        textmesh.color = rainbow;
        if (rainbow == Color.magenta)
        {
            rainbow = Color.red;
        }
        yield return new WaitForSeconds(1);

        //this should be where all the magic really happens?
        textmesh.color = rainbow;
        once = true;
    }
}
