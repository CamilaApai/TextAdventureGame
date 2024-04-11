using System;

class AdventureGame
{
    static void Main(string[] args)
    {
        // Welcome message on the console 
        Console.WriteLine("Welcome to the Adventure Game");
        Console.WriteLine("Would you like to play? (yes/no): ");
        Console.WriteLine("");
        string playChoice = Console.ReadLine().ToLower(); // Get user choice, and convert it to lowercase

        if (playChoice == "yes")
        {
            // Introduction message to the game
            Console.WriteLine("You suddenly wake up. You find yourself disoriented. You can't recall how you got here or why. The atmosphere is palpably sinister, and you can't shake the feeling of being watched.");

            // Main game loop
            while (true) // If the player wants to play, the main game loop will show up
            {
                // Presenting choices to the player
                Console.WriteLine("\nChoose your path:");
                Console.WriteLine("1. Walk forward, going deeper into the forest.");
                Console.WriteLine("2. Walk to the right, where you can hear the faint sound of a river.");
                Console.WriteLine("3. Walk to the left, where a dim light flickers through the trees.");
                Console.WriteLine("4. Quit Game");
                Console.WriteLine("");

                // Get user choice
                int choice = GetUserChoice(1, 4);
                switch (choice)
                {
                    case 1:
                        ForestPath();
                        break;
                    case 2:
                        RiverPath();
                        break;
                    case 3:
                        LightPath();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                }
            }
        }
        else // If the player does not want to play, the following message will show up
        {
            Console.WriteLine("Maybe next time!");
        }
    }

    // Function for the Forest Path
    static void ForestPath()
    {
        // Introduction to the forest path
        Console.WriteLine("As you venture deeper into the forest, everything becomes darker. Suddenly, you're startled by the sound of howling nearby, echoing through the trees.");
        Console.WriteLine("");

        // Presenting choices to the player
        Console.WriteLine("\nWhat will you do?");
        Console.WriteLine("1. Investigate the source of the howling, feeling a sense of curiosity and urgency.");
        Console.WriteLine("2. Brush off the sound and press on with your journey, ignoring the potential danger.");

        // Get user choice
        int choice = GetUserChoice(1, 2);

        switch (choice)
        {
            case 1:
                Console.WriteLine("When you manage to find the source of the sound, you see a bunch of hungry wolves. They attack you, and you don't make it out alive. Game Over.");
                break;  // End of game
            case 2:
                ContinueWalking(); // Call the function
                break;
        }
    }


    // Function for the River Path
    static void RiverPath()
    {   
        // Introduction to the river path
        Console.WriteLine("As you get closer to the river, you see a glow coming out of it, and you feel incredibly dazed.");
        Console.WriteLine("");

        // Presenting choices to the player
        Console.WriteLine("\nWhat will you do?");
        Console.WriteLine("1. Dive into the river.");
        Console.WriteLine("2. Take a sip of the water.");
        Console.WriteLine("3. Try to resist and continue on your way.");

        // Get user choice
        int choice = GetUserChoice(1, 3);

        switch (choice)
        {
            case 1:
                Console.WriteLine("As you immerse yourself in the river, you suddenly feel two hands pulling you down, trying to catch you and preventing you from getting out. Game over.");
                break;  // End of game
            case 2:
                Console.WriteLine("You approach the water and drink from it. As you do so, you begin to feel dizzy, and you feel that your throat is closing. The water was not drinkable. You die. Game over.");
                break; // End of game
            case 3:
                Console.WriteLine("You begin to walk away from the river, but suddenly, a strange creature emerges from the water and attacks you, killing you. Game over.");
                break; // End of game
        }
    }

    // Function for the Light Path
    static void LightPath()
    {   
        // Introduction to the light path
        Console.WriteLine("You get closer and closer to the light you observed. When you do so, you can see an old cabin.");
        Console.WriteLine("");

        // Presenting choices to the player
        Console.WriteLine("\nWhat are you doing?");
        Console.WriteLine("1. Enter the cabin.");
        Console.WriteLine("2. Keep walking.");

        // Get user choice
        int choice = GetUserChoice(1, 3);

        switch (choice)
        {
            case 1:
                EnterCabin(); // Call the function
                break;
            case 2:
                ContinueWalking(); // Call the function
                break;
        }
    }

// Function for when the player decides to enter the cabin
    static void EnterCabin()
    {   
        // Introduction to the enter cabin choice
        Console.WriteLine("The cabin is cozy, and you notice that the fireplace is burning. It seems that someone else has been there recently.");
        Console.WriteLine("");

        // Presenting choices to the player
        Console.WriteLine("\nWhat are you doing?");
        Console.WriteLine("1. Remove yourself from the place.");
        Console.WriteLine("2. Wait for the owner to arrive.");

        // Get user choice
        int choice = GetUserChoice(1, 2);

        switch (choice)
        {
            case 1:
                Console.WriteLine("You decide not to stay in the cabin and continue on your path. Unfortunately, you walk for hours and hours, unable to find a way out. You become hopelessly lost in the forest. Game over.");
                break; // End of game
            case 2:
                WaitForOwner();
                break;
        }
    }

    // Function for when the player decides to keep walking
    static void ContinueWalking()
    {   
        // Introduction to the continue walking choice
        Console.WriteLine("As you continue walking, you feel more and more fearful. Suddenly, a wounded wolf jumps towards you and tries to attack you.");
        Console.WriteLine("");


        // Presenting choices to the player
        Console.WriteLine("\nWhat are you doing?");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Try to defend yourself using a nearby branch.");

        // Get user choice
        int choice = GetUserChoice(1, 2);

        switch (choice)
        {
            case 1:
                Console.WriteLine("You choose to run. You sprint as fast as your legs allow you until you are able to lose the wolf. In the distance, you see a light and find the way out of the forest. Congratulations!");
                break; // End of game
            case 2:
                Console.WriteLine("You choose to try to defend yourself using a nearby branch. Unfortunately, the wolf breaks it, and you are not able to defeat it, losing your life. Game over.");
                break; // End of game
        }
    }

// Function for when the player decides to wait for the owner of the cabin
    static void WaitForOwner()
    {   
        // Introduction to the wait for owner choice
        Console.WriteLine("The owner of the place arrives, an old woman. She doesn't inspire confidence in you, but you still decide to interact with her.");
        Console.WriteLine("");

        // Presenting choices to the player
        Console.WriteLine("\nWhat are you doing?");
        Console.WriteLine("1. Ask her how to find the way out of the forest.");
        Console.WriteLine("2. Ask her if you can stay at the cabin for a few days.");

        // Get user choice
        int choice = GetUserChoice(1, 2);

        switch (choice)
        {
            case 1:
                Console.WriteLine("The lady kindly provides you with the requested information and tells you which paths to take to safely exit the forest, which you are able to do. Congratulations!");
                break; // End of game
            case 2:
                Console.WriteLine("The old woman kindly allows you to stay for a few days and offers to help you find the right path out of the forest. Together, you and the old woman navigate through the forest, and with her guidance, you finally find the right path to safety. Congratulations!");
                break; // End of game
        }
    }

    // Function to get user choice with input validation
    static int GetUserChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            Console.Write("Enter your choice: "); // Ask the user to enter a choice
            if (int.TryParse(Console.ReadLine(), out choice)) // try to parse the choice as an intenger
            {
                if (choice >= min && choice <= max) // Checks if the chocie is inside of the valid range
                    break; // if the choice is valid, exit the loop
            }
            Console.WriteLine("Invalid choice. Please enter a number between {0} and {1}.", min, max); // if the player writes an invalid choice, the message will show up
        }
        return choice;
    }
}
