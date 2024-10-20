# Vitality-Ventures
This app is designed for university students who have moved away from their families and are living alone, offering a fun and engaging way to cook at home while staying connected with family or friends. It blends cooking tutorials with interactive social features, making home cooking a shared, joyful experience.

# Augmented Reality Application
## Features
- Displaying the list of ingredients
- The recipe with necessary steps for the user to follow
- Cooking timer
- Animated food ingredient characters with tips and encouragment
- Video streaming to the web application
- Highlighting fingers from the web app user
- Taking Screenshots and recording videos

## How to Use
- Open the application "3500_2" in Hololens.
- Follow the steps in the recipe on the right. Tick the checkbox of each step when it is done.
- The ingredients are listed on the left. Users can put the ingredients prepared beneath it.
- The highlighting finger is controlled by the web application users to point out where they want the AR application user to look at (Simulation only).
- Use the clock button to start the timer when needed.
- Characters of ingredients (such as egg and tomato) will provide some hints and encouragment during the cooking process.
- A congratulation message will pop up when all the steps are done.

# Web Application
## Features
- Live stream of the hololens feed 
- Recipe book & ability to edit recipe steps
- Photo album page
## How to Use
- Open Microsoft hololens application and choose to the live stream option
- Leave this open on the screen
- Open OBS or an equivalent streaming device, and choose to stream to Youtube

- On a diffrent computer -
- Once the stream is active copy this part of the youtube URL following the part "v="
- For this link https://www.youtube.com/watch?v=9P_xmUdbeus the ID would be "9P_xmUdbeus"
- --- Find this part of the code in index HTML and replace the ID after "embed/" and before "?" with the ID attained in the previous step ---
- <div class="video-placeholder">
        <iframe src="https://www.youtube.com/embed/[INSERT ID HERE]?autoplay=1&controls=0&modestbranding=1&showinfo=0" 
                frameborder="0" allow="autoplay; encrypted-media" allowfullscreen></iframe>
  </div>  
- Now when you open this webpage it will receive the stream feed from youtube of the hololens app. 
