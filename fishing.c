#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MAX_FISH 10
#define MAX_TIME 10

void clearInputBuffer() {
    while (getchar() != '\n');
}

int main()
{
    srand(time(NULL));

    printf("Welcome to the Fishing Game!\n");
    printf("You have %d seconds to catch as many fish as possible.\n", MAX_TIME);
    printf("Press ENTER to start...\n");
    getchar(); // Wait for user input

    int score = 0;
    time_t startTime = time(NULL);
    time_t currentTime;

    while ((currentTime = time(NULL)) - startTime <= MAX_TIME)
    {
        system("csl");

        printf("Time remaining: %ld seconds\n", MAX_TIME - (currentTime - startTime));
        printf("Fish caught: %d\n", score);

        //Display fishing prompt
        printf("\nPress ENTER to reel in the fish!\n");

        // Check if the user pressed ENTER within 2 seconds
        time_t reelStartTime = time(NULL);
        while (time(NULL) - reelStartTime <= 2)
        {
            if (getchar() == '\n')
            {
                // Player caught a fish
                score++;
                break;
            }
        }

        // Generate a random chance of a fish getting away
        if (rand() % 5 == 0)
        {
            printf("Too slow lol\n");
        }
    }

    printf("\nGame Over!\n");
    printf("Your final score: %d fish\n", score);

    return 0;
}
