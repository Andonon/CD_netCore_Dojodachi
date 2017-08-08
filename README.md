# CD_netCore_Dojodachi
Troy Center troycenter1@gmail.com August 2017   
Coding Dojo c# and .net Core fundamentals, assignment: Dojodachi

## Dojodachi
For this assignment, you're going to create a virtual pet, a Dojodachi! Dojodachis have happiness, fullness, and energy that we need to max out. You can feed, play with, work, or sleep to manage these values. if you can get your Dojodachi's fullness, happiness, and energy above 100, you win! But if fullness or happiness falls to zero, your Dojodachi will die :(.

    Your Dojodachi should start with 20 happiness, 20 fullness, 50 energy, and 3 meals.
 
    After every button press, display a message showing how the Dojodachi reacted
    
    Feeding your Dojodachi costs 1 meal and gains a random amount of fullness between 5 and 10 (you cannot feed your Dojodachi if you do not have meals)
    Playing with your Dojodachi costs 5 energy and gains a random amount of happiness between 5 and 10
    
    Every time you play with or feed your dojodachi there should be a 25% chance that it won't like it. Energy or meals will still decrease, but happiness and fullness won't change.
    Working costs 5 energy and earns between 1 and 3 meals
    
    Sleeping earns 15 energy and decreases fullness and happiness each by 5
    
    If energy, fullness, and happiness are all raised to over 100, you win! a restart button should be displayed.
    
    If fullness or happiness ever drop to 0, you lose, and a restart button should be displayed.

<img src="http://s3.amazonaws.com/General_V88/boomyeah/company_209/chapter_4028/handouts/chapter4028_7643_Dojodachi-Wireframe.png" alt="Coding Dojo Assignment Image">

    BONUS: Make all buttons EXCEPT restart be AJAX calls!
    BONUS: After each button press, display an image reflecting the Dojodachi's reaction (Happy, Sad, etc...)