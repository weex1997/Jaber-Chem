<!-- PROJECT LOGO -->
<div>
  <h3>
    <img align="left" width="200" height="200" src="images/f11805456d9f3d08.png"><br/>
    Jaber Chem
  </h3>
</div>   

<br/>

<br/>

<br/>
<br/>


## Project Info
**Role:** Game Programmer
<br/>
**Team Size:** 8
<br/>
**Duration:** 2 week
<br/>
**Tech:** Unity, C#, DoTween

> [!NOTE]
> **Installation GUIDE:**
> <br/>
> Unity Version: 2020.3.34f1



## Introduction

During my time at GamifierSA, I worked on the Jaber Chem educational project, where I was responsible for programming an Electron Configuration mini-game. The game was inspired by the rapid-fire format of WarioWare, Inc.: Mega Microgames! (2003) and aimed to teach chemistry concepts through fast-paced challenges. My primary role was to implement the game's mechanics, logic, and functionality based on the design specifications provided by the team.

<div style="display: flex; gap: 10px;">
  <img src="Assets/images/Screenshot 2024-01-29 110729.png" height="200"/>
  <img src="Assets/images/unnamed.png" height="200"/>
</div>



##  Main Mechanics

### Number of electrons in each shell
The number of electrons in each shell follows a pattern based on the quantum mechanical model of the atom. The maximum number of electrons that can occupy a particular shell is given by the formula 2n2, where "n" represents the shell number.
Here's a summary of the number of electrons in each shell:
- Shell K (n = 1): Maximum 2 electrons
- Shell L (n = 2): Maximum 8 electrons
- Shell M (n = 3): Maximum 18 electrons
- Shell N (n = 4): Maximum 32 electrons
- Shell O (n = 5): Maximum 50 electrons
- Shell P (n = 6): Maximum 72 electrons
I devised a calculation to distribute electrons in a circular pattern. Considering that a complete circle consists of 360 degrees, I divided this value by the number of electrons in the shell. This allowed me to spawn an electron point for each segment determined by the calculation.

## &nbsp;

### Features

#### High Score System with PlayFab

<div style="display: flex; gap: 10px;">
  <img src="images/Screenshot 2024-01-27 220106.png" width="300"/>
  <img src="images/Screenshot 2024-01-27 220254.png" width="300"/>
</div>

I integrated the **PlayFab API** to allow player names and high scores to be saved online.  
A custom service manager sends requests from Unity to the PlayFab server, storing player data and displaying a leaderboard.  
Players can also generate random names for a faster experience.

## &nbsp;

#### Share Results on Social Media

<img src="images/photo_2024-01-27_22-12-28.jpg" width="300"/>

To increase player engagement, I added a feature that allows players to **share their game results** on social media.  
I captured all guesses and progress in a single camera view and generated a combined screenshot. Players can then share this image with a custom message.

## &nbsp;

#### Enhanced Guessing Aids

<img src="images/Screenshot 2024-01-29 110840.png" width="300"/>

To help players guess more effectively, I added interactive **analytics tools**:
- Players can **click numbers** to highlight or mark them.
- Two types of marks are supported: `"X"` for ruled-out digits and `"O"` for likely candidates.


