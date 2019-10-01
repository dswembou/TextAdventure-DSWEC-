using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // Alle mogelijke States worden hier opgesomd
    private enum States
    {
        start,
        intro,
        delen,
        deelnee,
        deelja,
        leukgesprek
        
    }

    private States currentState = States.start; // Bijhouden wat de huidige state is
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        Terminal.WriteLine("Dit is in de terminal");
        ShowMainMenu();
    }
    
    // Controleren wat de speler in heeft gevoerd
    void OnUserInput(string input) // input bevat de ingetypte tekst van de speler
    {
        // Switch wordt gebruikt om alle mogelijke states te controleren
        switch (currentState)
        {
            case States.start:
                if (input == "start")
                {
                    StartIntro();
                }else if (input == "1337")
                {
                    Terminal.WriteLine("Jij bent Leet!");
                }else if (input == "DSWE")
                {
                    Terminal.WriteLine("Typ start mr van Wakeren");
                }
                else
                {
                    Terminal.WriteLine("Je moet start typen om te beginnen");
                }

                break;
            case States.intro:
                if (input == "verder")
                {
                    Delen();
                }
                break;
            default:
                Terminal.WriteLine("Je hebt de game kapot gemaakt.");
                break;
        }
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het was een koude donkere nacht");
        Terminal.WriteLine("Een goede nacht om Fortnite te doen");
        Terminal.WriteLine("Typ VERDER om door te gaan");
        currentState = States.intro;
    }

    void Delen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je krijgt het verzoek om je Discord gegevens te delen");
        Terminal.WriteLine("Wil je dat doen?");
        Terminal.WriteLine("Typ JA om te delen");
        Terminal.WriteLine("Typ NEE om niet te delen");
        currentState = States.delen;
    }
    void ShowMainMenu ()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij HorrorNite");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal");
        Terminal.WriteLine("Typ START om te beginnen");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
