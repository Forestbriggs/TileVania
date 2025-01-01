# Tilevania

A charming 2D platformer where players guide the adventurous Ginger through challenging levels filled with obstacles and enemies. Run, jump, and climb your way through this meticulously crafted world while avoiding the mischievous Goobers that patrol the platforms.

## Features

### Core Gameplay
- **Fluid Movement System**: Precise platforming mechanics including running, jumping, and climbing
- **Dynamic Enemies**: Face off against patrol-based enemies that react to their environment
- **Physics-Based Interactions**: Experience realistic movement and collision responses
- **Smooth Camera System**: State-driven camera transitions that enhance the gaming experience

### Controls
| Action | Key |
|--------|-----|
| Move Left/Right | Arrow Keys / A,D |
| Jump | Spacebar |
| Climb | Up/Down Arrow / W,S |

## Technical Implementation

### Core Systems
- **Player Framework**: Built on Unity's Rigidbody2D system for authentic physics-based movement
- **Enemy AI**: Smart patrolling system with boundary detection and direction changes
- **Animation System**: Rich animation sets for both player and enemies
  - Player: Running, Climbing, Dying, Idle, and Rolling animations
  - Enemies: Unique Goober movement animations

### Architecture
The game is built with a modular architecture focusing on two main components:

#### PlayerMovement.cs
- Handles all player-related actions and states
- Manages physics interactions
- Controls animation state transitions
- Processes ground and climbing layer interactions

#### EnemyMovement.cs
- Controls enemy patrol behaviors
- Manages directional changes
- Handles sprite orientation
- Processes collision detection

## Getting Started

### Prerequisites
- Unity 2021 or newer
- Basic understanding of Unity interface

### Installation
1. Clone the repository to your local machine
2. Open the project in Unity
3. Load the main scene
4. Press Play to test the game

## Roadmap

### Planned Features
- Scoring system with collectible items
- Additional level designs with unique challenges
- Expanded enemy variety with different behavior patterns
- Enhanced AI systems for more dynamic gameplay

## Technical Details

### Layers
- Ground: For platform collision detection
- Climbing: For ladder and wall interaction

### Animation Controllers
- Player.controller: Manages all player animation states and transitions
- Goober.controller: Controls enemy animation sequences
